using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Client
{
    public partial class Client_Upd : Form
    {
        //メッセージ表示用クラスのインスタンス化
        MessageDsp messageDsp = new MessageDsp();
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        private static List<M_Client> clients;
        private static int grid = 30;
        private static int grid_ClFlg = 0;

        public Client_Upd()
        {
            InitializeComponent();
        }

        private void Client_Upd_Load(object sender, EventArgs e)
        {
            //adioButton1.Checked = true;
            setdata();
            SetFormDataGridView();
        }

        private void button_Upd_Click(object sender, EventArgs e)
        {
            //妥当な役職データ取得
            if (!GetValidDataAtUpdate())
            {
                return;
            }

            //役職情報作成
            var updItem = GenerateDataAtUpdate();

            var uphistory = GenerateDataAtUpdatehistory();
            Updateuphistory(uphistory);
            //役職情報更新
            UpdateItem(updItem);
            clients = clientDataAccess.GetClientDspData();
            dataGridViewDsp.DataSource = clients;

        }

        private void button_Cle_Click(object sender, EventArgs e)
        {
            textBoxClID.Text = "";
            textBoxClName.Text = "";
            textBoxSoID.Text = "";
            textBoxClPhone.Text = "";
            textBoxClAddress.Text = "";
            textBoxClPostal.Text = "";
            textBoxClFAX.Text = "";
            checkBoxClFlag.Checked = false;
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            dataGridViewDsp.DataSource = clients.Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridViewDsp.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();
            // DataGridViewを更新
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
            int lastNo = (int)Math.Ceiling(clients.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(clients.Count / (double)pageSize);
            if (pageNo >= lastPage)
                textBoxPageNo.Text = lastPage.ToString();
            else
                textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(clients.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private bool GetValidDataAtUpdate()
        {
            //顧客ID
            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                //入力チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");　//顧客IDは半角数字入力です
                    textBoxClID.Focus();
                    return false;
                }
                if (textBoxClID.TextLength > 6)
                {
                    messageDsp.DspMsg("M1002");　//顧客IDは６文字です
                    textBoxClID.Focus();
                    return false;
                }
                if (!clientDataAccess.CheckClientCDExistence(int.Parse(textBoxClID.Text.Trim())))
                {
                    messageDsp.DspMsg("M1003");　//入力された顧客IDは既に存在しています
                    textBoxClID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1004");　//顧客IDが入力されていません
                textBoxClID.Focus();
                return false;
            }

            //営業所ID
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                //入力チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1005");　//営業所IDは半角数字入力です
                    textBoxSoID.Focus();
                    return false;
                }
                if (textBoxSoID.TextLength > 2)
                {
                    messageDsp.DspMsg("M1006");　//営業所IDは2文字です
                    textBoxSoID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1008");　//営業所IDが入力されていません
                textBoxSoID.Focus();
                return false;
            }
            //顧客名
            if (!String.IsNullOrEmpty(textBoxClName.Text.Trim()))
            {
                if (textBoxClName.TextLength > 50)
                {
                    messageDsp.DspMsg("M1010");　//顧客名は50文字以下です
                    textBoxClName.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1011");　//顧客名が入力されていません
                textBoxClName.Focus();
                return false;
            }
            //郵便番号
            if (!String.IsNullOrEmpty(textBoxClPostal.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(textBoxClPostal.Text.Trim()))
                {
                    messageDsp.DspMsg("M1017");　//郵便番号は半角数値入力です
                    textBoxClPostal.Focus();
                    return false;
                }
                if (textBoxClPostal.Text.Length > 7)
                {
                    messageDsp.DspMsg("M1018");　//顧客郵便番号は7文字以下です
                    textBoxClPostal.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1031");　//MessageBox.Show("郵便番号が入力されていません。"); 
                textBoxClPostal.Focus();
                return false;
            }
            //住所
            if (!String.IsNullOrEmpty(textBoxClAddress.Text.Trim()))
            {
                if (textBoxClAddress.Text.Length > 50)
                {
                    messageDsp.DspMsg("M1012");　//住所は50文字以下です
                    textBoxClAddress.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1033"); //MessageBox.Show("住所が入力されていません。");
                textBoxClPostal.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(textBoxClFAX.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxClFAX.Text.Trim()))
                {
                    messageDsp.DspMsg("M1019");　//FAX番号は半角数値入力です
                    textBoxClFAX.Focus();
                    return false;
                }
                if (textBoxClFAX.Text.Length > 13)
                {
                    messageDsp.DspMsg("M1020");　//FAX番号は12文字以下です
                    textBoxClFAX.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1034");　//MessageBox.Show("FAXが入力されていません。");
                textBoxClFAX.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(textBoxClPostal.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxClPostal.Text.Trim()))
                {
                    messageDsp.DspMsg("M1015");　//電話番号は半角数値入力です
                    textBoxClPostal.Focus();
                    return false;
                }
                if (textBoxClPostal.Text.Length > 13)
                {
                    messageDsp.DspMsg("M1016");　//電話番号は13文字以下です
                    textBoxClPostal.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1035");　//MessageBox.Show("電話番号が入力されていません");
                textBoxClPostal.Focus();
                return false;
            }

            return true;
        }

        private M_Client GenerateDataAtUpdate()
        {
            int checkflg;
            if (checkBoxClFlag.Checked == true)
            {
                checkflg = 1;
            }
            else
            {
                checkflg = 0;
            }
            return new M_Client
            {
                ClID = int.Parse(textBoxClID.Text),
                SoID = int.Parse(textBoxSoID.Text),
                ClName = textBoxClName.Text,
                ClAddress = textBoxClAddress.Text,
                ClPhone = textBoxClPostal.Text,
                ClPostal = textBoxClPostal.Text,
                ClFAX = textBoxClFAX.Text,
                ClFlag = checkflg,
                //ClHidden = textBoxClHidden.Text
            };
        }

        private void UpdateItem(M_Client updItem)
        {
            DialogResult result = messageDsp.DspMsg("M1025");
            if (result == DialogResult.Cancel)
                return;
            bool flg = clientDataAccess.UpdClientData(updItem);
            if (flg == true)
                messageDsp.DspMsg("M1026");　//顧客データを更新しました
            else
                messageDsp.DspMsg("M1027"); //顧客データ更新に失敗しました
        }
        private M_clhistory GenerateDataAtUpdatehistory()
        {
            var context = new SalesManagement_DevContext();
            var clhistorie = context.M_Clhistory.Single(x => x.ClID == textBoxClID.Text);
            DateTime dt = DateTime.Now;
            string regtime = dt.ToString("MM/dd HH;mm");
            return new M_clhistory
            {
                ClID = textBoxClID.Text,
                UpDateTime = regtime,
                LastupdatedUserID = template.EmID.ToString(),
                LastupdatedUserName = template.loginName
            };
        }
        private void Updateuphistory(M_clhistory uphistory)
        {
            bool flg = clientDataAccess.UpdclhistoryData(uphistory);
        }

        private void setdata()
        {
            clients = clientDataAccess.GetClientDspData();
            dataGridViewDsp.DataSource = clients;
        }
        private void SetFormDataGridView()
        {
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDsp.ReadOnly = true;
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GetDataGridView();

        }

        private void SetDataGridView()
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();
            labelPage.Text = "/" + ((int)Math.Ceiling(clients.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void GetDataGridView()
        {

            int radioint = 0;
            // 商品データの取得
            clients = clientDataAccess.GetClientDataDsp(radioint);
            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }   

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxClID.Text = dataGridViewDsp.CurrentRow.Cells[0].Value.ToString();
            textBoxSoID.Text = dataGridViewDsp.CurrentRow.Cells[1].Value.ToString();
            textBoxClName.Text = dataGridViewDsp.CurrentRow.Cells[2].Value.ToString();
            textBoxClAddress.Text = dataGridViewDsp.CurrentRow.Cells[3].Value.ToString();
            textBoxClPhone.Text = dataGridViewDsp.CurrentRow.Cells[4].Value.ToString();
            textBoxClPostal.Text = dataGridViewDsp.CurrentRow.Cells[5].Value.ToString();
            textBoxClFAX.Text = dataGridViewDsp.CurrentRow.Cells[6].Value.ToString();

            if ((int)dataGridViewDsp.CurrentRow.Cells[7].Value == 0)
            {
                checkBoxClFlag.Checked = false;
            }
            else
            {
                checkBoxClFlag.Checked = true;
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (checkBoxClFlag.Checked == true)
            {
                if (!String.IsNullOrEmpty(textBoxClHidden.Text.Trim()))
                {
                    int number = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
                    DialogResult result = messageDsp.DspMsg("M5555");//選択した項目を削除（非表示）にしますか？
                    if (result == DialogResult.OK)
                    {
                        clientDataAccess.delflg(number);
                        setdata();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    messageDsp.DspMsg("M2038");//非表示理由が入力されていません
                    textBoxClHidden.Focus();
                    return;
                }
            }
            else
            {
                messageDsp.DspMsg("M1037");//顧客管理フラグが不確定です
                checkBoxClFlag.Focus();
                return;
            }          
        }

        private void button_hide_nonhide_Click(object sender, EventArgs e)
        {
            if (button_hide_nonhide.Text == "表示")
            {
                button_hide_nonhide.Text = "非表示";
                grid_ClFlg = 2;
                clients = clientDataAccess.GetClientDataDsp(grid_ClFlg);
                SetDataGridView();
            }
            else
            {
                button_hide_nonhide.Text = "表示";
                grid_ClFlg = 0;
                clients = clientDataAccess.GetClientDataDsp(grid_ClFlg);
                SetDataGridView();
            }
        }
    }
}
