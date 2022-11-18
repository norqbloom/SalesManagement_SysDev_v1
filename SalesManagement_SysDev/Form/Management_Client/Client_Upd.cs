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
            
        }
        private bool GetValidDataAtUpdate()
        {
            //顧客ID
            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                //入力チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxClID.Focus();
                    return false;
                }
                if (textBoxClID.TextLength > 6)
                {
                    messageDsp.DspMsg("M1002");
                    textBoxClID.Focus();
                    return false;
                }
                if (!clientDataAccess.CheckClientCDExistence(int.Parse(textBoxClID.Text.Trim())))
                {
                    messageDsp.DspMsg("M1003");
                    textBoxClID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1004");
                textBoxClID.Focus();
                return false;
            }

            //営業所ID
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                //入力チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1005");
                    textBoxSoID.Focus();
                    return false;
                }
                if (textBoxSoID.TextLength > 2)
                {
                    MessageBox.Show("営業所IDは2文字です");
                    textBoxSoID.Focus();
                    return false;
                }
                if (clientDataAccess.CheckClientCDExistence(int.Parse(textBoxSoID.Text.Trim())))
                {
                    messageDsp.DspMsg("M1007");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1008");
                textBoxSoID.Focus();
                return false;
            }
            //顧客名
            if (!String.IsNullOrEmpty(textBoxClName.Text.Trim()))
            {
                if (textBoxClName.TextLength > 50)
                {
                    messageDsp.DspMsg("M1010");
                    textBoxClName.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1011");
                textBoxClName.Focus();
                return false;
            }
            //郵便番号
            if (!String.IsNullOrEmpty(textBoxClPostal.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(textBoxClPostal.Text.Trim()))
                {
                    messageDsp.DspMsg("M1017");
                    textBoxClPostal.Focus();
                    return false;
                }
                if (textBoxClPostal.Text.Length > 7)
                {
                    messageDsp.DspMsg("M1018");
                    textBoxClPostal.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("郵便番号が入力されていません。");
                textBoxClPostal.Focus();
                return false;
            }
            //住所
            if (!String.IsNullOrEmpty(textBoxClAddress.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckFullWidth(textBoxClAddress.Text.Trim()))
                {
                    MessageBox.Show("住所は全角入力です");
                    textBoxClAddress.Focus();
                    return false;
                }
                if (textBoxClAddress.Text.Length > 50)
                {
                    messageDsp.DspMsg("M1012");
                    textBoxClAddress.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("住所が入力されていません。");
                textBoxClPostal.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(textBoxClFAX.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxClFAX.Text.Trim()))
                {
                    messageDsp.DspMsg("M1019");
                    textBoxClFAX.Focus();
                    return false;
                }
                if (textBoxClFAX.Text.Length > 13)
                {
                    messageDsp.DspMsg("M1020");
                    textBoxClFAX.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("FAXが入力されていません。");
                textBoxClFAX.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(textBoxClPostal.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxClPostal.Text.Trim()))
                {
                    messageDsp.DspMsg("M1015");
                    textBoxClPostal.Focus();
                    return false;
                }
                if (textBoxClPostal.Text.Length > 13)
                {
                    messageDsp.DspMsg("M1016");
                    textBoxClPostal.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません");
                textBoxClPostal.Focus();
                return false;
            }
            if (!dataInputFormCheck.CheckFullWidth(textBoxClHidden.Text.Trim()))
            {
                MessageBox.Show("非表示理由は全角入力です");
                textBoxClHidden.Focus();
                return false;
            }
            if (checkBoxClFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("");
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
                MessageBox.Show("ok");
            else
                MessageBox.Show("no");
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


    }

}
