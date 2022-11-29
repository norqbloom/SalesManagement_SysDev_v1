
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
                    product.Add(new M_Product()
                    {
                        PrID = p.PrID,
                        MaID = p.MaID,
                        PrName = p.PrName,
                        Price = p.Price,
                        PrSafetyStock = p.PrSafetyStock,
                        ScID = p.ScID,
                        PrModelNumber = p.PrModelNumber,
                        PrColor = p.PrColor,
                        PrReleaseDate = p.PrReleaseDate,
                        PrFlag = p.PrFlag,
                        PrHidden = p.PrHidden
                    });
                }
                context.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        ///////////////////////////////
        //メソッド名：GetProductData()
        //引　数   ：なし
        //戻り値   ：全商品データ
        //機　能   ：全商品データの取得
        ///////////////////////////////
        public List<M_ProductDsp> GetProductData2()
        {
            List<M_ProductDsp> product = new List<M_ProductDsp>();

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
                foreach (var p in tb)
                {
                    product.Add(new M_ProductDsp()
                    {
                        PrID = p.PrID,
                        MaID = p.MaID,
                        PrName = p.PrName,
                        Price = p.Price,
                        PrSafetyStock = p.PrSafetyStock,
                        ScID = p.ScID,
                        PrModelNumber = p.PrModelNumber,
                        PrColor = p.PrColor,
                        PrReleaseDate = p.PrReleaseDate,
                        PrFlag = p.PrFlag,
                        PrHidden = p.PrHidden
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }

        ///////////////////////////////
        //メソッド名：GetItemData()　オーバーロード
        //引　数   ：検索条件
        //戻り値   ：条件一致商品データ
        //機　能   ：条件一致商品データの取得
        ///////////////////////////////
        public List<M_Product> GetProductData(M_Product selectCondition)
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
                         where t1.PrName.Contains(selectCondition.PrName) &&
                               t1.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                               t1.PrColor.Contains(selectCondition.PrColor) &&
                               t1.PrHidden.Contains(selectCondition.PrHidden)

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
                    product.Add(new M_Product()
                    {
                        PrID = p.PrID,
                        MaID = p.MaID,
                        PrName = p.PrName,
                        Price = p.Price,
                        PrSafetyStock = p.PrSafetyStock,
                        ScID = p.ScID,
                        PrModelNumber = p.PrModelNumber,
                        PrColor = p.PrColor,
                        PrReleaseDate = p.PrReleaseDate,
                        PrFlag = p.PrFlag,
                        PrHidden = p.PrHidden
                    });  
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
       

        ///////////////////////////////
        //メソッド名：GetClientsDspData()
        //引　数   ：なし
        //戻り値   ：表示用顧客データ
        //機　能   ：表示用顧客データの取得
        ///////////////////////////////
        public List<M_Product> GetProductDspData()
        {
            List<M_Product> Product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                Product = context.M_Products.Where(x => x.PrFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Product;
        }

        ///////////////////////////////
        //メソッド名：GetClientsData()　オーバーロード
        //引　数   ：検索条件
        //戻り値   ：条件一致顧客データ
        //機　能   ：条件一致商品顧客データの取得
        ///////////////////////////////

        public List<M_Product> Getdubblwdata(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();

            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                 x.PrFlag == 0 &&
                                                 x.PrID.ToString().Contains(selectCondition.PrID.ToString()) &&
                                                 x.MaID.ToString().Contains(selectCondition.MaID.ToString()) &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.ScID.ToString().Contains(selectCondition.ScID.ToString()) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrColor.Contains(selectCondition.PrColor) &&
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Product> GetPrdata(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();


            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                 x.PrFlag == 0 &&
                                                 x.PrID.ToString().Contains(selectCondition.PrID.ToString()) &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrColor.Contains(selectCondition.PrColor) &&
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Product> GetMadata(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();


            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                 x.PrFlag == 0 &&
                                                 x.MaID.ToString().Contains(selectCondition.MaID.ToString()) &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrColor.Contains(selectCondition.PrColor) &&
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Product> GetScdata(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();


            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                 x.PrFlag == 0 &&
                                                 x.ScID.ToString().Contains(selectCondition.ScID.ToString()) &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrColor.Contains(selectCondition.PrColor) &&
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Product> Getnodata(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();

            //string dt = selectCondition.PrReleaseDate.ToString("yyyy/MM//dd");
            //MessageBox.Show(selectCondition.PrReleaseDate.ToString());
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                 x.PrFlag == 0 &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrColor.Contains(selectCondition.PrColor) &&
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Product> GetPrMadata(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();


            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                x.PrID.ToString().Contains(selectCondition.PrID.ToString()) &&
                                                x.MaID.ToString().Contains(selectCondition.MaID.ToString()) &&
                                                 x.PrFlag == 0 &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrColor.Contains(selectCondition.PrColor) &&
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Product> GetPrScdata(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();


            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                x.PrID.ToString().Contains(selectCondition.PrID.ToString()) &&
                                                x.ScID.ToString().Contains(selectCondition.ScID.ToString()) &&
                                                 x.PrFlag == 0 &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrColor.Contains(selectCondition.PrColor) &&
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Product> GetMaScdata(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();


            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                x.MaID.ToString().Contains(selectCondition.MaID.ToString()) &&
                                                x.ScID.ToString().Contains(selectCondition.ScID.ToString()) &&
                                                 x.PrFlag == 0 &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrColor.Contains(selectCondition.PrColor) &&
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())
                                                 ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Prohistory> getdetail(M_Prohistory selectCondition)
        {
            List<M_Prohistory> history = new List<M_Prohistory>();
            try
            {
                var context = new SalesManagement_DevContext();
                history = context.M_Prohistory.Where(x => x.PrID == selectCondition.PrID).ToList();
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


