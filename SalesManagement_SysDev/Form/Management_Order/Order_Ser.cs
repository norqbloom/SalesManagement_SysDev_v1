using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Order
{
    public partial class Order_Ser : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        OrderDateAccess orderDateAccess = new OrderDateAccess();

        public Order_Ser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
