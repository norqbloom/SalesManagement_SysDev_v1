using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Chumon
{
    public partial class Chumon_Ser : Form
    {
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        MessageDsp messageDsp = new MessageDsp();
        ChumonDataAccess chumonDataAccess = new ChumonDataAccess();
        StockDataAccess stockDataAccess = new StockDataAccess();
        private static List<T_Chumon> chumons;
        private static List<T_Chhistory> history;
        private static List<T_ChumonDetail> chumondetail;
        private static List<T_ChumonDetail> chumondetailherasu;
        private static List<T_ChumonDetail> chumo;
        private static int grid = 10;

        private void invcnt()
        {
            //label5.Visible = false;
            //IDtxt.Visible = false;
            //datetime.Visible = false;
            //userid.Visible = false;
            //username.Visible = false;
            //uptime.Visible = false;
            //upuserid.Visible = false;
            //upusername.Visible = false;
        }
        private void incntok()
        {
            //label5.Visible = true;
            //IDtxt.Visible = true;
            //datetime.Visible = true;
            //userid.Visible = true;
            //username.Visible = true;
            //uptime.Visible = true;
            //upuserid.Visible = true;
            //upusername.Visible = true;
        }

        public Chumon_Ser()
        {
            InitializeComponent();
        }

        private void button_Ser_Click(object sender, EventArgs e)
        {
            //入力データ確認
            if (!GetChumonDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }

        private void button_Con_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewDsp.CurrentRow;
            DataGridViewCell cell = selectedRow.Cells[0];
            int chumon_id = (int)cell.Value;
            GenerateDataAtConfirm(chumon_id);
            // 注文確定処理

            /// IDから該当注文を取り出す
            /// 該当注文を確定にする
            /// 社員IDを保存
            /// 確定にした注文を保存する
            /// 在庫減らす
            /// 出庫テーブルにデータ作成
            /// 
            //T_Chumon chu = chumonDataAccess.GetChumonDataByChId(chumon_id);

            int number = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;

            //在庫数減らす処理ここから↓
            //注文ID取得←dataGridView[0]
            int herasu = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            //注文IDから注文詳細のデータを取得
            //詳細の数量と商品IDから在庫数を減らす
            GenerateDataAtReduce();

            var regSyukko = GenerateDataAtRegistrationSyukko();
            RegistrationSyukko(regSyukko);
            GenerateDataAtRegistrationSyukkoDetail();
            //var regSyukkoDetail = GenerateDataAtRegistrationSyukkoDetail();
            //RegistrationSyukkoDetail(regSyukkoDetail);
            dataGridViewDsp.Refresh();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            var Chumondel = GenerateChumonDelete();
            Chumon_delete(Chumondel);
        }

        private void button_Cle_Click(object sender, EventArgs e)
        {

        }

        private void Chumon_Ser_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            invcnt();
            chumons = chumonDataAccess.GetChumonDspData();
            dataGridViewDsp.DataSource = chumons;
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            dataGridViewDsp.DataSource = chumons.Take(pageSize).ToList();
            //DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridViewDsp.DataSource = chumons.Skip(pageSize * pageNo).Take(pageSize).ToList();
            //DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(chumons.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = chumons.Skip(pageSize * pageNo).Take(pageSize).ToList();

            //DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(chumons.Count / (double)pageSize);
            if (pageNo >= lastPage)
                textBoxPageNo.Text = lastPage.ToString();
            else
                textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(chumons.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = chumons.Skip(pageSize * pageNo).Take(pageSize).ToList();

            //DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private bool GetChumonDataAtSelect()
        {
            //注文データの確認
            //if (!String.IsNullOrEmpty(textBoxChID.Text.Trim()))
            //{
            //    //文字種チェック
            //    if (!dataInputFormCheck.CheckNumeric(textBoxChID.Text.Trim()))
            //    {
            //        messageDsp.DspMsg("注文IDが半角数字入力です"); //messageDsp.DspMsg("M5035");
            //        textBoxChID.Focus();
            //        return false;
            //    }
            //    messageDsp.DspMsg("注文IDが入力されていません"); //messageDsp.DspMsg("M5035");
            //    textBoxChID.Focus();
            //    return false;
            //}

            ////営業所IDの確認
            //if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            //{
            //    //文字種チェック
            //    if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
            //    {
            //        messageDsp.DspMsg("営業所IDは6文字です"); //messageDsp.DspMsg("M1008");
            //        textBoxSoID.Focus();
            //        return false;
            //    }
            //}

            ////社員IDの確認
            //if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            //{
            //    //文字種チェック
            //    if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
            //    {
            //        messageDsp.DspMsg("社員IDは6文字です"); //messageDsp.DspMsg("M6002");
            //        textBoxEmID.Focus();
            //        return false;
            //    }
            //}

            return true;
        }

        private void GenerateDataAtSelect()
        {
            if (!String.IsNullOrEmpty(textBoxChID.Text.Trim()))
            {
                //if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
                //{
                //    if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                //    {
                //全て入力されている
                datedubblwget();
                return;

                //        }
                //        else
                //        {
                //            //注文・営業所のみ
                //            dateChSoget();
                //            return;
                //        }
                //    }
                //    else
                //    {
                //        //注文・社員のみ
                //        dateChEmget();
                //        return;
                //    }
                //}
                //else if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
                //{
                //    if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                //    {
                //        //営業所・社員のみ
                //        dateSoEmget();
                //        return;
                //    }
                //    else
                //    {
                //        //営業所のみ
                //        dateSoget();
                //        return;
                //    }
                //}
                //else if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                //{
                //    //社員のみ
                //    dateEmget();
                //    return;
            }
            //else
            //{
            //    //何も入力されていない
            //    datenolwget();
            //    return;
            //}
        }

        private void SetSelectData()
        {
            dataGridViewDsp.DataSource = chumons;
        }

        private void datedubblwget()
        {
            T_Chumon selectCondition = new T_Chumon()
            {
                ChID = int.Parse(textBoxChID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                //EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ChDate = DateTime.Parse(dateTimePickerChDate.Text.Trim())
            };
            chumons = chumonDataAccess.Getdubblwdata(selectCondition);
        }

        private void datenoget()
        {
            T_Chumon selectCondition = new T_Chumon()
            {

                ChDate = DateTime.Parse(dateTimePickerChDate.Text.Trim())
            };
            chumons = chumonDataAccess.Getnodata(selectCondition);
        }

        ///////////////////////////////
        //メソッド名：SetFormDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューの設定
        ///////////////////////////////

        private void SetFormDataGridView()
        {
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDsp.ReadOnly = true;
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView()
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = chumons.Skip(pageSize * pageNo).Take(pageSize).ToList();
            labelPage.Text = "/" + ((int)Math.Ceiling(chumons.Count / (double)pageSize)) + "ページ";
            //DataGridViewを更新
            dataGridViewDsp.Refresh();
        }

        private T_Chumon GenerateChumonDelete()
        {
            int checkS;
            checkS = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            return new T_Chumon
            {
                ChID = checkS,
                ChFlag = 2
            };
        }

        private void Chumon_delete(T_Chumon Chumondel)
        {
            DialogResult result = MessageBox.Show("削除しますか？", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg = chumonDataAccess.DeleteChumonData(Chumondel);
            if (flg == true)
                MessageBox.Show("削除しました");
            else
                MessageBox.Show("削除に失敗しました");
        }

        private void GenerateDataAtConfirm(int conChumon)
        {
            bool flg = chumonDataAccess.ConfirmChumonData(conChumon);
            DialogResult result = MessageBox.Show("確定しますか");
            //DialogResult result = messageDsp.DspMsg("");
            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (flg == true)
            {
                MessageBox.Show("確定しました");
                //messageDsp.DspMsg("");
            }
            else
            {
                MessageBox.Show("確定できませんでした");
                //messageDsp.DspMsg("");
            }
            textBoxChID.Focus();
        }

        private void GenerateDataAtReduce()
        {
            ChIDsyutoku();
            foreach (var herasu in chumondetailherasu)
            {
                bool flg = stockDataAccess.UpdateStockData(herasu);
            }
        }

        private void ChIDsyutoku()
        {
            int ChID = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            T_Chumon ChSerch = new T_Chumon
            {
                ChID = ChID
            };
            chumondetailherasu = chumonDataAccess.GetChIDdata(ChSerch);
        }

        private T_Syukko GenerateDataAtRegistrationSyukko()
        {
            int syukko = (int)dataGridViewDsp.CurrentCell.ColumnIndex;
            int checkFlg;
            string hidden;
            if (checkBoxChStateFlag.Checked == true)
            {
                checkFlg = 2;
            }
            else
            {
                checkFlg = 0;
            }
            hidden = dataGridViewDsp.CurrentRow.Cells[8].Value.ToString();

            return new T_Syukko
            {
                ClID = (int)dataGridViewDsp.CurrentRow.Cells[3].Value,
                SoID = (int)dataGridViewDsp.CurrentRow.Cells[1].Value,
                OrID = (int)dataGridViewDsp.CurrentRow.Cells[4].Value,
                SyDate = null,
                SyStateFlag = 0,
                SyFlag = checkFlg,
                SyHidden = hidden
            };
        }

        private void RegistrationSyukko(T_Syukko regSyukko)
        {
            bool flg = chumonDataAccess.AddsyukkoData(regSyukko);
        }

        private void GenerateDataAtRegistrationSyukkoDetail()
        {
            int syukkodetail = (int)dataGridViewDsp.CurrentCell.ColumnIndex;
            //int checkFlg;
            string hidden;
            //if (checkBoxChStateFlag.Checked == true)
            //{
            //    checkFlg = 2;
            //}
            //else
            //{
            //    checkFlg = 0;
            //}
            hidden = dataGridViewDsp.CurrentRow.Cells[8].Value.ToString();

            chserch();

            foreach (var chs in chumondetail)
            {
                bool flg;
                flg = GenerateDataSyukkoDetail(chs);
            }

        }
        private void chserch()
        {
            int chid = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            T_Chumon serchch = new T_Chumon
            {
                ChID = chid
            };
            chumondetail = chumonDataAccess.GetChIDdata(serchch);
        }

        private void RegistrationSyukkoDetail(T_SyukkoDetail regSyukkoDetail)
        {
            bool flg = chumonDataAccess.AddsyukkoDetailData(regSyukkoDetail);
        }

        private bool GenerateDataSyukkoDetail(T_ChumonDetail upch)
        {
            T_SyukkoDetail selectCondition = new T_SyukkoDetail
            {
                SyID = upch.ChID,
                PrID = upch.PrID,
                SyQuantity = upch.ChQuantity
            };
            bool flg;
            flg = chumonDataAccess.AddsyukkoDetailData(selectCondition);
            return flg;
        }

        private void dataGridViewDspOrder_SelectionChanged(object sender, EventArgs e)
        {
            int number;
            int ClIDtxt;
            number = (int)dataGridViewDsp.CurrentRow.Cells[1].Value;
            ClIDtxt = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            //label5.Text = ClIDtxt.ToString();

            serchdateset(number);
            setdatedetail();
        }

        private void serchdateset(int number)
        {
            T_Chhistory selectCondition = new T_Chhistory
            {
                ChID = number.ToString(),
            };
            history = chumonDataAccess.getdetail(selectCondition);
        }

        private void setdatedetail()
        {
            var x = history.FirstOrDefault();
            if (x == null)
            {
                invcnt();
                return;
            }

            //IDtxt.Text = x.ChID;
            //datetime.Text = x.RegisteredDate;
            //userid.Text = x.regUserID;
            //username.Text = x.regUserName;
            //uptime.Text = x.UpdateTime;
            //upuserid.Text = x.LastupdatedUserID;
            //upusername.Text = x.LastupdatedUserName;
            incntok();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxChID.Text = "";
            textBoxSoID.Text = "";
            textBoxEmID.Text = "";
            textBoxClID.Text = "";
            textBoxOrID.Text = "";
            dateTimePickerChDate.Value = DateTime.Now;
            checkBoxChStateFlag.Checked = false;
            textBoxChHidden.Text = "";

        }
    }
}
