﻿using System;
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
    public partial class Employee_Add : Form
    {
        
        MessageDsp messageDsp = new MessageDsp();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        PasswordHash passwordHash = new PasswordHash();

        public Employee_Add()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //データ確認
            if (!GetEmpDataReg())
                return;

            //社員情報作成
            var regEmp = GenerateDataAtRegistration();

            //社員情報登録
            RegistrationStaff(regEmp);
            var reghis = GeneratehistoryDataAtRegistration();
            RegistrationClhistory(reghis);
        }

        private bool GetEmpDataReg()
        {
            //EmIDの確認 社員
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                //Emid半角英数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    messageDsp.DspMsg("M6001");
                    textBoxEmID.Focus();
                    return false;
                }
                //Emid文字数チェック
                if (textBoxEmID.TextLength > 6)
                {
                    messageDsp.DspMsg("M6002");
                    textBoxEmID.Focus();
                    return false;
                }

                int EmpID = int.Parse(textBoxEmID.Text.Trim());
                if (employeeDataAccess.CheckEmployeesCDExistence(EmpID))
                {
                    messageDsp.DspMsg("M6003");
                    textBoxEmID.Focus();
                    return false;
                }

            }
            else
            {
                messageDsp.DspMsg("M6004");
                textBoxEmID.Focus();
                return false;
            }

            //社員名の確認
            if (!String.IsNullOrEmpty(textBoxEmName.Text.Trim()))
            {
                //名前文字数
                if (textBoxEmName.TextLength > 50)
                {
                    messageDsp.DspMsg("M6006");
                    textBoxEmName.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M6007");
                textBoxEmName.Focus();
                return false;
            }
            //SoID確認　営業所
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                //SOid型確認
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1005");
                    textBoxSoID.Focus();
                    return false;
                }
                //soid文字数チェック
                if (textBoxSoID.TextLength > 2)
                {
                    messageDsp.DspMsg("M1006");
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

            //PoID確認 役職ID
            if (!String.IsNullOrEmpty(textBoxPoID.Text.Trim()))
            {
                //PoID型確認
                if (!dataInputFormCheck.CheckNumeric(textBoxPoID.Text.Trim()))
                {
                    MessageBox.Show("半角数字やしw");　//messageDsp.DspMsg("M6021");
                    textBoxPoID.Focus();
                    return false;
                }
                //PoID文字数チェック
                if (textBoxPoID.TextLength > 2)
                {
                    MessageBox.Show("PoIDは文字数は2文字");　//messageDsp.DspMsg("M6022");
                    textBoxPoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("PoID入力せい");　//messageDsp.DspMsg("M6023");
                textBoxPoID.Focus();
                return false;
            }

            //パスワードの確認
            if (!String.IsNullOrEmpty(textBoxEmPassword.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(textBoxEmPassword.Text.Trim()))
                {
                    MessageBox.Show("半角英数字やしw"); //messageDsp.DspMsg("M6025");
                    textBoxEmPassword.Focus();
                    return false;
                }
                //パスワード文字数チェック
                if (textBoxEmPassword.TextLength > 10)
                {
                    MessageBox.Show("パスワードは文字数は10文字"); //messageDsp.DspMsg("M6026");
                    textBoxEmPassword.Focus();
                    return false;
                }

            }
            else
            {
                MessageBox.Show("パスワード入力せい"); //messageDsp.DspMsg("M6024");
                textBoxEmPassword.Focus();
                return false;
            }

            //電話番号確認
            if (!String.IsNullOrEmpty(textBoxEmPhone.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(textBoxEmPhone.Text.Trim()))
                {
                    messageDsp.DspMsg("M1015");
                    textBoxEmPhone.Focus();
                    return false;
                }
                //電話番号文字数チェック
                if (textBoxEmPhone.TextLength > 13)
                {
                    messageDsp.DspMsg("M1016");
                    textBoxEmPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号入力せい"); //messageDsp.DspMsg("M1035");
                textBoxEmPhone.Focus();
                return false;
            }

            if (checkBoxEmFlag.CheckState == CheckState.Indeterminate)
            {

                MessageBox.Show("不確定な状況"); //messageDsp.DspMsg("M6027");
                checkBoxEmFlag.Focus();
                return false;
            }


            return true;
        }
        private M_Employee GenerateDataAtRegistration()
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
                EmHiredate = dateTimePickerEmHiredate.Value.ToString(),
                EmPassword = pw,
                EmPhone = textBoxEmPhone.Text.Trim(),
                EmFlag = checkflg,
                EmHidden = textBoxEmHidden.Text.Trim()


            };
        }


        private void RegistrationStaff(M_Employee regEmp)
        {
            DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            //登録
            bool flg = employeeDataAccess.AddEmpData(regEmp);
            if (flg == true)
                MessageBox.Show("ok");　//messageDsp.DspMsg("M6012");
            else
                MessageBox.Show("no");　//messageDsp.DspMsg("M6013");


        }
        private Emphistory GeneratehistoryDataAtRegistration()
        {
            DateTime dt = DateTime.Now;
            string regtime = dt.ToString("MM/dd HH;mm");

            return new Emphistory
            {
                EmID = textBoxEmID.Text,
                SoID = textBoxSoID.Text,
                PoID = textBoxPoID.Text,
                RegisteredDate = regtime,
                regUserID = template.EmID.ToString(),
                regUserName = template.loginName,
                UpDateTime = "なし",
                LastupdatedUserID = "なし",
                LastupdatedUserName = "なし"

            };
        }
        private void RegistrationClhistory(Emphistory reghis)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.emphistories.Add(reghis);
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
