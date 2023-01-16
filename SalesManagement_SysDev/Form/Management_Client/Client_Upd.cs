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
        public Client_Upd()
        {
            InitializeComponent();
        }

        private void buttonUpd_Click(object sender, EventArgs e)
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
            dataGridView1.DataSource = clients;

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
                if (clientDataAccess.CheckClientCDExistence(int.Parse(textBoxSoID.Text.Trim())))
                {
                    messageDsp.DspMsg("M1007");　//入力された営業所IDは既に存在しています
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
                if (!dataInputFormCheck.CheckFullWidth(textBoxClAddress.Text.Trim()))
                {
                    messageDsp.DspMsg("M1032"); //MessageBox.Show("住所は全角入力です");
                    textBoxClAddress.Focus();
                    return false;
                }
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
            if (!dataInputFormCheck.CheckFullWidth(textBoxClHidden.Text.Trim()))
            {
                messageDsp.DspMsg("M2037");　//MessageBox.Show("非表示理由は全角入力です"); 
                textBoxClHidden.Focus();
                return false;
            }
            if (checkBoxClFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("フラグが不確定の状態です"); //messageDsp.DspMsg("M40０4");
                checkBoxClFlag.Focus();
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
                ClHidden = textBoxClHidden.Text
            };
        }
        private void UpdateItem(M_Client updItem)
        {
            DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            bool flg = clientDataAccess.UpdClientData(updItem);
            if (flg == true)
                messageDsp.DspMsg("M1026");　//顧客データを更新しました
            //MessageBox.Show("ok");
            else
                messageDsp.DspMsg("M1027"); //顧客データ更新に失敗しました
            //MessageBox.Show("no");
        }
        private M_clhistory GenerateDataAtUpdatehistory()
        {
            var context = new SalesManagement_DevContext();
            var clhistorie = context.M_Clhistory.Single(x => x.ClID == textBoxSoID.Text);
            DateTime dt = DateTime.Now;
            string regtime = dt.ToString("MM/dd HH;mm");
            return new M_clhistory
            {
                ClID= textBoxSoID.Text,
                UpDateTime = regtime,
                LastupdatedUserID = template.EmID.ToString(),
                LastupdatedUserName = template.loginName
            };
        }
        private void Updateuphistory(M_clhistory uphistory)
        {
            bool flg = clientDataAccess.UpdclhistoryData(uphistory);
        }

        private void Client_Upd_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            setdata();
            SetFormDataGridView();
        }
        private void setdata()
        {
            clients = clientDataAccess.GetClientDspData();
            dataGridView1.DataSource = clients;
        }
        private void SetFormDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "10";
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void change_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridView1.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();
            labelPage.Text = "/" + ((int)Math.Ceiling(clients.Count / (double)pageSize)) + "ページ";

            dataGridView1.Refresh();
        }

        private void buttonFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            dataGridView1.DataSource = clients.Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            
                int pageSize = int.Parse(textBoxPageSize.Text);
                int pageNo = int.Parse(textBoxPageNo.Text) - 2;
                dataGridView1.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();
                // DataGridViewを更新
                dataGridView1.Refresh();
                //ページ番号の設定
                if (pageNo + 1 > 1)
                    textBoxPageNo.Text = (pageNo + 1).ToString();
                else
                    textBoxPageNo.Text = "1";

            }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(clients.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridView1.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(clients.Count / (double)pageSize);
            if (pageNo >= lastPage)
                textBoxPageNo.Text = lastPage.ToString();
            else
                textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(clients.Count / (double)pageSize) - 1;
            dataGridView1.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxClID.Text = "";
            textBoxClName.Text = "";
            textBoxSoID.Text = "";
            textBoxClPhone.Text = "";
            textBoxClAddress.Text = "";
            checkBoxClFlag.Checked = false;
            textBoxClPostal.Text = "";
            textBoxClFAX.Text = "";
            textBoxClHidden.Text = "";
        }

        private void textBoxClFAX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxClPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
