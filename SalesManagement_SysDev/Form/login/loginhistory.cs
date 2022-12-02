using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class loginhistory : Form
    {
        private static List<loginHistory> histories;
        loginhistoryDataAccess loginhistoryDataAccess = new loginhistoryDataAccess();
        public loginhistory()
        {
            InitializeComponent();
        }

        private void serchlogin_Click(object sender, EventArgs e)
        {
            GenerateDataAtSelect();

            SetSelectData();

        }
        private void GenerateDataAtSelect()
        {
            if (!String.IsNullOrEmpty(EmpIDtxt.Text))
            {
                if (checkBox1.Checked == true)
                {
                    //全部
                    Allserchdate();
                }
                else
                {
                    //iDのみ
                    Emidserchdate();
                }
            }else if(checkBox1.Checked == true)
            {
                //日付のみ

            }
        }
        private void Allserchdate()
        {
            loginHistory selectCondition = new loginHistory()
            {
                EmID=EmpIDtxt.Text,
                loginTime=dateTimePicker1.Value
            };
            histories = loginhistoryDataAccess.loginHistories(selectCondition, dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridViewhistory.DataSource = histories;
        }
        private void Emidserchdate()
        {
            loginHistory selectCondition = new loginHistory()
            {
                EmID = EmpIDtxt.Text,
                loginTime = dateTimePicker1.Value
            };
            histories = loginhistoryDataAccess.loginEmIDhistory(selectCondition);
            dataGridViewhistory.DataSource = histories;
        }

        private void SetSelectData()
        {
            
        }

        private void loginhistory_Load(object sender, EventArgs e)
        {

        }
    }
}
