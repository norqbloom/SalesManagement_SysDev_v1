using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class OrderDetailDataAccess
    {
        public List<T_OrderDetail> GetOrderDetailDataDsp(int radioint)
        {
            List<T_OrderDetail> ordersdetail = new List<T_OrderDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                ordersdetail = context.T_OrderDetails.ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ordersdetail;
        }
    }
}
