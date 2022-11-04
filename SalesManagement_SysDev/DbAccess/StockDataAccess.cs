using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.DbAccess
{
    class StockDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckStIDExistence()
        //引　数   ：在庫ID
        //戻り値   ：True or False
        //機　能   ：一致する在庫IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckStIDExistence(string StockID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //商品IDで一致するデータが存在するか
                flg = context.T_Stocks.Any(x => x.StID.ToString() == StockID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddStockData()
        //引　数   ：在庫データ
        //戻り値   ：True or False
        //機　能   ：在庫データの登録
        //          ：登録成功の場合True
        //          ：登録失敗の場合False
        ///////////////////////////////
        public bool AddStockData(T_Stock regStock)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Stocks.Add(regStock);
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
        //メソッド名：UpdateStockData()
        //引　数   ：在庫データ
        //戻り値   ：True or False
        //機　能   ：在庫データの更新
        //          ：更新成功の場合True
        //          ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateStockData(T_Stock updStock)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Stock = context.T_Stocks.Single(x => x.PrID == updStock.PrID);

                Stock.StID = updStock.StID;
                Stock.PrID = updStock.PrID;
                Stock.StQuantity = updStock.StQuantity;
                Stock.StFlag = updStock.StFlag;
                
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
        //メソッド名：DeleteStockData()
        //引　数   ：在庫データ
        //戻り値   ：True or False
        //機　能   ：在庫データの削除
        //          ：削除成功の場合True
        //          ：削除失敗の場合False
        ///////////////////////////////
        public bool DeleteStockData(string delStockID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Stock = context.T_Stocks.Single(x => x.StID.ToString() == delStockID);
                context.T_Stocks.Remove(Stock);
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
        //メソッド名：GetClientsData()　オーバーロード
        //引　数   ：検索条件
        //戻り値   ：条件一致顧客データ
        //機　能   ：条件一致商品顧客データの取得
        ///////////////////////////////

        public List<T_Stock> GetStockdata(T_Stock selectCondition)
        {
            List<T_Stock> client = new List<T_Stock>();

            try
            {
                var context = new SalesManagement_DevContext();
                var Stock = context.T_Stocks.Where(x => x.StID.ToString().Contains(selectCondition.StID.ToString()) &&
                                                 x.PrID.ToString().Contains(selectCondition.PrID.ToString()) &&
                                                 x.StQuantity.ToString().Contains(selectCondition.StQuantity.ToString())).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return client;
        }
    }
}
