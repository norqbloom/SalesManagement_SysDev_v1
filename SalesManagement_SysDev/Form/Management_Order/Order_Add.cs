using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Order
{
    public partial class Order_Add : Form
    {
        //メッセージ表示用クラスのインスタンス化
        MessageDsp messageDsp = new MessageDsp();
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        OrderDateAccess orderDateAccess = new OrderDateAccess();
        public Order_Add()
        {
            InitializeComponent();
        }
        private void Order_Add_Load(object sender, EventArgs e)
        {
            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //登録
            if (!GetclientDataAtRegistration())
                return;
            var regCl = GenerateDataAtRegistration();
            //RegistrationOrder(regOr);
        }

        private bool GetclientDataAtRegistration()
        {
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (textBoxOrID.Text.Length >= 6)
                {
                    MessageBox.Show("6文字いない");　//messageDsp.DspMsg("M4022");
                    textBoxOrID.Focus();
                    return false;
                }
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("数値のみ");　//messageDsp.DspMsg("M4023");
                    textBoxOrID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim())) //営業所
            {
                if (textBoxSoID.Text.Length >= 2)
                {
                    messageDsp.DspMsg("M1006");
                    textBoxSoID.Focus();
                    return false;
                }
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                   messageDsp.DspMsg("M1005");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))　//社員
            {
                if (textBoxEmID.Text.Length >= 6)
                {
                    messageDsp.DspMsg("M6002");
                    textBoxEmID.Focus();
                    return false;
                }
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                   messageDsp.DspMsg("M6002");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (textBoxClID.Text.Length >= 6)
                {
                    messageDsp.DspMsg("M1002");
                    textBoxClID.Focus();
                    return false;
                }
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxClID.Focus();
                    return false;
                }
            }

            //顧客担当者名
            if (!String.IsNullOrEmpty(textBoxClChange.Text.Trim()))
            {
                if (textBoxClChange.Text.Length >= 50)
                {
                    MessageBox.Show("50文字いない"); //messageDsp.DspMsg("M6029");
                    textBoxClChange.Focus();
                    return false;
                }
            }
            if (checkBoxOrStateFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("");
                checkBoxOrStateFlag.Focus();
                return false;
            }
            if (checkBoxOrFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("");
                checkBoxOrFlag.Focus();
                return false;
            }
            return true;
        }
        private T_Order GenerateDataAtRegistration()
        {
            int checkflg;
            if(checkBoxOrFlag.Checked == true)
            {
                checkflg = 1;
            }
            else
            {
                checkflg = 0;
            }
            return new T_Order
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
                OrStateFlag = int.Parse(checkBoxOrStateFlag.Text),
                OrFlag = checkflg,
                OrHidden = textBoxOrHidden.Text
            };
        }
        private void RegistrationClient(T_Order regClient)
        {
            DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            //bool flg = orderDataAccess.AddClientData(regClient);
            //if (flg == true)
            //    messageDsp.DspMsg("M1022");
            //else
            //    messageDsp.DspMsg("M1023");
            

        }
        private void Ord_Del_Button_Click(object sender, EventArgs e)
        {
            
           var Oderup = GenerateDel_Ord();
            Order_update(Oderup);
        }
        private T_Order GenerateDel_Ord()
        {
            int number;
            number = (int)dataGridView1.CurrentRow.Cells[0].Value;
            return new T_Order
            {
                OrID = number
            };
                 
        }

        private void Order_update(T_Order Orderup)
        {
            DialogResult result = MessageBox.Show("削除よろしいか",MessageBoxButtons.OKCancel.ToString());
            if(result==DialogResult.Cancel)
            {
                return;
            }
            bool flg = orderDateAccess.DeleteOrderData(Orderup);
            if (flg == true)
                MessageBox.Show("OK");
            else
                MessageBox.Show("NO");
        }


        private void checkBoxOrStateFlag_CheckedChanged(object sender, EventArgs e)
        {

        }

       
      

        //データグリッドビュー用のプロダクトデータ
        private static List<M_ProductDsp> Product2;
        ///////////////////////////////
        //メソッド名：SetFormDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューの設定
        ///////////////////////////////
        private void SetFormDataGridView()
        {
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "20";
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            //読み取り専用に指定
            dataGridViewDsp.ReadOnly = true;
            //行内をクリックすることで行を選択
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //ヘッダー位置の指定
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //データグリッドビューのデータ取得
            GetDataGridView();
        }
        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの取得
        ///////////////////////////////
        private void GetDataGridView()
        {

            // 商品データの取得
            Product2 = productDataAccess.GetProductData2();

            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }
        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Product2.Skip(pageSize * pageNo).Take(pageSize).ToList();

            //列名の中央揃え
            foreach (DataGridViewColumn clm in dataGridViewDsp.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //各列幅の指定
            dataGridViewDsp.Columns[0].Width = 80;
            dataGridViewDsp.Columns[1].Width = 80;
            dataGridViewDsp.Columns[2].Width = 200;
            dataGridViewDsp.Columns[3].Width = 200;
            dataGridViewDsp.Columns[4].Width = 200;
            dataGridViewDsp.Columns[5].Width = 80;
            dataGridViewDsp.Columns[6].Width = 80;
            dataGridViewDsp.Columns[7].Width = 200;
            dataGridViewDsp.Columns[8].Width = 150;
            dataGridViewDsp.Columns[9].Width = 100;
            dataGridViewDsp.Columns[10].Width = 200;

            //各列の文字位置の指定
            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dataGridViewの総ページ数
            labelPage.Text = "/" + ((int)Math.Ceiling(Product2.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();

        }
    }
}
