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
        public List<T_OrderDetail> GetOrderDetailDataDsp(int ID)
        {
            List<T_OrderDetail> orderDetails = new List<T_OrderDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                orderDetails = context.T_OrderDetails.Where(x => x.OrID == ID).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return orderDetails;
        }

        public List<T_OrderDetail> GetOrderDetailDataOrID(int ID)
        {
            List<T_OrderDetail> orderDetails = new List<T_OrderDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                orderDetails = context.T_OrderDetails.Where(x => x.OrID == ID).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return orderDetails;
        }

    }
}
