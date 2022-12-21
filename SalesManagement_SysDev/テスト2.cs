using System;
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
    public partial class テスト2 : Form
    {
        public テスト2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string> { "OrID", "PrID", "OrQuantity", "OrTotalPrice" };
            list.Add(textBoxOrID.Text.Trim());
            list.Add(textBoxPrID.Text.Trim());
            list.Add(textBoxOrQuantity.Text.Trim());
            list.Add(textBoxOrTotalPrice.Text.Trim());

            dataGridView1.DataSource = list;
        }
    }
}
