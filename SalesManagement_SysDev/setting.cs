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
    public partial class setting : Form
    {

        public setting()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //緑
                //51, 153, 102
                //MediumSeaGreen
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                //青
                //CornflowerBlue
      
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                //黒
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                //オレンジ
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                //赤
            }

        }
    }
}
