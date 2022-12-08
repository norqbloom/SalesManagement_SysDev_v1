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
    public partial class Hattyu_Ser : Form
    {
        //EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        MessageDsp messageDsp = new MessageDsp();
        HattyuDataAccess HattyuDataAccess = new HattyuDataAccess();
       private static List<T_Hattyu> products;
       private static List<M_Prohistory> history;

        public Hattyu_Ser()
        {
            InitializeComponent();
        }

        private void Hattyu_Ser_Button_Click(object sender, EventArgs e)
        {
            //入力データ確認
            if (!GetHattyuDataAtSelect())
                return;

            //GenerateDataAtSelect();

            //SetSelectData();
        }
        private bool GetHattyuDataAtSelect()
        {
            //CoID確認
            if (!String.IsNullOrEmpty(HaID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(HaID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2028");
                    HaID.Focus();
                    return false;
                }


            }
            //メーカIDの適否
            if (!String.IsNullOrEmpty(MaID.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(MaID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2005");//メーカIDは半角数字入力です
                    MaID.Focus();
                    return false;
                }
                //文字数
                if (MaID.TextLength > 6)
                {
                    messageDsp.DspMsg("2006");
                    MaID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("2008");
                MaID.Focus();
                return false;
            }
            

            // EmIDの確認 社員
            if (!String.IsNullOrEmpty(EmID.Text.Trim()))

            {
                //Emid半角英数字チェック
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
                //int EmpID = int.Parse(EmID.Text.Trim());
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
        }
    }
}

