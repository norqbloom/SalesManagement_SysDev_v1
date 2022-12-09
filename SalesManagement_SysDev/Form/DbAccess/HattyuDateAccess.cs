using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class HattyuDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckDivisionCDExistence()
        //引　数   ：発注コード
        //戻り値   ：True or False
        //機　能   ：一致する発注コードの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////

        public bool CheckHattyuCDExistence(int HaID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.T_Hattyus.Any(x => x.HaID == HaID);
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddHHattyuData()
        //引　数   ：発注データ
        //戻り値   ：True or False
        //機　能   ：発注データの登録
        //          ：登録成功の場合True
        //          ：登録失敗の場合False
        ///////////////////////////////

        public bool AddHattyuData(T_Hattyu regHattyu)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Hattyus.Add(regHattyu);
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;

        }

        ///////////////////////////////
        //メソッド名：UpdHattyuData()
        //引　数   ：発注データ
        //戻り値   ：True or False
        //機　能   ：発注データの更新
        //          ：更新成功の場合True
        //          ：更新失敗の場合False
        ///////////////////////////////
        ///
        public bool UpdHattyuData(T_Hattyu updHattyu)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Hattyus = context.T_Hattyus.Single(x => x.HaID == updHattyu.HaID);
                Hattyus.HaID = updHattyu.HaID;
                Hattyus.MaID = updHattyu.MaID;
                Hattyus.HaDate = updHattyu.HaDate;
                Hattyus.WaWarehouseFlag = updHattyu.WaWarehouseFlag;
                Hattyus.HaFlag = updHattyu.HaFlag;
                Hattyus.HaHidden = updHattyu.HaHidden;

                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public bool UpdclhistoryData(M_clhistory updclhistory)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var clhistorys = context.M_Clhistory.Single(x => x.ClID.ToString() == updclhistory.ClID);
                clhistorys.UpDateTime = updclhistory.UpDateTime;
                clhistorys.LastupdatedUserID = updclhistory.LastupdatedUserID;
                clhistorys.LastupdatedUserName = updclhistory.LastupdatedUserName;

                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        //SeaHattyuData
        ///////////////////////////////
        //メソッド名：DeleteHattyusData()
        //引　数   ：顧客データ
        //戻り値   ：True or False
        //機　能   ：顧客データの削除
        //          ：削除成功の場合True
        //          ：削除失敗の場合False
        ///////////////////////////////

        public bool DeleteHattyuData(int delHattyuID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var hattyus = context.T_Hattyus.Single(x => x.HaID == delHattyuID);
                context.T_Hattyus.Remove(hattyus);
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        ///////////////////////////////
        //メソッド名：GetHattyusData()
        //引　数   ：なし
        //戻り値   ：顧客データ
        //機　能   ：顧客データの取得
        ///////////////////////////////

        public List<T_Hattyu> GetHattyuData()
        {
            List<T_Hattyu> Hattyu = new List<T_Hattyu>();
            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.T_Hattyus
                         join t2 in context.M_Makers
                         on t1.MaID equals t2.MaID


                         select new
                         {
                             t1.HaID,
                             t2.MaID,
                             t1.HaDate,
                             t1.HaFlag,
                             t1.EmID,
                             t1.WaWarehouseFlag,
                             t1.HaHidden
                         };
                foreach (var h in tb)
                {
                    Hattyu.Add(new T_Hattyu()
                    {
                        HaID = h.HaID,
                        MaID = h.MaID,
                        HaDate = h.HaDate,
                        HaFlag = h.HaFlag,
                        EmID = h.EmID,
                        WaWarehouseFlag = h.WaWarehouseFlag,
                        HaHidden = h.HaHidden

                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Hattyu;
        }


        ///////////////////////////////
        //メソッド名：GetHattyuDspData()
        //引　数   ：なし
        //戻り値   ：表示用発注データ
        //機　能   ：表示用発注データの取得
        ///////////////////////////////
        public List<T_Hattyu> GetHattyuDspData()
        {
            List<T_Hattyu> Hattyu = new List<T_Hattyu>();
            try
            {
                var context = new SalesManagement_DevContext();
                Hattyu = context.T_Hattyus.Where(x => x.HaFlag == 0).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Hattyu;
        }

        ///////////////////////////////
        //メソッド名：GetHattyusData()　オーバーロード
        //引　数   ：検索条件
        //戻り値   ：条件一致発注データ
        //機　能   ：条件一致商品発注データの取得
        ///////////////////////////////

        public List<T_Hattyu> Getdubblwdata(T_Hattyu selectCondition)
        {
            List<T_Hattyu> hattyus = new List<T_Hattyu>();
            /*
                ClAddress = addresstxt.Text.Trim(),
                ClFAX = ClPostaltxt.Text.Trim(),
                ClPostal = ClFaxtxt.Text.Trim()
             */
            try
            {
                var context = new SalesManagement_DevContext();
                hattyus = context.T_Hattyus.Where(x => x.HaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.MaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.HaDate.ToString().Contains(selectCondition.HaDate.ToString())).ToList();

                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyus;
        }
        public List<T_Hattyu> GetHadata(T_Hattyu selectCondition)
        {
            List<T_Hattyu> hattyus = new List<T_Hattyu>();


            try
            {
                var context = new SalesManagement_DevContext();
                hattyus = context.T_Hattyus.Where(x => x.HaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.MaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.HaDate.ToString().Contains(selectCondition.HaDate.ToString())).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyus;

        }

            public List<T_Hattyu> GetEmdata(T_Hattyu selectCondition)
        {
            List<T_Hattyu> hattyus = new List<T_Hattyu>();


            try
            {
                var context = new SalesManagement_DevContext();
                hattyus = context.T_Hattyus.Where(x => x.HaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.MaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.HaDate.ToString().Contains(selectCondition.HaDate.ToString())).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyus;
        }
        public List<T_Hattyu> GetMadata(T_Hattyu selectCondition)
        {
            List<T_Hattyu> hattyus = new List<T_Hattyu>();


            try
            {
                var context = new SalesManagement_DevContext();
                hattyus = context.T_Hattyus.Where(x => x.HaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.MaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.HaDate.ToString().Contains(selectCondition.HaDate.ToString())).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyus;
        }
        public List<T_Hattyu> Getnodata(T_Hattyu selectCondition)
        {
            List<T_Hattyu> hattyus = new List<T_Hattyu>();


            try
            {
                var context = new SalesManagement_DevContext();
                hattyus = context.T_Hattyus.Where(x => x.HaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.MaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.HaDate.ToString().Contains(selectCondition.HaDate.ToString())).ToList();

                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyus;
        }
        //public List<M_clhistory> getdetail(M_clhistory selectCondition)
        //{
        //    List<M_clhistory> history = new List<M_clhistory>();
        //    try
        //    {
        //        var context = new SalesManagement_DevContext();
        //        history = context.M_Clhistory.Where(x => x.ClID == selectCondition.ClID).ToList();
        //        context.SaveChanges();
        //        context.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return history;
        //}


        ///////////////////////////////
        //メソッド名：GetHattyusIDData()　オーバーロード
        //引　数   ：検索条件
        //戻り値   ：条件一致顧客データ
        //機　能   ：条件一致商品顧客データの取得
        ///////////////////////////////
        public List<T_Hattyu> GetHattyusIDData(T_Hattyu selectCondition)
        {
            List<T_Hattyu> hattyus = new List<T_Hattyu>();

            try
            {
                var context = new SalesManagement_DevContext();
                hattyus = context.T_Hattyus.Where(x => x.HaID == selectCondition.HaID).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyus;
        }
        public List<T_Hattyu> GetHattyustextData(T_Hattyu selectCondition)
        {
            List<T_Hattyu> hattyus = new List<T_Hattyu>();

            try
            {
                var context = new SalesManagement_DevContext();
                hattyus = context.T_Hattyus.Where(x => x.HaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.MaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.HaDate.ToString().Contains(selectCondition.HaDate.ToString())).ToList();
                context.SaveChanges();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyus;
        }
        public List<T_Hattyu> Getnolwget(T_Hattyu selectCondition)
        {
            List<T_Hattyu> hattyus = new List<T_Hattyu>();

            try
            {
                var context = new SalesManagement_DevContext();
                hattyus = context.T_Hattyus.Where(x => x.HaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.MaID.ToString().Contains(selectCondition.HaID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.HaDate.ToString().Contains(selectCondition.HaDate.ToString())).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyus;
        }
    }
}
