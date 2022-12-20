using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class OrderDateAccess
    {
        ///////////////////////////////
        //メソッド名：CheckOrIDExistence()
        //引　数   ：受注ID
        //戻り値   ：True or False
        //機　能   ：一致する受注IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckOrIDExistence(String OrderID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.T_Orders.Any(x => x.OrID.ToString() == OrderID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddOrederData()
        //引　数   ：受注データ
        //戻り値   ：True or False
        //機　能   ：受注データの登録
        //          ：登録成功の場合True
        //          ：登録失敗の場合False
        ///////////////////////////////
        public bool AddorderData(T_Order regOrder)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Orders.Add(regOrder);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        ///////////////////////////////
        //メソッド名：UpdateOrdersData()
        //引　数   ：受注データ
        //戻り値   ：True or False
        //機　能   ：受注データの更新
        //          ：更新成功の場合True
        //          ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateOrdersData(T_Order updOrders)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Order = context.T_Orders.Single(x => x.OrID == updOrders.OrID);

                Order.OrID = updOrders.OrID;
                Order.SoID = updOrders.SoID;
                Order.EmID = updOrders.EmID;
                Order.ClID = updOrders.ClID;
                Order.ClCharge = updOrders.ClCharge;
                Order.OrDate = updOrders.OrDate;
                Order.OrStateFlag = updOrders.OrStateFlag;
                Order.OrFlag = updOrders.OrFlag;
                Order.OrHidden = updOrders.OrHidden;

                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "外部エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        ///////////////////////////////
        //メソッド名：DeleteOrderData()
        //引　数   ：受注データ
        //戻り値   ：True or False
        //機　能   ：受注データの削除
        //          ：削除成功の場合True
        //          ：削除失敗の場合False
        ///////////////////////////////
        public bool DeleteOrderData(T_Order selectionCondition)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var orders = context.T_Orders.Single(x => x.OrID == selectionCondition.OrID);
                orders.OrFlag = 2;

                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool AddClientData(T_Order regClient)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Orders.Add(regClient);
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;

        }

        public List<T_Order> GetOrderDataDsp(int radioint)
        {
            List<T_Order> orders = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                orders = context.T_Orders.Where(x => x.OrFlag == radioint).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return orders;
        }
        public List<T_Order> GetPrMaget(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.OrID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge) 
                                                 //x.EmHiredate.Contains(selectCondition.EmHiredate) &&
                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getfull(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.OrID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getorsoem(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.OrID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getorso(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.OrID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getor(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.OrID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> GetNo(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getorsocl(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.OrID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getorem(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.OrID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getorcl(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.OrID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getoremcl(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.OrID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getsoemcl(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getsocl(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getemcl(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getcl(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.ClID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getem(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getso(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<T_Order> Getemso(T_Order selectCondition)
        {
            List<T_Order> order = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                                                 x.OrFlag == 0 &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.OrDate.Contains(selectCondition.OrDate) &&
                                                 x.ClCharge.Contains(selectCondition.ClCharge)

                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }

    }


}
    

