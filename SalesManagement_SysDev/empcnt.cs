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
    public partial class empcnt : Form
    {
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        PasswordHash passwordHash = new PasswordHash();
        
        public empcnt()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //データ確認
            if (!GetEmpDataReg())
                return;

            //社員情報作成
            var regEmp = GenerateDataAtRegistration();

            //社員情報登録
            RegistrationStaff(regEmp);
        }

        private bool GetEmpDataReg()
        {
            //EmIDの確認
            if (!String.IsNullOrEmpty(EmIDtxt.Text.Trim()))
            {
                //Emid半角英数字チェック
                if (!dataInputFormCheck.CheckNumeric(EmIDtxt.Text.Trim()))
                {
                    MessageBox.Show("IDは半角数字のみ");
                    EmIDtxt.Focus();
                    return false;
                }
                //Emid文字数チェック
                if(EmIDtxt.TextLength > 6)
                {
                    MessageBox.Show("IDは文字数は6文字");
                    EmIDtxt.Focus();
                    return false;
                }

                int  EmpID = int.Parse(EmIDtxt.Text.Trim());
                if (employeeDataAccess.CheckEmployeesCDExistence(EmpID))
                {
                    MessageBox.Show("重複");
                    EmIDtxt.Focus();
                    return false;
                }

            }
            else
            {
                MessageBox.Show("IDが入力されていません");
                EmIDtxt.Focus();
                return false;
            }

            //社員名の確認
            if (!String.IsNullOrEmpty(EmNametxt.Text.Trim()))
            {
                //名前文字数
                if (EmNametxt.TextLength > 50)
                {
                    MessageBox.Show("50文字以下");
                    EmNametxt.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("名前入力しろよ。");
                EmNametxt.Focus();
                return false;
            }
            //SoID確認
            if (!String.IsNullOrEmpty(SoIDtxt.Text.Trim()))
            {
                //SOid型確認
                if (!dataInputFormCheck.CheckNumeric(SoIDtxt.Text.Trim()))
                {
                    MessageBox.Show("半角数字やしw");
                    SoIDtxt.Focus();
                    return false;
                }
                //soid文字数チェック
                if (SoIDtxt.TextLength > 2)
                {
                    MessageBox.Show("SoIDは文字数は2文字");
                    SoIDtxt.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("SoID入力せい");
                SoIDtxt.Focus();
                return false;
            }

            //PoID確認
            if (!String.IsNullOrEmpty(PoIDtxt.Text.Trim()))
            {
                //PoID型確認
                if (!dataInputFormCheck.CheckNumeric(PoIDtxt.Text.Trim()))
                {
                    MessageBox.Show("半角数字やしw");
                    PoIDtxt.Focus();
                    return false;
                }
                //PoID文字数チェック
                if (PoIDtxt.TextLength > 2)
                {
                    MessageBox.Show("PoIDは文字数は2文字");
                    PoIDtxt.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("PoID入力せい");
                PoIDtxt.Focus();
                return false;
            }

            //パスワードの確認
            if (!String.IsNullOrEmpty(EmPassWord.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(EmPassWord.Text.Trim()))
                {
                    MessageBox.Show("半角英数字やしw");
                    EmPassWord.Focus();
                    return false;
                }
                //soid文字数チェック
                if (EmPassWord.TextLength > 10)
                {
                    MessageBox.Show("パスワードは文字数は10文字");
                    EmPassWord.Focus();
                    return false;
                }

            }
            else
            {
                MessageBox.Show("パスワード入力せい");
                EmPassWord.Focus();
                return false;
            }

            //電話番号確認
            if (!String.IsNullOrEmpty(Emphonetxt.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(Emphonetxt.Text.Trim()))
                {
                    MessageBox.Show("半角英数字やしw");
                    Emphone.Focus();
                    return false;
                }
                //soid文字数チェック
                if (Emphonetxt.TextLength > 10)
                {
                    MessageBox.Show("パスワードは文字数は10文字");
                    Emphonetxt.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号入力せい");
                Emphonetxt.Focus();
                return false;
            }

            if (EmCheck.CheckState == CheckState.Indeterminate)
            {

                MessageBox.Show("不確定な状況");
                EmCheck.Focus();
                return false;
            }
            

            return true;
        }
        private M_Employee GenerateDataAtRegistration()
        {
            int checkflg;
            if (EmCheck.Checked == true)
            {
                checkflg = 0;
            }
            else
            {
                checkflg = 1;
            }


            string pw = passwordHash.CreatePasswordHash(EmPassWord.Text.Trim());
            return new M_Employee
            {

                EmID=int.Parse(EmIDtxt.Text.Trim()),
                EmName=EmNametxt.Text.Trim(),
                SoID=int.Parse(SoIDtxt.Text.Trim()),
                PoID=int.Parse(PoIDtxt.Text.Trim()),
                EmHiredate=dateTimeHidden.Value,
                EmPassword=pw,
                EmPhone=Emphonetxt.Text.Trim(),
                EmFlag=checkflg,
                EmHidden=hiddentxt.Text.Trim()
               

            };
        }

        
        private void RegistrationStaff(M_Employee regEmp)
        {
            DialogResult result = MessageBox.Show("確認",MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            //登録
            bool flg = employeeDataAccess.AddEmpData(regEmp);
            if (flg == true)
                MessageBox.Show("ok");
            else
                MessageBox.Show("no");
            
           
        }

        private void EmIDtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
