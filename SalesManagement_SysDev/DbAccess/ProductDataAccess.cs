
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    class ProductDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckPrIDExistence()
        //引　数   ：商品ID
        //戻り値   ：True or False
        //機　能   ：一致する商品コードの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckPrIDExistence(string ProductID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //商品IDで一致するデータが存在するか
                flg = context.M_Products.Any(x => x.PrID.ToString() == ProductID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddItemData()
        //引　数   ：商品データ
        //戻り値   ：True or False
        //機　能   ：商品データの登録
        //          ：登録成功の場合True
        //          ：登録失敗の場合False
        ///////////////////////////////
        public bool AddProductData(M_Product regProduct)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Products.Add(regProduct);
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
        //メソッド名：UpdateProductData()
        //引　数   ：商品データ
        //戻り値   ：True or False
        //機　能   ：商品データの更新
        //          ：更新成功の場合True
        //          ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateProductData(M_Product updProduct)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var product = context.M_Products.Single(x => x.PrID == updProduct.PrID);

                product.PrID = updProduct.PrID;
                product.MaID = updProduct.MaID;
                product.PrName = updProduct.PrName;
                product.Price = updProduct.Price;
                product.PrJCode = updProduct.PrJCode;
                product.PrSafetyStock = updProduct.PrSafetyStock;
                product.ScID = updProduct.ScID;
                product.PrModelNumber = updProduct.PrModelNumber;
                product.PrColor = updProduct.PrColor;
                product.PrReleaseDate = updProduct.PrReleaseDate;
                product.PrFlag = updProduct.PrFlag;
                product.PrHidden = updProduct.PrHidden;

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
        //メソッド名：DeleteProductData()
        //引　数   ：商品データ
        //戻り値   ：True or False
        //機　能   ：商品データの削除
        //          ：削除成功の場合True
        //          ：削除失敗の場合False
        ///////////////////////////////
        public bool DeleteProductData(string delProductID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Product = context.M_Products.Single(x => x.PrID.ToString() == delProductID);
                context.M_Products.Remove(Product);
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
        //メソッド名：GetProductData()
        //引　数   ：なし
        //戻り値   ：全商品データ
        //機　能   ：全商品データの取得
        ///////////////////////////////
        public List<M_Product> GetProductData()
        {
            List<M_Product> product = new List<M_Product>();

            try
            {
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.M_Products
                         join t2 in context.M_Makers
                         on t1.MaID equals t2.MaID
                         join t3 in context.M_SmallClassifications
                         on t1.ScID equals t3.ScID

                         select new
                         {
                             t1.PrID,
                             t2.MaID,
                             t1.PrName,
                             t1.Price,
                             t1.PrSafetyStock,
                             t3.ScID,
                             t1.PrModelNumber,
                             t1.PrColor,
                             t1.PrReleaseDate,
                             t1.PrFlag,
                             t1.PrHidden
                         };
                foreach(var p in tb)
                {
                    /*product.Add(new M_ProductDsp()
                    {

                    });*/
                }

            }
            catch
            {

            }
            
        }

    }
}


