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

        private void Cli_Upd_Button_Click(object sender, EventArgs e)
        {
            //妥当な役職データ取得
            if (GetValidDataAtUpdate())
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
            if (!String.IsNullOrEmpty(ClID.Text.Trim()))
            {
                //入力チェック
                if (!dataInputFormCheck.CheckNumeric(ClID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    ClID.Focus();
                    return false;
                }
                if (ClID.TextLength > 6)
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
                if (ClAddress.Text.Length > 50)
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
                if (ClFAX.Text.Length > 13)
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
            if (!String.IsNullOrEmpty(ClPostal.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(ClPostal.Text.Trim()))
                {
                    messageDsp.DspMsg("M1015");
                    ClPostal.Focus();
                    return false;
                }
                if (ClPostal.Text.Length > 13)
                {
                    messageDsp.DspMsg("M1016");
                    ClPostal.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません");
                ClPostal.Focus();
                return false;
            }
            if (!dataInputFormCheck.CheckFullWidth(ClHidden.Text.Trim()))
            {
                MessageBox.Show("非表示理由は全角入力です");
                ClHidden.Focus();
                return false;
            }
            if (ClFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("");
                ClFlag.Focus();
                return false;
            }
            return true;
        }
        private M_Client GenerateDataAtUpdate()
        {
            int checkflg;
            if (ClFlag.Checked == true)
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
                ClPhone = ClPostal.Text,
                ClPostal = ClPostal.Text,
                ClFAX = ClFAX.Text,
                ClFlag = checkflg,
                ClHidden = ClHidden.Text
            };
        }
        private void UpdateItem(M_Client updItem)
        {
            DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            bool flg = clientDataAccess.UpdClientData(updItem);
            if (flg == true)
                messageDsp.DspMsg("");
            else
                messageDsp.DspMsg("");
        }
        private M_clhistory GenerateDataAtUpdatehistory()
        {
            var context = new SalesManagement_DevContext();
            var clhistorie = context.M_Clhistory.Single(x => x.ClID == SoID.Text);
            DateTime dt = DateTime.Now;
            string regtime = dt.ToString("MM/dd HH;mm");
            return new M_clhistory
            {
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
