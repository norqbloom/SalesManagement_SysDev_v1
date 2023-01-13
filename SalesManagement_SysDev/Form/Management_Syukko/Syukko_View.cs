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
        MessageDsp messageDsp = new MessageDsp();

        private static List<T_Syukko> listdata = null;
        private static List<T_Syukko> commitdata=null;
        private static List<T_Syukko> syukkos = null;

        SyukkoDataaccess syukkoDataaccess = new SyukkoDataaccess();
        public Syukko_View()
        {
            InitializeComponent();
        }

        private void Syukko_View_Load(object sender, EventArgs e)
        {
            syukkos = null;
            commitdata = null;
            listdata = null;
            syukkos = syukkoDataaccess.getSyukko();
            dataGridView1.DataSource = syukkos;
            dataGridView2.DataSource = commitdata;
        }
        private void Syu_Con_Button_Click(object sender, EventArgs e)
        {            
            foreach(var item in commitdata)
            {
                bool flg;
                flg=GenerateDataNyuuko(item);
               
                //入庫ID
                int number = syukkoDataaccess.PriID(item.OrID);
                //商品IDと数量
                var syukkodetail = syukkoDataaccess.pridget(item.SyID);
                foreach(var Quantity in syukkodetail)
                {
                    if (Quantity != null)
                    {
                        neredetail(number, Quantity.PrID, Quantity.SyQuantity);                     
                    }
                }
                flg=GenerateDataAtUpdate(item);
                if (flg == true)
                {
                    messageDsp.DspMsg("M9008");
                }
                else
                {
                    
                    messageDsp.DspMsg("M9009");

                }

            }
            syukkos = syukkoDataaccess.getSyukko();
            dataGridView1.DataSource = syukkos;
            commitdata = null;
            dataGridView2.DataSource = commitdata;

        }

        private bool neredetail(int upitem,int PrID,int SyQuantity)
        {
            bool flg;   
            T_ArrivalDetail selectCondition = new T_ArrivalDetail()
            {
                ArID=upitem,
                PrID=PrID,
                ArQuantity=SyQuantity

            };
            flg=syukkoDataaccess.nyuukodetail(selectCondition);
            return flg;
        }
        private bool GenerateDataNyuuko(T_Syukko upitem)
        {
            bool flg;
            T_Arrival selectCondition = new T_Arrival()
            {
                SoID = upitem.SoID,
                ClID = upitem.ClID,
                OrID = upitem.OrID,
                ArFlag = upitem.SyFlag,
                ArHidden = upitem.SyHidden
            };
            flg=syukkoDataaccess.genenyuuko(selectCondition);
            return flg;
        }


        private bool GenerateDataAtUpdate(T_Syukko upitem)
        {
            bool flg;
            T_Syukko selectCondition = new T_Syukko()
            {
                SyID = upitem.SyID
            };
            flg=syukkoDataaccess.upflg(selectCondition);
            return flg;
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
            syukkos = (List<T_Syukko>)dataGridView1.DataSource;
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

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            commitdata = null;
            dataGridView2.DataSource = commitdata;
            syukkos = syukkoDataaccess.getSyukko();
            dataGridView1.DataSource = syukkos;
        }
    }
}
