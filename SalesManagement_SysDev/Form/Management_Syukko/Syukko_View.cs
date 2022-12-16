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
        private static List<T_Syukko> listdata = null;
        private static List<T_Syukko> commitdata=null;


        SyukkoDataaccess syukkoDataaccess = new SyukkoDataaccess();
        public Syukko_View()
        {
            InitializeComponent();
        }

        private void Syukko_View_Load(object sender, EventArgs e)
        {
            List<T_Syukko> syukkos = null;
            commitdata = null;
            listdata = null;
            syukkos = syukkoDataaccess.getSyukko();
            dataGridView1.DataSource = syukkos;
            dataGridView2.DataSource = commitdata;
        }
        private void Syu_Con_Button_Click(object sender, EventArgs e)
        {
            //int number;
            foreach(var item in commitdata)
            {                
                
            }
            //var update = GenerateDataAtUpdate();
        }
        
        private void GenerateDataAtUpdate()
        {

            T_Syukko selectCondition = new T_Syukko();
            {
               
            };
            syukkoDataaccess.upflg(selectCondition);
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
            int number;
            number = (int)dataGridView1.CurrentRow.Cells[0].Value;
            List<T_Syukko> syukkos = (List<T_Syukko>)dataGridView1.DataSource;
            dataGridView1.DataSource = null;
            syukkos.Remove(syukkos.Single(x => x.SyID == number));
            dataGridView1.DataSource = syukkos;
            setcommitdata(number);
        }
        private void setcommitdata(int number)
        {
            T_Syukko selectCondition = new T_Syukko()
            {
                SyID=number
            };
            if (commitdata == null)
            {
                commitdata= syukkoDataaccess.getsyID(selectCondition);
                listdata = syukkoDataaccess.getsyID(selectCondition);
                commitdata.AddRange(listdata);
                dataGridView2.DataSource = null;
                commitdata.RemoveAt(0);
                dataGridView2.DataSource = commitdata;
            }
            else
            {
                listdata = syukkoDataaccess.getsyID(selectCondition);
                commitdata.AddRange(listdata);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = commitdata;
            }
        }
    }
}
