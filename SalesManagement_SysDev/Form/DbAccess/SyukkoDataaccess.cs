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
                syukkos = context.T_Syukkos.Where(x => x.SyFlag == 0&&
                                                       x.SyID==number.SyID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return syukkos;
        }
        public void  upflg(T_Syukko number)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var syukko = context.T_Syukkos.Single(x => x.SyID == number.SyID);
                syukko.SyStateFlag = 1;
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
