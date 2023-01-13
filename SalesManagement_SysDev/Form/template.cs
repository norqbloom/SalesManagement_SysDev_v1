using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SalesManagement_SysDev
{
    public partial class template : Form
    {
        internal static int loginID ;
        internal static int EmID;
        internal static int PosID;
        internal static string loginName = "";
        internal static string loginTime ;
        internal static string loginPosition = "";
        internal static string soname = "";
        internal static Color maincolor = Color.FromArgb(51, 153, 102);
        internal static Color subcolor= Color.MediumSeaGreen;
        internal static int Globalint = 0;


        public template()
        {
            InitializeComponent();
        }

        private void template_Load(object sender, EventArgs e)
        {
            colorchange();
            visiblecnt();
            PosVisible();
            customizeDesing();
            label1.Text = loginID.ToString();
            label2.Text = loginName;
            label4.Text = loginTime.ToString();
            label3.Text = loginPosition;
            label5.Text = soname;
            this.Text= Application.ProductName;
            timer1.Interval = 1000;
            timer1.Enabled = true;

        }
        private void visiblecnt()
        {
            colorcomboBox.Visible = false;
            colorlabel.Visible = false;
            comitbtn.Visible = false;
            client.Visible = false;
            product.Visible = false;
            stock.Visible = false;
            employee.Visible = false;
            sales.Visible = false;
            order.Visible = false;
            order_btn.Visible = false;
            hattyu.Visible = false;
            warehousing_btn.Visible = false;
            issue_btn.Visible = false;
            Arrival_btn.Visible = false;
            shipping_btn.Visible = false;
            logout.Visible = false;
            loginhistorybtn.Visible = false;
            RegPasswordbtn.Visible = false;
        }

        private void PosVisible()
        {
            if (PosID == 1)
            {
                client.Visible = true;
                product.Visible = true;
                stock.Visible = true;
                employee.Visible = true;
                sales.Visible = true;
                order.Visible = true;
                order_btn.Visible = true;
                hattyu.Visible = true;
                warehousing_btn.Visible = true;
                issue_btn.Visible = true;
                Arrival_btn.Visible = true;
                shipping_btn.Visible = true;
                logout.Visible = true;
                loginhistorybtn.Visible = true;
                RegPasswordbtn.Visible = true;
            }
            if (PosID == 2)
            {
                client.Visible = true;
                stock.Visible = true;
                //社員管理
                sales.Visible = true;
                order.Visible = true;
                shipping_btn.Visible = true;
                Arrival_btn.Visible = true;
            }
            if (PosID == 3)
            {
                product.Visible = true;
                stock.Visible = true;
                order_btn.Visible = true;
                hattyu.Visible = true;
                issue_btn.Visible = true;
                warehousing_btn.Visible = true;

            }
        }


        private void customizeDesing()
        {
            clientsubmenu.Visible = false;          
            Productsubmenu.Visible = false;
            stocksubmenu.Visible = false;
            empsubmenu.Visible = false;
            //売上
            panel7.Visible = false;
            receivedsubmenu.Visible = false;
            //注文
            panel9.Visible = false;
            instructsubmeun.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel1.Visible = false;
        }
       
        private void hidesubMenu()
        {
            if (clientsubmenu.Visible == true)
                clientsubmenu.Visible = false;
            if (Productsubmenu.Visible == true)
                Productsubmenu.Visible = false;
            if (stocksubmenu.Visible == true)
                stocksubmenu.Visible = false;
            if (empsubmenu.Visible == true)
                empsubmenu.Visible = false;
            if (panel7.Visible == true)
                panel7.Visible = false;
            if (receivedsubmenu.Visible == true)
                receivedsubmenu.Visible = false;
            if (panel9.Visible == true)
                panel9.Visible = false;
            if (instructsubmeun.Visible == true)
                instructsubmeun.Visible = false;
            if (panel11.Visible == true)
                panel11.Visible = false;
            if (panel12.Visible == true)
                panel12.Visible = false;
            if (panel13.Visible == true)
                panel13.Visible = false;
            if (panel14.Visible == true)
                panel14.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
        }


        private void showsubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidesubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private Form activeForm = null;
        private void openChildForm(Form chidform)
        {
            childsubmenu.Visible = true;
            colorcomboBox.Visible = false;
            colorlabel.Visible = false;
            comitbtn.Visible = false;
            if (activeForm != null)
                activeForm.Close();
            activeForm = chidform;
            chidform.TopLevel = false;
            chidform.FormBorderStyle = FormBorderStyle.None;
            chidform.Dock = DockStyle.Fill;
            childsubmenu.Controls.Add(chidform);
            childsubmenu.Tag = chidform;
            chidform.BringToFront();
            chidform.Show();
        }
        private void colorchange()
        {
            setting.BackColor = maincolor;
            close.BackColor = maincolor;
            sidepanel.BackColor = maincolor;
            tilepanel.BackColor = maincolor;
            client.BackColor = maincolor;
            product.BackColor = maincolor;
            stock.BackColor = maincolor;
            employee.BackColor = maincolor;
            sales.BackColor = maincolor;
            order.BackColor = maincolor;
            order_btn.BackColor = maincolor;
            hattyu.BackColor = maincolor;
            warehousing_btn.BackColor = maincolor;
            issue_btn.BackColor = maincolor;
            Arrival_btn.BackColor = maincolor;
            shipping_btn.BackColor = maincolor;
            logout.BackColor = maincolor;
            subtitlepanel.BackColor = subcolor;
            clientsubmenu.BackColor = subcolor;
            Productsubmenu.BackColor = subcolor;
            stocksubmenu.BackColor = subcolor;
            empsubmenu.BackColor = subcolor;
            panel7.BackColor = subcolor;

            receivedsubmenu.BackColor = subcolor;
            panel9.BackColor = subcolor;
            instructsubmeun.BackColor = subcolor;
            panel11.BackColor = subcolor;
            panel12.BackColor = subcolor;
            panel13.BackColor = subcolor;
            panel14.BackColor = subcolor;
        }
        //フォームドラッグ
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void tilepanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void template_Resize(object sender, EventArgs e)
        {
            Size size = childsubmenu.Size;
            int width = size.Width;
            int height = size.Height;
            //label1.Text = $"幅:{ width} 高さ:{height}";
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            showsubmenu(clientsubmenu);
        }
        private void Product_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(Productsubmenu);
        }

        private void stock_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(stocksubmenu);
        }
        private void emp_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(empsubmenu);
        }

        private void Earnings_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(panel7);
        }
        private void Order_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(receivedsubmenu);
        }
        private void order_btn_Click_1(object sender, EventArgs e)
        {
            showsubmenu(panel9);
        }
        private void instruct_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(instructsubmeun);
        }
        private void warehousing_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(panel11);
        }

        private void issue_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(panel12);
        }

        private void Arrival_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(panel13);
        }

        private void shipping_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(panel14);
        }
        private void client_regbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Client.Client_Add());
        }



        private void client_upbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Client.Client_Upd());
        }

        private void client_serchbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new client_serch());
        }

        private void sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Order());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Warehousing.Warehousing_View());
        }

        private void tilepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empadd_btn_Click(object sender, EventArgs e)
        {
            logoutuser();
        }

        private void emp_regbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Employee.Employee_Add());
        }

        private void childsubmenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            logoutuser();
            Application.Exit();
        }

        private void Product_regbtn_Click(object sender, EventArgs e)
        {
            //openChildForm(new Management_Product.Product_Add());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text= DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            timer.Visible = true;
        }
      

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.Red;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = maincolor;
        }
        private void logoutuser()
        {
            outtimereg();
            loginID =-1;
            EmID = -1;
            PosID =-1;
            loginName = null;
            loginTime = null;
            loginPosition = null;
            soname = null;
            Form form = new login();
            form.Show();
            this.Close();        
        }
        private void outtimereg()
        {
            DateTime dt = DateTime.Now;
            string logouttime = dt.ToString();
            //DateTime logintime = DateTime.Parse(template.loginTime);
            try
            {
                var context = new SalesManagement_DevContext();
                //var loginhistory = context.loginHistories.Single(x => x.loginTime == logintime);
                //loginhistory.logoutTime = DateTime.Parse(logouttime);
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "外部エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            childsubmenu.Visible = false;
            colorcomboBox.Visible = true;
            colorlabel.Visible = true;
            comitbtn.Visible = true;


        }

        private void setting_MouseEnter(object sender, EventArgs e)
        {
            setting.BackColor = Color.Red;
        }

        private void setting_MouseLeave(object sender, EventArgs e)
        {
            
            setting.BackColor = maincolor;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorcomboBox.SelectedIndex == 0)
            {
                //緑
                template.maincolor = Color.FromArgb(51, 153, 102);
                template.subcolor = Color.MediumSeaGreen;
            }
            else if (colorcomboBox.SelectedIndex == 1)
            {
                //青
                template.maincolor = Color.CornflowerBlue;
                template.subcolor = Color.DodgerBlue;

            }
            else if (colorcomboBox.SelectedIndex == 2)
            {
                //黒
                
            }
            else if (colorcomboBox.SelectedIndex == 3)
            {
                //オレンジ
            }
            else if (colorcomboBox.SelectedIndex == 4)
            {
                //赤
            }
            colorchange();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Product_upbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Product.Product_Upd());
            template.Globalint = 0;
        }

        private void Product_serchbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Product.Product_Ser());
        }

        private void stock_upbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Stock.Stock_Upd());
        }

        private void stock_serchbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Stock.Stock_Ser());
        }

        private void emp_upbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Employee.Employee_Upd());
        }

        private void emp_serchbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Employee.Employee_Ser());
        }

        private void Earnings_serchbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Sales.Sales_Ser());
        }

        private void received_upbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Order.Order_Ser());
        }

        private void order_serchbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Chumon.Chumon_Ser());
        }

        private void instruct_regbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Hattyu.Hattyu_Add());
        }

        private void instruct_upbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Hattyu.Hattyu_Upd());
        }

        private void instruct_serchbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Hattyu.Hattyu_Ser());
        }

        private void issue_display_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Syukko.Syukko_View());
        }

        private void Arrival_display_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Arrival.Arrival_View());
        }

        private void shipping_display_Click(object sender, EventArgs e)
        {
            //openChildForm(new Management_Shipment.Shipment_View());
        }

        private void RegPasswordbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new regPassword());
        }

        private void loginhistorybtn_Click(object sender, EventArgs e)
        {
            openChildForm(new loginhistory());
        }

        private void timer_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            showsubmenu(panel1);

        }
    }
}
