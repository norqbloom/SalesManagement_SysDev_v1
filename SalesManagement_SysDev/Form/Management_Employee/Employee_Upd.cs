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

        private void buttonUpd_Click(object sender, EventArgs e)
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
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                //Emid半角英数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    MessageBox.Show("IDは半角数字のみ");
                    textBoxEmID.Focus();
                    return false;
                }
                //Emid文字数チェック
                if (textBoxEmID.TextLength > 6)
                {
                    MessageBox.Show("IDは文字数は6文字");
                    textBoxEmID.Focus();
                    return false;
                }
                if (!employeeDataAccess.CheckEmployeesCDExistence(int.Parse(textBoxEmID.Text.Trim())))
                {
                    messageDsp.DspMsg("M1003");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("IDが入力されていません");
                textBoxEmID.Focus();
                return false;
            }

            //社員名の確認
            if (!String.IsNullOrEmpty(textBoxEmName.Text.Trim()))
            {
                //名前文字数
                if (textBoxEmName.TextLength > 50)
                {
                    MessageBox.Show("50文字以下");
                    textBoxEmName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("名前入力しろよ。");
                textBoxEmName.Focus();
                return false;
            }
            //SoID確認
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                //SOid型確認
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    MessageBox.Show("半角数字やしw");
                    textBoxSoID.Focus();
                    return false;
                }
                //soid文字数チェック
                if (textBoxSoID.TextLength > 2)
                {
                    MessageBox.Show("SoIDは文字数は2文字");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("SoID入力せい");
                textBoxSoID.Focus();
                return false;
            }

            //PoID確認
            if (!String.IsNullOrEmpty(textBoxPoID.Text.Trim()))
            {
                //PoID型確認
                if (!dataInputFormCheck.CheckNumeric(textBoxPoID.Text.Trim()))
                {
                    MessageBox.Show("半角数字やしw");
                    textBoxPoID.Focus();
                    return false;
                }
                //PoID文字数チェック
                if (textBoxPoID.TextLength > 2)
                {
                    MessageBox.Show("PoIDは文字数は2文字");
                    textBoxPoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("PoID入力せい");
                textBoxPoID.Focus();
                return false;
            }

            //パスワードの確認
            if (!String.IsNullOrEmpty(textBoxEmPassword.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(textBoxEmPassword.Text.Trim()))
                {
                    MessageBox.Show("半角英数字やしw");
                    textBoxEmPassword.Focus();
                    return false;
                }
                //soid文字数チェック
                if (textBoxEmPassword.TextLength > 10)
                {
                    MessageBox.Show("パスワードは文字数は10文字");
                    textBoxEmPassword.Focus();
                    return false;
                }

            }
            else
            {
                MessageBox.Show("パスワード入力せい");
                textBoxEmPassword.Focus();
                return false;
            }

            //電話番号確認
            if (!String.IsNullOrEmpty(textBoxEmPhone.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(textBoxEmPhone.Text.Trim()))
                {
                    MessageBox.Show("半角英数字やしw");
                    textBoxEmPhone.Focus();
                    return false;
                }
                //soid文字数チェック
                if (textBoxEmPhone.TextLength > 10)
                {
                    MessageBox.Show("パスワードは文字数は10文字");
                    textBoxEmPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号入力せい");
                textBoxEmPhone.Focus();
                return false;
            }

            if (checkBoxEmFlag.CheckState == CheckState.Indeterminate)
            {

                MessageBox.Show("不確定な状況");
                checkBoxEmFlag.Focus();
                return false;
            }


            return true;
        }
        private M_Employee GenerateDataAtUpdate()
        {
            int checkflg;
            if (checkBoxEmFlag.Checked == true)
            {
                checkflg = 1;
            }
            else
            {
                checkflg = 0;
            }


            string pw = passwordHash.CreatePasswordHash(textBoxEmPassword.Text.Trim());
            return new M_Employee
            {

                EmID = int.Parse(textBoxEmID.Text.Trim()),
                EmName = textBoxEmName.Text.Trim(),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                PoID = int.Parse(textBoxPoID.Text.Trim()),
                EmHiredate = dateTimePickerEmHiredate.Value,
                EmPassword = pw,
                EmPhone = textBoxEmPhone.Text.Trim(),
                EmFlag = checkflg,
                EmHidden = textBoxEmHidden.Text.Trim()


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
