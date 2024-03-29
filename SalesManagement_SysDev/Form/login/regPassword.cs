﻿using System;
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
    public partial class regPassword : Form
    {
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        PasswordHash passwordHash = new PasswordHash();


        public regPassword()
        {
            InitializeComponent();
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            if (!GetValidDataAtUpdate())
                return;
            var uppass = uppasswors();
            Updatepass(uppass);
        }
        private bool GetValidDataAtUpdate()
        {
            //社員ID
            if (!String.IsNullOrEmpty(EmpIDtxt.Text.Trim()))
            {
                if (!employeeDataAccess.CheckEmployeesCDExistence(int.Parse(EmpIDtxt.Text)))
                {
                    MessageBox.Show("社員IDが見つかりませんでした");
                    EmpIDtxt.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("社員IDを入力してください");
                EmpIDtxt.Focus();
                return false;
            }
            //パスワード
            if (!String.IsNullOrEmpty(passtxt.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(passtxt.Text.Trim()))
                {
                    MessageBox.Show("パスワードは半角英数字");
                    passtxt.Focus();
                    return false;
                }
                //soid文字数チェック
                if (passtxt.TextLength > 10)
                {
                    MessageBox.Show("パスワードは文字数は10文字");
                    passtxt.Focus();
                    return false;
                }
                if (!String.IsNullOrEmpty(passcontxt.Text.Trim()))
                {
                    if (passtxt == passcontxt)
                    {
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("パスワード確認を入力してください");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("パスワードを入力してください");
                passtxt.Focus();
                return false;
            }


            return true;
        }
        private M_Employee uppasswors()
        {
            var context = new SalesManagement_DevContext();
            string pw = passwordHash.CreatePasswordHash(passtxt.Text.Trim());

            return new M_Employee
            {
                EmID=int.Parse(EmpIDtxt.Text.Trim()),
                EmPassword = pw
            };

        }
        private void Updatepass(M_Employee updpass)
        {
            DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            //登録
            bool flg = employeeDataAccess.UpPass(updpass);
            if (flg == true)
                MessageBox.Show("ok");
            else
                MessageBox.Show("no");
        }
    }
}
