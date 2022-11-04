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
using System.Threading;


namespace SalesManagement_SysDev
{
    public partial class login : Form
    {
        bool flg;
        MessageDsp messageDsp = new MessageDsp();

        PasswordHash passwordHash = new PasswordHash();

        public login()
        {
            InitializeComponent();
        }


        private void button_login_Click(object sender, EventArgs e) 
           
        {
            button_login.Visible = false;
            lodinggif.Visible = true;
            logina.Visible = true;
            logina.Text = "ようこそ";

            this.backgroundWorker1.RunWorkerAsync();

        }

        private void logincheck()
        {

        }

        private void textBox_id_Enter(object sender, EventArgs e)
        {
            if (textBox_id.Text == "担当者ID")
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
            textBox_pass.PasswordChar = '*';

            logina.Visible = false;
            lodinggif.Visible = false;
            button_login.Visible = true;

        }

        private void textBox_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            //ログイン処理
            string logID = textBox_id.Text;
            string logPass = textBox_pass.Text;

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
                flg = empcontext.SelectEmployeeExistenceCheck(textBox_id.Text.Trim(), pw);
                int loginID = int.Parse(logID);
                if (flg == true)
                {
                    var tb = from t1 in context.M_Employees
                             join t2 in context.M_Positions
                             on t1.PoID equals t2.PoID
                             /*join t3 in context.M_Authoritys
                             on t1.AuthorityCD equals t3.AuthorityCD*/
                             where t1.EmID == loginID && t1.EmPassword == pw
                             select new
                             {
                                 t1.EmName,
                                 t2.PoName,
                                 t2.PoID
                             };
                    foreach (var p in tb)
                    {
                        template.loginName = p.EmName;
                        template.loginPosition = p.PoName;
                        DateTime dt = DateTime.Now;
                        template.loginTime = dt.ToString("MM/dd HH;mm");
                        
                        template.PosID = p.PoID;
                    }
                    template.loginID = loginID;

                    context.Dispose();

                }
                else
                {
                    //MessageBox.Show("動いてないわ");

                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (flg == true)
            {
                Form form = new template();
                form.Show(this);
                Opacity = 0;
                logina.Visible = false;
                lodinggif.Visible = false;
                button_login.Visible = true;
            }

            if (flg == false)
            {
                logina.Visible = true;
                logina.Text = "担当者IDまたはパスワードが違います";
                lodinggif.Visible = false;
                button_login.Visible = true;
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new empcnt();
            form.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new F_Login();
            form.Show(this);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox_pass.PasswordChar = '\0';
            }
            else
            {
                textBox_pass.PasswordChar = '*';
            }
        }
    }
}


