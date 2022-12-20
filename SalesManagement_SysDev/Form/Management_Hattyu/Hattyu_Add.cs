using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Hattyu
{
    public partial class Hattyu_Add : Form
    {
        //メッセージ表示用クラスのインスタンス化
        MessageDsp messageDsp = new MessageDsp();
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        HattyuDataAccess HattyuDateAccess = new HattyuDataAccess();
       EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();


        public Hattyu_Add()
        {
            InitializeComponent();
        }

        private void Hattyu_Add_Button_Click(object sender, EventArgs e)
        {
            //データ登録
            if (!GetHattyuDateRegistration())
                return;
            var regHa = GenerateDataAtRegistration();
            RegistrationHattyu(regHa);
        }
        private bool GetHattyuDateRegistration()
        {
            //HaIDの適否 　発注
            if (!string.IsNullOrEmpty(HaID.Text.Trim()))
            {
                //HaID半角英数字チェック
                if (!dataInputFormCheck.CheckNumeric(HaID.Text.Trim()))
                {
                    messageDsp.DspMsg("M4023"); //発注ID数値のみ;
                    HaID.Focus();
                    return false;
                }
                //Haid文字数チェック
                if (HaID.TextLength > 6)
                {
                    messageDsp.DspMsg("M4022"); //発注ID6文字以内
                    HaID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M4024"); //発注ID入力してない
                HaID.Focus();
                return false;
            }
            //メーカIDの適否
            if (!String.IsNullOrEmpty(MaID.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(MaID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2005");
                    MaID.Focus();
                    return false;
                }
                //文字数　
                if (MaID.TextLength > 6)
                {
                    messageDsp.DspMsg("M2006");
                    MaID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2008");
                MaID.Focus();
                return false;
            }
            //EmIDの確認 社員
            if (!String.IsNullOrEmpty(EmID.Text.Trim()))
            {
                //Emid半角英数チェック
                if (!dataInputFormCheck.CheckNumeric(EmID.Text.Trim()))
                {
                    messageDsp.DspMsg("M6001");
                    EmID.Focus();
                    return false;
                }
                //Emid文字数チェック
                if (EmID.TextLength > 6)
                {
                    messageDsp.DspMsg("M6002");
                    EmID.Focus();
                    return false;
                }
                //Emid重複チェック
                if (EmployeeDataAccess.CheckemployeeCDExistence(int.Parse(EmID.Text.Trim())))
                {
                    messageDsp.DspMsg("M6003");
                    EmID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M6004");
                EmID.Focus();
                return false;
            }


            //発注管理フラグ
            if (HaFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("発注フラグが不確定な状態です"); //messageDsp.DspMsg("M4028");
                HaFlag.Focus();
                return false;
            }

            //入庫済フラグ
            if (WaWarehouseFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("入庫済フラグが不確定な状態です"); //messageDsp.DspMsg("M4029");
                HaFlag.Focus();
                return false;
            }

            //非表示理由
            if (!dataInputFormCheck.CheckFullWidth(HaHidden.Text.Trim()))
            {
                MessageBox.Show("非表示理由は全角入力です"); //messageDsp.DspMsg("M2036");
                HaHidden.Focus();
                return false;
            }
            return true;
        }
        private T_Hattyu GenerateDataAtRegistration()
        {
            int checkflg;
            if (HaFlag.Checked == true)
            {
                checkflg = 1;
            }
            else
            {
                checkflg = 0;
            }
            return new T_Hattyu
            {
                HaID = int.Parse(HaID.Text),
                MaID = int.Parse(MaID.Text),
                EmID = int.Parse(EmID.Text),
                HaDate = HaDate.Value,
                //WaWarehouseFlag = checkflg,
                HaFlag = checkflg,
                HaHidden = HaHidden.Text
            };
        }
       private void RegistrationHattyu(T_Hattyu regHattyu)
        {
            DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            bool flg = HattyuDateAccess.AddHattyuData(regHattyu);
            if (flg == true)
                messageDsp.DspMsg("M1022");
            else
                messageDsp.DspMsg("M1023");

        }
    }
}


