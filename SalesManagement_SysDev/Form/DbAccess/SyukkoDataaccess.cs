using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class SyukkoDataaccess
    {

        public List<T_Syukko> getSyukko()
        {
            List<T_Syukko> syukkos = new List<T_Syukko>();
            try
            {
                var context = new SalesManagement_DevContext();
                syukkos = context.T_Syukkos.Where(x => x.SyStateFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return syukkos;
        }
        public List<T_Syukko> getsyID(T_Syukko number)
        {
            List<T_Syukko> syukkos = new List<T_Syukko>();
            try
            {
                var context = new SalesManagement_DevContext();
                syukkos = context.T_Syukkos.Where(x => x.SyFlag == 0 &&
                                                       x.SyID == number.SyID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return syukkos;
        }
        public void upflg(T_Syukko number)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var syukko = context.T_Syukkos.Single(x => x.SyID == number.SyID);
                DateTime dt = DateTime.Now;
                syukko.SyDate = dt;
                syukko.SyStateFlag = 1;
                syukko.EmID = template.EmID;
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void genenyuuko(T_Arrival selectCondition)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Arrivals.Add(selectCondition);
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int nyuukodatil(int selectCondition)
        {
            int number = -1;
            try
            {
                var context = new SalesManagement_DevContext();
                var Arrivals = context.T_Arrivals.Where(x => x.ArID == selectCondition);
                var y = Arrivals.FirstOrDefault();
                number = y.ArID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return number;

        }
        public void regnyuukodatail(int number)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var detail = context.T_ArrivalDetails.Where(x => x.ArID == number);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void 
    }
}
