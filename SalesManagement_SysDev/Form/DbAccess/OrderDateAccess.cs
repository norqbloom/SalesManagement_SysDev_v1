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
        public bool AddorderdetailData(T_OrderDetail regOrderDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_OrderDetails.Add(regOrderDetail);
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
                                                 x.OrID.ToString().Contains(selectCondition.OrID.ToString()) &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
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
                                                 x.OrID.ToString().Contains(selectCondition.OrID.ToString()) &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
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
                                                 x.OrID.ToString().Contains(selectCondition.OrID.ToString()) &&
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
                                                 x.OrID.ToString().Contains(selectCondition.OrID.ToString()) &&
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
                                                 x.OrID.ToString().Contains(selectCondition.OrID.ToString()) &&
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
                                                 x.OrID.ToString().Contains(selectCondition.OrID.ToString()) &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
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
                                                 x.OrID.ToString().Contains(selectCondition.OrID.ToString()) &&
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
                                                 x.OrID.ToString().Contains(selectCondition.OrID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
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
                                                 x.OrID.ToString().Contains(selectCondition.OrID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
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
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
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
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
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
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
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
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
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
        public List<T_OrderDsp> GetProductData2(int radioint)
        {
            List<T_OrderDsp> order = new List<T_OrderDsp>();

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Orders
                         where t1.OrFlag == radioint
                         select new
                         {
                             t1.OrID,
                             t1.SoID,
                             t1.EmID,
                             t1.ClID,
                             t1.ClCharge,
                             t1.OrDate,
                             t1.OrStateFlag,
                             t1.OrFlag,
                             t1.OrHidden,
                         };

                foreach (var p in tb)
                {
                    order.Add(new T_OrderDsp()
                    {
                        OrID = p.OrID,
                        SoID = p.SoID,
                        EmID = p.EmID,
                        ClID = p.ClID,
                        ClCharge = p.ClCharge,
                        OrDate = p.OrDate,
                        OrStateFlag = p.OrStateFlag,
                        OrFlag = p.OrFlag,
                        OrHidden = p.OrHidden,
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        public List<OrHistory> getdetail(OrHistory selectCondition)
        {
            List<OrHistory> Orhistory = new List<OrHistory>();
            try
            {
                var context = new SalesManagement_DevContext();
                Orhistory = context.OrHistories.Where(x => x.OrID == selectCondition.OrID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Orhistory;
        }
        public List<T_Order> GetOrderDataDsp1()
        {
            List<T_Order> ord = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                ord = context.T_Orders.Where(x => x.OrFlag == 0).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ord;
        }
        public bool upflg(int number)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var order = context.T_Orders.Single(x => x.OrID == number);
                order.OrFlag = 1;
                context.SaveChanges();
                context.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

    }


}
    

