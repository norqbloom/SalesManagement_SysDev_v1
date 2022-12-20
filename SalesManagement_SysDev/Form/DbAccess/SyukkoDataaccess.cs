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
                var Arrivals = context.T_Arrivals.Where(x => x.OrID == selectCondition);
                var y = Arrivals.FirstOrDefault();
                number = y.ArID;
                context.Dispose();

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

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //出庫IDから商品IDと数量
        public List<T_SyukkoDetail> pridget(int number)
        {
            List<T_SyukkoDetail> syukkoDetails = new List<T_SyukkoDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                syukkoDetails = context.T_SyukkoDetails.Where(x => x.SyID == number).ToList();


                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return syukkoDetails;
        }
        //入庫ID
        public int PriID(int number)
        {
            int renumber = -1 ;
            try
            {
                var context = new SalesManagement_DevContext();
                var y = context.T_Arrivals.Where(x => x.OrID == number);
                var xx = y.FirstOrDefault();
                renumber = xx.OrID;
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return renumber;
        }
        //入庫詳細登録

        public void nyuukodetail(T_ArrivalDetail selectCondition)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_ArrivalDetails.Add(selectCondition);
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
