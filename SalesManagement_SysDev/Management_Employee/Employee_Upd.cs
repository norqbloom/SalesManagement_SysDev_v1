using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Employee
{
    public partial class Employee_Upd : Form
    {
        MessageDsp messageDsp = new MessageDsp();

        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        PasswordHash passwordHash = new PasswordHash();
        public Employee_Upd()
        {
            InitializeComponent();
        }

        private void Emp_Upd_Button_Click(object sender, EventArgs e)
        {
            // 5.3.2.1 妥当な商品データ取得
            if (!GetValidDataAtUpdate())
            {
                return;
            }

            // 5.3.2.2 スタッフ情報作成
            var updemp = GenerateDataAtUpdate();

            // 5.3.2.3 スタッフ情報更新
            UpdateItem(updemp);
        }
        private bool GetValidDataAtUpdate()
        {
            //EmIDの確認
            if (!String.IsNullOrEmpty(EmID.Text.Trim()))
            {
                //Emid半角英数字チェック
                if (!dataInputFormCheck.CheckNumeric(EmID.Text.Trim()))
                {
                    MessageBox.Show("IDは半角数字のみ");
                    EmID.Focus();
                    return false;
                }
                //Emid文字数チェック
                if (EmID.TextLength > 6)
                {
                    MessageBox.Show("IDは文字数は6文字");
                    EmID.Focus();
                    return false;
                }
                if (!employeeDataAccess.CheckEmployeesCDExistence(int.Parse(EmID.Text.Trim())))
                {
                    messageDsp.DspMsg("M1003");
                    EmID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("IDが入力されていません");
                EmID.Focus();
                return false;
            }

            //社員名の確認
            if (!String.IsNullOrEmpty(EmName.Text.Trim()))
            {
                //名前文字数
                if (EmName.TextLength > 50)
                {
                    MessageBox.Show("50文字以下");
                    EmName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("名前入力しろよ。");
                EmName.Focus();
                return false;
            }
            //SoID確認
            if (!String.IsNullOrEmpty(SoID.Text.Trim()))
            {
                //SOid型確認
                if (!dataInputFormCheck.CheckNumeric(SoID.Text.Trim()))
                {
                    MessageBox.Show("半角数字やしw");
                    SoID.Focus();
                    return false;
                }
                //soid文字数チェック
                if (SoID.TextLength > 2)
                {
                    MessageBox.Show("SoIDは文字数は2文字");
                    SoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("SoID入力せい");
                SoID.Focus();
                return false;
            }

            //PoID確認
            if (!String.IsNullOrEmpty(PoID.Text.Trim()))
            {
                //PoID型確認
                if (!dataInputFormCheck.CheckNumeric(PoID.Text.Trim()))
                {
                    MessageBox.Show("半角数字やしw");
                    PoID.Focus();
                    return false;
                }
                //PoID文字数チェック
                if (PoID.TextLength > 2)
                {
                    MessageBox.Show("PoIDは文字数は2文字");
                    PoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("PoID入力せい");
                PoID.Focus();
                return false;
            }

            //パスワードの確認
            if (!String.IsNullOrEmpty(EmPassword.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(EmPassword.Text.Trim()))
                {
                    MessageBox.Show("半角英数字やしw");
                    EmPassword.Focus();
                    return false;
                }
                //soid文字数チェック
                if (EmPassword.TextLength > 10)
                {
                    MessageBox.Show("パスワードは文字数は10文字");
                    EmPassword.Focus();
                    return false;
                }

            }
            else
            {
                MessageBox.Show("パスワード入力せい");
                EmPassword.Focus();
                return false;
            }

            //電話番号確認
            if (!String.IsNullOrEmpty(EmPhone.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(EmPhone.Text.Trim()))
                {
                    MessageBox.Show("半角英数字やしw");
                    EmPhone.Focus();
                    return false;
                }
                //soid文字数チェック
                if (EmPhone.TextLength > 10)
                {
                    MessageBox.Show("パスワードは文字数は10文字");
                    EmPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号入力せい");
                EmPhone.Focus();
                return false;
            }

            if (EmFlag.CheckState == CheckState.Indeterminate)
            {

                MessageBox.Show("不確定な状況");
                EmFlag.Focus();
                return false;
            }


            return true;
        }
        private M_Employee GenerateDataAtUpdate()
        {
            int checkflg;
            if (EmFlag.Checked == true)
            {
                checkflg = 1;
            }
            else
            {
                checkflg = 0;
            }


            string pw = passwordHash.CreatePasswordHash(EmPassword.Text.Trim());
            return new M_Employee
            {

                EmID = int.Parse(EmID.Text.Trim()),
                EmName = EmName.Text.Trim(),
                SoID = int.Parse(SoID.Text.Trim()),
                PoID = int.Parse(PoID.Text.Trim()),
                EmHiredate = EmHiredate.Value,
                EmPassword = pw,
                EmPhone = EmPhone.Text.Trim(),
                EmFlag = checkflg,
                EmHidden = EmHidden.Text.Trim()


            };
        }
        private void UpdateItem(M_Employee updemp)
        {
            DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            //登録
            bool flg = employeeDataAccess.UpdEmployeeData(updemp);
            if (flg == true)
                MessageBox.Show("ok");
            else
                MessageBox.Show("no");
        }
    }
}
