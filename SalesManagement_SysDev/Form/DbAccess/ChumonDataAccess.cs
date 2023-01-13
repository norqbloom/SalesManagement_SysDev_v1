using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class ChumonDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckChumonIDExistence()
        //引　数   ：注文データ
        //戻り値   ：True or False
        //機　能   ：一致する注文コードの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckChumonCDExistence(int ChID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.T_Chumons.Any(x => x.ChID == ChID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddChumonsData()
        //引　数   ：注文データ
        //戻り値   ：True or False
        //機　能   ：注文データの削除
        //          ：追加成功の場合True
        //          ：追加失敗の場合False
        ///////////////////////////////
        public bool AddchumonData(T_Chumon regChumon)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Chumons.Add(regChumon);
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
        //メソッド名：DeleteChumonsData()
        //引　数   ：注文データ
        //戻り値   ：True or False
        //機　能   ：注文データの削除
        //          ：削除成功の場合True
        //          ：削除失敗の場合False
        ///////////////////////////////
        public bool DeleteChumonData(T_Chumon delChumonID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var chumons = context.T_Chumons.Single(x => x.ChID == delChumonID.ChID);
                chumons.ChFlag = 2;

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
        //メソッド名：ConfirmChumonsData()
        //引　数   ：注文データ
        //戻り値   ：True or False
        //機　能   ：注文データの確定
        //          ：確定成功の場合True
        //          ：確定失敗の場合False
        ///////////////////////////////
        public bool ConfirmChumonData(int conChumon)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var chumons = context.T_Chumons.Single(x => x.ChID == conChumon);
                chumons.ChStateFlag = 1;

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
        //メソッド名：BringChumonsData()
        //引　数   ：注文データ
        //戻り値   ：True or False
        //機　能   ：受注詳細から数量を持ってくる
        //          ：成功の場合True
        //          ：失敗の場合False
        ///////////////////////////////
        public List<T_OrderDetail> BringChumonData(int number)
        {
            List<T_OrderDetail> chumons = new List<T_OrderDetail>();;
            try
            {
                var context = new SalesManagement_DevContext();
                chumons = context.T_OrderDetails.Where(x => x.OrID == number).ToList();
                //var chumons = context.T_OrderDetail.Where(x => x.PrID == decstock.PrID);
                
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumons;
        }

        ///////////////////////////////
        //メソッド名：DecreaseChumonsData()
        //引　数   ：注文データ
        //戻り値   ：True or False
        //機　能   ：注文データの減少
        //          ：減少成功の場合True
        //          ：減少失敗の場合False
        ///////////////////////////////

        public bool DecreaseChumonData(T_OrderDetail decStock)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var chumons = context.T_Stocks.Single(x => x.PrID == decStock.PrID);
                chumons.StQuantity = chumons.StQuantity - decStock.OrQuantity;

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
        //メソッド名：AddSyukkoData()
        //引　数   ：出庫データ
        //戻り値   ：True or False
        //機　能   ：出庫データの追加
        //          ：追加成功の場合True
        //          ：追加失敗の場合False
        ///////////////////////////////
        public bool AddsyukkoData(T_Syukko regSyukko)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Syukkos.Add(regSyukko);
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
        //メソッド名：AddSyukkoDetailData()
        //引　数   ：出庫詳細データ
        //戻り値   ：True or False
        //機　能   ：出庫詳細データの追加
        //          ：追加成功の場合True
        //          ：追加失敗の場合False
        ///////////////////////////////
        public bool AddsyukkoDetailData(T_SyukkoDetail regSyukkoDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_SyukkoDetails.Add(regSyukkoDetail);
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
        //メソッド名：GetChumonsData()
        //引　数   ：なし
        //戻り値   ：注文データ
        //機　能   ：注文データの取得
        ///////////////////////////////
        public List<T_Chumon> GetChumonData()
        {
            List<T_Chumon> Chumon = new List<T_Chumon>();
            try
            {
                var context = new SalesManagement_DevContext();
                Chumon = context.T_Chumons.ToList();
                context.Dispose();

                return Chumon;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Chumon;
        }
        public T_Chumon GetChumonDataByChId(int chId)
        {
            List<T_Chumon> Chumon = new List<T_Chumon>();
            try
            {
                var context = new SalesManagement_DevContext();
                Chumon = context.T_Chumons.Where(x => x.OrID == chId).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Chumon[0];
        }

        ///////////////////////////////
        //メソッド名：GetChumonsDspData()
        //引　数   ：なし
        //戻り値   ：表示用注文データ
        //機　能   ：表示用注文データの取得
        ///////////////////////////////
        public List<T_Chumon> GetChumonDspData()
        {
            List<T_Chumon> Chumon = new List<T_Chumon>();
            try
            {
                var context = new SalesManagement_DevContext();
                Chumon = context.T_Chumons.Where(x => x.ChFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Chumon;
        }

        ///////////////////////////////
        //メソッド名：GetChumonData()　オーバーロード
        //引　数   ：検索条件
        //戻り値   ：条件一致注文データ
        //機　能   ：条件一致商品注文データの取得
        ///////////////////////////////
        public List<T_Chumon> Getdubblwdata(T_Chumon selectCondition)
        {
            List<T_Chumon> chumon = new List<T_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.T_Chumons.Where(x =>
                                                 x.ChID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.SoID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.OrID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 //x.ChDate.Contains(selectCondition.ChDate) &&
                                                 x.ChStateFlag == 0 &&
                                                 x.ChFlag == 0
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }

        public List<T_Chumon> GetChSodata(T_Chumon selectCondition)
        {
            List<T_Chumon> chumon = new List<T_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.T_Chumons.Where(x =>
                                                 x.ChID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.SoID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.OrID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 //x.ChDate.Contains(selectCondition.ChDate) &&
                                                 x.ChStateFlag == 0 &&
                                                 x.ChFlag == 0
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }
        public List<T_Chumon> GetChEmdata(T_Chumon selectCondition)
        {
            List<T_Chumon> chumon = new List<T_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                //chumon = context.M_Chumons.Where(x =>
                //                                 x.ChID.ToString().Contains(selectCondition.ClID.ToString()) &&
                //                                 x.EmID.ToString().Contains(selectCondition.ClID.ToString()) &&
                //                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
                //                                 x.OrID.ToString().Contains(selectCondition.ClID.ToString()) &&
                //                                 //x.ChDate.Contains(selectCondition.ChDate) &&
                //                                 x.ChStateFlag == 0 &&
                //                                 x.ChFlag == 0
                //                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }
        public List<T_Chumon> GetSoEmdata(T_Chumon selectCondition)
        {
            List<T_Chumon> chumon = new List<T_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.T_Chumons.Where(x =>
                                                 x.SoID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.EmID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.OrID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 //x.ChDate.Contains(selectCondition.ChDate) &&
                                                 x.ChStateFlag == 0 &&
                                                 x.ChFlag == 0
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }



        public List<T_Chumon> GetSodata(T_Chumon selectCondition)
        {
            List<T_Chumon> chumon = new List<T_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.T_Chumons.Where(x =>
                                                 x.SoID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.OrID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 //x.ChDate.Contains(selectCondition.ChDate) &&
                                                 x.ChStateFlag == 0 &&
                                                 x.ChFlag == 0
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }
        public List<T_Chumon> GetEmdata(T_Chumon selectCondition)
        {
            List<T_Chumon> chumon = new List<T_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.T_Chumons.Where(x =>
                                                 x.EmID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.OrID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 //x.ChDate.Contains(selectCondition.ChDate) &&
                                                 x.ChStateFlag == 0 &&
                                                 x.ChFlag == 0
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }
        public List<T_Chumon> Getnodata(T_Chumon selectCondition)
        {
            List<T_Chumon> chumon = new List<T_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.T_Chumons.Where(x =>
                                                 x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.OrID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 //x.ChDate.Contains(selectCondition.ChDate) &&
                                                 x.ChStateFlag == 0 &&
                                                 x.ChFlag == 0
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }
        public List<T_Chhistory> getdetail(T_Chhistory selectCondition)
        {
            List<T_Chhistory> history = new List<T_Chhistory>();
            try
            {
                var context = new SalesManagement_DevContext();
                history = context.T_Chhistory.Where(x => x.ChID == selectCondition.ChID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return history;
        }
    }
}
