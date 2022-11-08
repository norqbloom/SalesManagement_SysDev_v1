using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Client
{
    public partial class Client_Add : Form
    {
        public Client_Add()
        {
            InitializeComponent();
        }

        private void Cli_Upd_Click(object sender, EventArgs e)
        {
            // 8.2.1.1 妥当な役職データ取得
            if (!GetclientDataAtRegistration())
                return;
        }
        private bool GetclientDataAtRegistration()
        {
            return false;
        }
    }
}
