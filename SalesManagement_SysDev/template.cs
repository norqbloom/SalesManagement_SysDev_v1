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
        public template()
        {
            InitializeComponent();
        }

        private void template_Load(object sender, EventArgs e)
        {
            customizeDesing();
            
        }

        private void formresize()
        {
            int size = 609 / 15;
            tilepanel.Height = size;
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
            formresize();
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
            openChildForm(new login());
        }



        private void client_upbtn_Click(object sender, EventArgs e)
        {

        }

        private void client_serchbtn_Click(object sender, EventArgs e)
        {

        }

        private void sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tilepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empadd_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new empcnt());
        }
    }
}
