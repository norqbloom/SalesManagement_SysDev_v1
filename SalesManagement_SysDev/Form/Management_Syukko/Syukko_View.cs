using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Syukko
{
    public partial class Syukko_View : Form
    {
        SyukkoDataaccess syukkoDataaccess = new SyukkoDataaccess();
        public Syukko_View()
        {
            InitializeComponent();
        }

        private void Syukko_View_Load(object sender, EventArgs e)
        {
            List<T_Syukko> syukkos = new List<T_Syukko>();
            syukkos = syukkoDataaccess.getSyukko();
            dataGridView1.DataSource = syukkos;
        }

        private void Syu_Con_Button_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string s1 = $"ダブルクリックされた位置 {e.RowIndex}列目 {e.ColumnIndex}行目";
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == -1)
            {
                return;
            }
            MessageBox.Show(e.RowIndex.ToString(),e.ColumnIndex.ToString());


        }
    }
}
