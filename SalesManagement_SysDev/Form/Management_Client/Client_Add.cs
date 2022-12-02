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
    public partial class Client_Add : Form
    {
        //メッセージ表示用クラスのインスタンス化
        MessageDsp messageDsp = new MessageDsp();
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        ClientDataAccess clientDataAccess = new ClientDataAccess();

        public Client_Add()
        {
            InitializeComponent();
        }

        private void Cli_Upd_Click(object sender, EventArgs e)
        {
            // 8.2.1.1 妥当な役職データ取得
            if (!GetclientDataAtRegistration())
                return;
            var regCl = GenerateDataAtRegistration();
            RegistrationClient(regCl);
            var reghis = GeneratehistoryDataAtRegistration();
            RegistrationClhistory(reghis);
        }
        private bool GetclientDataAtRegistration()
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
                if(textBoxClID.TextLength > 6)
                {
                    messageDsp.DspMsg("M1002");
                    textBoxClID.Focus();
                    return false;
                }
                if (clientDataAccess.CheckClientCDExistence(int.Parse(textBoxClID.Text.Trim())))
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
                    messageDsp.DspMsg("M1006");
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
                MessageBox.Show("郵便番号が入力されていません。"); //messageDsp.DspMsg("M1031");
                textBoxClPostal.Focus();
                return false;
            }
            //住所
            if (!String.IsNullOrEmpty(textBoxClAddress.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckFullWidth(textBoxClAddress.Text.Trim()))
                {
                    MessageBox.Show("住所は全角入力です"); //messageDsp.DspMsg("M1032");
                    textBoxClAddress.Focus();
                    return false;
                }
                if(textBoxClAddress.Text.Length > 50)
                {
                    messageDsp.DspMsg("M1012");
                    textBoxClAddress.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("住所が入力されていません。"); //messageDsp.DspMsg("M1033");
                textBoxClPostal.Focus();
                return false;
            }
            //FAX
            if (!String.IsNullOrEmpty(textBoxClFAX.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxClFAX.Text.Trim()))
                {
                    messageDsp.DspMsg("M1019");
                    textBoxClFAX.Focus();
                    return false;
                }
                if(textBoxClFAX.Text.Length > 13)
                {
                    messageDsp.DspMsg("M1020");
                    textBoxClFAX.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("FAXが入力されていません。"); //messageDsp.DspMsg("M1034");
                textBoxClFAX.Focus();
                return false;
            }
            //電話番号
            if (!String.IsNullOrEmpty(textBoxClPhone.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(textBoxClPhone.Text.Trim()))
                {
                    messageDsp.DspMsg("M1015");
                    textBoxClPhone.Focus();
                    return false;
                }
                if(textBoxClPhone.Text.Length > 13)
                {
                    messageDsp.DspMsg("M1016");
                    textBoxClPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません");
                textBoxClPhone.Focus();
                return false;
            }
            if (!dataInputFormCheck.CheckFullWidth(textBoxClHidden.Text.Trim()))
            {
                MessageBox.Show("非表示理由は全角入力です");
                textBoxClHidden.Focus();
                return false;
            }
            if(checkBoxClFLG.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("");
                checkBoxClFLG.Focus();
                return false;
            }
          return true;
        }
        private M_Client GenerateDataAtRegistration()
        {
            int checkflg;
            if (checkBoxClFLG.Checked == true)
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
                ClPhone = textBoxClPhone.Text,
                ClPostal = textBoxClPostal.Text,
                ClFAX = textBoxClFAX.Text,
                ClFlag = checkflg,
                ClHidden = textBoxClHidden.Text
            };
        }
        private void RegistrationClient(M_Client regClient)
        {
            DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            bool flg = clientDataAccess.AddClientData(regClient);
            if (flg == true)
                messageDsp.DspMsg("M1022");
            else
                messageDsp.DspMsg("M1023");

        }
        private M_clhistory GeneratehistoryDataAtRegistration()
        {
            DateTime dt = DateTime.Now;
            string regtime = dt.ToString("MM/dd HH;mm");

            return new M_clhistory
            {
                ClID = textBoxSoID.Text,
                RegisteredDate = regtime,
                regUserID = template.EmID.ToString(),
                regUserName = template.loginName,
                UpDateTime = "なし",
                LastupdatedUserID = "なし",
                LastupdatedUserName = "なし"

            };
        }
        private void RegistrationClhistory(M_clhistory reghistory)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Clhistory.Add(reghistory);
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
