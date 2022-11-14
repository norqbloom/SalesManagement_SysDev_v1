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
            if (!String.IsNullOrEmpty(ClID.Text.Trim()))
            {
                //入力チェック
                if (!dataInputFormCheck.CheckNumeric(ClID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    ClID.Focus();
                    return false;
                }
                if(ClID.TextLength > 6)
                {
                    messageDsp.DspMsg("M1002");
                    ClID.Focus();
                    return false;
                }
                if (clientDataAccess.CheckClientCDExistence(int.Parse(ClID.Text.Trim())))
                {
                    messageDsp.DspMsg("M1003");
                    ClID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1004");
                ClID.Focus();
                return false;
            }

            //営業所ID
            if (!String.IsNullOrEmpty(SoID.Text.Trim()))
            {
                //入力チェック
                if (!dataInputFormCheck.CheckNumeric(SoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1005");
                    SoID.Focus();
                    return false;
                }
                if (SoID.TextLength > 2)
                {
                    MessageBox.Show("営業所IDは2文字です");
                    SoID.Focus();
                    return false;
                }
                if (clientDataAccess.CheckClientCDExistence(int.Parse(SoID.Text.Trim())))
                {
                    messageDsp.DspMsg("M1007");
                    SoID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1008");
                SoID.Focus();
                return false;
            }
            //顧客名
            if (!String.IsNullOrEmpty(ClName.Text.Trim()))
            {
                if (ClName.TextLength > 50)
                {
                    messageDsp.DspMsg("M1010");
                    ClName.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1011");
                ClName.Focus();
                return false;
            }
            //郵便番号
            if (!String.IsNullOrEmpty(ClPostal.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(ClPostal.Text.Trim()))
                {
                    messageDsp.DspMsg("M1017");
                    ClPostal.Focus();
                    return false;
                }
                if (ClPostal.Text.Length > 7)
                {
                    messageDsp.DspMsg("M1018");
                    ClPostal.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("郵便番号が入力されていません。");
                ClPostal.Focus();
                return false;
            }
            //住所
            if (!String.IsNullOrEmpty(ClAddress.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckFullWidth(ClAddress.Text.Trim()))
                {
                    MessageBox.Show("住所は全角入力です");
                    ClAddress.Focus();
                    return false;
                }
                if(ClAddress.Text.Length > 50)
                {
                    messageDsp.DspMsg("M1012");
                    ClAddress.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("住所が入力されていません。");
                ClPostal.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(ClFAX.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(ClFAX.Text.Trim()))
                {
                    messageDsp.DspMsg("M1019");
                    ClFAX.Focus();
                    return false;
                }
                if(ClFAX.Text.Length > 13)
                {
                    messageDsp.DspMsg("M1020");
                    ClFAX.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("FAXが入力されていません。");
                ClFAX.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(ClPhone.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(ClPhone.Text.Trim()))
                {
                    messageDsp.DspMsg("M1015");
                    ClPhone.Focus();
                    return false;
                }
                if(ClPhone.Text.Length > 13)
                {
                    messageDsp.DspMsg("M1016");
                    ClPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません");
                ClPhone.Focus();
                return false;
            }
            if (!dataInputFormCheck.CheckFullWidth(ClHidden.Text.Trim()))
            {
                MessageBox.Show("非表示理由は全角入力です");
                ClHidden.Focus();
                return false;
            }
            if(ClFLG.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("");
                ClFLG.Focus();
                return false;
            }
          return true;
        }
        private M_Client GenerateDataAtRegistration()
        {
            int checkflg;
            if (ClFLG.Checked == true)
            {
                checkflg = 1;
            }
            else
            {
                checkflg = 0;
            }
            return new M_Client
            {
                ClID = int.Parse(ClID.Text),
                SoID = int.Parse(SoID.Text),
                ClName = ClName.Text,
                ClAddress = ClAddress.Text,
                ClPhone = ClPhone.Text,
                ClPostal = ClPostal.Text,
                ClFAX = ClFAX.Text,
                ClFlag = checkflg,
                ClHidden = ClHidden.Text
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
                ClID = ClID.Text,
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
