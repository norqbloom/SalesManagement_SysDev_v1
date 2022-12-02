using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class loginhistoryDataAccess
    {
        //datagridview表示
        public List<loginHistory> loginHistories(loginHistory selectCondition,DateTime starttime,DateTime stoptime)
        {
            List<loginHistory> histories = new List<loginHistory>();
            DateTime startdt = starttime.Date;
            DateTime dt = stoptime.Date;
            DateTime stopdt = dt.AddDays(1);
            try
            {
                var context = new SalesManagement_DevContext();
                histories = context.loginHistories.Where(x => x.EmID == selectCondition.EmID &&
                                                            x.loginTime > startdt&&x.loginTime<stopdt).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return histories;

        }
        public List<loginHistory> loginEmIDhistory(loginHistory selectCondition)
        {
            List<loginHistory> histories = new List<loginHistory>();

            try
            {
                var context = new SalesManagement_DevContext();
                histories = context.loginHistories.Where(x => x.EmID == selectCondition.EmID).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return histories;
        }
        public List<loginHistory> logindatehistory( DateTime starttime, DateTime stoptime)
        {
            List<loginHistory> histories = new List<loginHistory>();
            DateTime startdt = starttime.Date;
            DateTime dt = stoptime.Date;
            DateTime stopdt = dt.AddDays(1);
            try
            {
                var context = new SalesManagement_DevContext();
                histories = context.loginHistories.Where(x => x.loginTime > startdt && x.loginTime < stopdt).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return histories;
        }
        public List<loginHistory> nodatehistory()
        {
            List<loginHistory> histories = new List<loginHistory>();
            try
            {
                var context = new SalesManagement_DevContext();
                histories = context.loginHistories.ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return histories;
        }
    }
}
