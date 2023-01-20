
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

        public bool delflg(int number)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var client = context.M_Products.Single(x => x.PrID == number);
                client.PrFlag = 2;
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

        public List<M_Product> GetProductIDData(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();

            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x => x.PrID == selectCondition.PrID).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
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
        public List<M_Product> GetProductDataDsp(int radioint)
        {
            List<M_Product> product = new List<M_Product>();

            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x => x.PrFlag == radioint).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
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
                                                 x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Product> GetdubblwHdata(M_Product selectCondition, DateTime starttime, DateTime stoptime)
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
                                                 x.PrReleaseDate > starttime && x.PrReleaseDate < stoptime &&
                                                 x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.SaveChanges();
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
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Product> GetPrHdata(M_Product selectCondition, DateTime starttime, DateTime stoptime)
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
                                                 x.PrReleaseDate > starttime && x.PrReleaseDate < stoptime &&
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())).ToList();
                context.SaveChanges();
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
                                                x.MaID.ToString().Contains(selectCondition.MaID.ToString()) &&
                                                x.PrName.Contains(selectCondition.PrName) &&
                                                x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                x.PrColor.Contains(selectCondition.PrColor) &&
                                                x.PrFlag == 0).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        //日付
        public List<M_Product> GetMaHdata(M_Product selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                x.MaID.ToString().Contains(selectCondition.MaID.ToString()) &&
                                                x.PrName.Contains(selectCondition.PrName) &&
                                                x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                x.PrColor.Contains(selectCondition.PrColor) &&
                                                x.PrReleaseDate > starttime && x.PrReleaseDate < stoptime &&
                                                x.PrFlag == 0).ToList();
                context.SaveChanges();
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
                                                 x.PrColor.Contains(selectCondition.PrColor)).ToList();

                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        //日付
        public List<M_Product> GetScHdata(M_Product selectCondition, DateTime starttime, DateTime stoptime)
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
                                                 x.PrReleaseDate > starttime && x.PrReleaseDate < stoptime &&
                                                 x.PrColor.Contains(selectCondition.PrColor)).ToList();

                context.SaveChanges();
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
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                 x.PrFlag == 0 &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        //日付
        public List<M_Product> GetnoHdata(M_Product selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                 x.PrFlag == 0 &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrReleaseDate > starttime && x.PrReleaseDate < stoptime &&
                                                 x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }


        public List<M_Product> Getnodata2(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                 x.PrFlag == 0 &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrColor.Contains(selectCondition.PrColor) &&
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        //日付
        public List<M_Product> GetnoHdata2(M_Product selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                 x.PrFlag == 0 &&
                                                 x.PrName.Contains(selectCondition.PrName) &&
                                                 x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                 x.PrColor.Contains(selectCondition.PrColor) &&
                                                 x.PrReleaseDate > starttime && x.PrReleaseDate < stoptime &&
                                                 x.PrReleaseDate.ToString().Contains(selectCondition.PrReleaseDate.ToString())).ToList();
                context.SaveChanges();
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
                                                x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        //日付
        public List<M_Product> GetPrMaHdata(M_Product selectCondition, DateTime starttime, DateTime stoptime)
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
                                                x.PrReleaseDate > starttime && x.PrReleaseDate < stoptime &&

                                                x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.SaveChanges();
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
                                                x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        //日付
        public List<M_Product> GetPrScHdata(M_Product selectCondition, DateTime starttime, DateTime stoptime)
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
                                                x.PrReleaseDate > starttime && x.PrReleaseDate < stoptime &&

                                                x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.SaveChanges();
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
                                                x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        //日付
        public List<M_Product> GetMaScHdata(M_Product selectCondition, DateTime starttime, DateTime stoptime)
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
                                                x.PrReleaseDate > starttime && x.PrReleaseDate < stoptime &&

                                                x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }


        public List<M_Product> PriceGet(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x => x.PrID == selectCondition.PrID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Product> PriceHGet(M_Product selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x => x.PrID == selectCondition.PrID &&
                                                   x.PrReleaseDate > starttime && x.PrReleaseDate < stoptime).ToList();
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
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return history;
        }
        public List<M_Prohistory> getHdetail(M_Prohistory selectCondition)
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


        public List<M_Product> GetPronlydata(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                x.PrID == selectCondition.PrID &&
                                                x.PrFlag == 0 &&
                                                x.PrName.Contains(selectCondition.PrName) &&
                                                x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
        public List<M_Product> GetPronlyHdata(M_Product selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                                                x.PrID == selectCondition.PrID &&
                                                x.PrFlag == 0 &&
                                                x.PrName.Contains(selectCondition.PrName) &&
                                                x.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                                                x.PrReleaseDate > starttime && x.PrReleaseDate < stoptime &&
                                                x.PrColor.Contains(selectCondition.PrColor)).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }

        public List<Prhistory> getdetail(Prhistory selectCondition)
        {
            List<Prhistory> history = new List<Prhistory>();
            try
            {
                var context = new SalesManagement_DevContext();
                history = context.Prhistories.Where(x => x.PrID == selectCondition.PrID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return history;
        }
        public List<Prhistory> getHdetail(Prhistory selectCondition)
        {
            List<Prhistory> history = new List<Prhistory>();
            try
            {
                var context = new SalesManagement_DevContext();
                history = context.Prhistories.Where(x => x.PrID == selectCondition.PrID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return history;
        }
        public List<M_Product> GetProductDataDsp1()
        {
            List<M_Product> Prd = new List<M_Product>();

            try
            {
                var context = new SalesManagement_DevContext();
                Prd = context.M_Products.Where(x => x.PrFlag == 0).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Prd;
        }
        public bool upflg(int number)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var product = context.M_Products.Single(x => x.PrID == number);
                product.PrFlag = 1;
                context.SaveChanges();
                context.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        public bool UpdProhistoryData(M_Prohistory uphistory)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var uphistorys = context.M_Prohistory.Single(x => x.PrID.ToString() == uphistory.PrID);
                uphistorys.UpDateTime = uphistory.UpDateTime;
                uphistorys.LastupdatedUserID = uphistory.LastupdatedUserID;
                uphistorys.LastupdatedUserName = uphistory.LastupdatedUserName;

                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        public List<M_Product> GetProductDspData()
        {
            List<M_Product> products = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                products = context.M_Products.Where(x => x.PrFlag == 0).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return products;
        }


    }
}

