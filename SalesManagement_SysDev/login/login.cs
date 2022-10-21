using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace SalesManagement_SysDev
{
    public partial class login : Form
    {
        PasswordHash passwordHash = new PasswordHash();
        public login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //ログイン処理
            string logID = textBox_id.Text;
            string logPass = textBox_pass.Text;
            bool flg;
            if (logID.Trim() == "" || logID == null || logPass.Trim() == "" || logPass == null)
            {
                //メッセージ表示
                return;
            }
            try
            {
                var pw = passwordHash.CreatePasswordHash(textBox_pass.Text.Trim());
                //社員ID・パスワードチェック 
                var context = new SalesManagement_DevContext();
                var empcontext = new EmployeeDataAccess();
                //ハッシュ化するとtextboxをpsに変換
                flg = empcontext.SelectEmployeeExistenceCheck(textBox_id.Text.Trim(), textBox_pass.Text.ToString().Trim());
                if (flg == true)
                {
                    MessageBox.Show("一致");
                    context.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("動いてないわ");
                    return;
                }
            }
            catch
            {

            }
        }

        private void textBox_id_Enter(object sender, EventArgs e)
        {
            if(textBox_id.Text == "担当者ID")
            {
                textBox_id.Text = "";
                textBox_id.ForeColor = Color.Black;
            }
        }

        private void textBox_pass_Enter(object sender, EventArgs e)
        {
            if (textBox_id.Text == "パスワード")
            {
                textBox_id.Text = "";
                textBox_id.ForeColor = Color.Black;
            }
        }

        private void textBox_pass_Leave(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                textBox_id.Text = "パスワード";
                textBox_id.ForeColor = Color.Silver;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
