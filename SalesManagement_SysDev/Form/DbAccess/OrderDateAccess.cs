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
        public bool CheckOrIDExistence(int OrderID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.T_Orders.Any(x => x.OrID == OrderID);
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
        public bool AddorderData(T_Order regOreder)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Orders.Add(regOreder);
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
       /* public bool DeleteOrderData(string delOrderID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Order = context.T_Orders.Single(x => x.OrID.ToString() == delOrderID);
                context.T_Orders.Remove(Order);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }*/
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
        public List<M_ProductDsp> GetProductData2(int radioint)
        {
            List<T_Order> orders = new List<T_Order>();

            try
            {

                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Orders
                         join t2 in context.M_SalesOffices
                         on t1.SoID equals t2.SoID
                         join t3 in context.M_Employees
                         on t1.EmID equals t3.EmID
                         join t4 in context.M_Clients
                         on t1.ClID equals t4.ClID
                         where t1.OrStateFlag == StateFlg
                         where t1.OrFlag == Flg
                         select new
                         {
                             t1.OrID,
                             t2.SoID,
                             t3.EmID,
                             t4.ClID,
                             t1.ClCharge,
                             t1.OrDate,
                             t1.OrStateFlag,
                             t1.OrFlag,
                             t1.OrHidden
                         };

                foreach (var p in tb)
                {
                    orders.Add(new T_Order()
                    {
                        OrID = p.OrID,
                        SoID = p.SoID,
                        EmID = p.EmID,
                        ClID = p.ClID,
                        ClCharge = p.ClCharge,
                        OrDate = p.OrDate,
                        OrStateFlag = p.OrStateFlag,
                        OrFlag = p.OrFlag,
                        OrHidden = p.OrHidden
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return orders;
        }
    }
}
    

