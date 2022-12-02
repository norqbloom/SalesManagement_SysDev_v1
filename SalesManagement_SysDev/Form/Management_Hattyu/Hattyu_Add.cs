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
        // OrderDateAccess HattyuDateAccess = new OrderDateAccess();

        public Hattyu_Add()
        {
            InitializeComponent();
        }

        private void Hattyu_Add_Button_Click(object sender, EventArgs e)
        {
            //登録
            if (!GetHattyuDateRegistration())
                return;
            //var regHa = GenerateDataAtRegistration();
        }
        private bool GetHattyuDateRegistration()
        {
            //HaIDの適否 　発注
            if (!string.IsNullOrEmpty(HaID.Text.Trim()))
            {
                //HaID半角英数字チェック
                if (!dataInputFormCheck.CheckNumeric(HaID.Text.Trim()))
                {
                    messageDsp.DspMsg("M"); //発注ID数値のみ;
                    HaID.Focus();
                    return false;
                }
                //Haid文字数チェック
                if (HaID.TextLength > 6)
                {
                    messageDsp.DspMsg("M"); //発注ID6文字以内
                    HaID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M"); //発注ID入力してない
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

                if (EmployeeDataAccess.CheckPrCDExistence(int.Parse(EmID.Text.Trim())))
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
            return true;
            //発注年月日　適否


            //入庫済フラグ

            //発注管理フラグ
            // if(HaFlag.CheckState.Indeterminate)
        }
    }
}


