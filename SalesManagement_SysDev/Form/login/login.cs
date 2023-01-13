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
        MessageDsp messageDsp = new MessageDsp();
        internal static bool flg;

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



        private void login_Load(object sender, EventArgs e)
        {
            textBox_pass.PasswordChar = '*';
            Opacity = 100 ;
            logina.Visible = false;
            lodinggif.Visible = false;
            button_login.Visible = true;

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
                             join t3 in context.M_SalesOffices
                             on t1.SoID equals t3.SoID
                             where t1.EmID == loginID && t1.EmPassword == pw
                             select new
                             {
                                 t1.EmID,
                                 t1.EmName,
                                 t2.PoName,
                                 t2.PoID,
                                 t3.SoName
                             };
                    foreach (var p in tb)
                    {
                        template.loginName = p.EmName;
                        template.loginPosition = p.PoName;
                        template.EmID = p.EmID;
                        template.PosID = p.PoID;
                        template.soname = p.SoName;
                    }
                    template.loginID = loginID;

                    DateTime dt = DateTime.Now;
                    template.loginTime = dt.ToString();

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

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (flg == true)
            {
                this.Hide();
                logina.Visible = false;
                lodinggif.Visible = false;
                button_login.Visible = true;
                history();
                setting.form.Show(this);
                flg = false;
            }
            else
            {
                logina.Visible = true;
                logina.Text = "担当者IDまたはパスワードが違います";
                lodinggif.Visible = false;
                button_login.Visible = true;
                return;
            }
        }

        private void history()
        {
            var reghistory = GenerateDataAtRegistration();
            Registrationhistory(reghistory);
        }
        private loginHistory GenerateDataAtRegistration()
        {
            return new loginHistory
            {
               
                EmID = template.EmID.ToString(),
                EmName = template.loginName,
                position = template.loginPosition,
                loginTime = DateTime.Parse(template.loginTime) ,
                logoutTime= DateTime.Parse(template.loginTime)
            };
        }

        private void Registrationhistory(loginHistory login)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.loginHistories.Add(login);
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        private void button4_Click(object sender, EventArgs e)
        {
            template.loginName = "テスト";
            template.loginPosition = "管理者";
            template.EmID = 116;
            template.PosID = 1;
            template.soname = "北大阪営業所";
            template.loginID = 116;
            DateTime dt = DateTime.Now;
            template.loginTime = dt.ToString("MM/dd HH;mm");
            setting.form.Show(this);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form form = new Order();
            form.Show(this);
        }
    }
}


