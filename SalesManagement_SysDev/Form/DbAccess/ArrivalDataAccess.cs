using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class ArrivalDataAccess
    {
        public List<T_Arrival> getArrival()
        {
            List<T_Arrival> arrivals = new List<T_Arrival>();

            try
            {
                var context = new SalesManagement_DevContext();
                arrivals = context.T_Arrivals.Where(x => x.ArFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrivals;
        }
    }
}
