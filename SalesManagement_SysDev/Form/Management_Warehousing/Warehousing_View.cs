using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Warehousing
{
    public partial class Warehousing_View : Form
    {
        ArrivalDataAccess arrivalDataAccess = new ArrivalDataAccess(); 
        public Warehousing_View()
        {
            InitializeComponent();
        }

        private void Syu_Con_Button_Click(object sender, EventArgs e)
        {

        }

        private void Warehousing_View_Load(object sender, EventArgs e)
        {
            //datagridview 表示
            List<T_Arrival> arrivals = new List<T_Arrival>();
            arrivals = arrivalDataAccess.getArrival();
            dataGridView1.DataSource = arrivals;
        }
    }
}
