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
        //SeaClientData
        ///////////////////////////////
        //メソッド名：DeleteClientsData()
        //引　数   ：顧客データ
        //戻り値   ：True or False
        //機　能   ：顧客データの削除
        //          ：削除成功の場合True
        //          ：削除失敗の場合False
        ///////////////////////////////

        public bool DeleteClientData(int delClientID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var clients = context.M_Clients.Single(x => x.ClID == delClientID);
                context.M_Clients.Remove(clients);
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
        //メソッド名：GetClientsData()
        //引　数   ：なし
        //戻り値   ：顧客データ
        //機　能   ：顧客データの取得
        ///////////////////////////////

        public List<M_Client> GetClientData()
        {
            List<M_Client> Client = new List<M_Client>();
            try
            {
                var context = new SalesManagement_DevContext();
                Client = context.M_Clients.ToList();
                context.SaveChanges();
                context.Dispose();

                return Client;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Client;
        }

        ///////////////////////////////
        //メソッド名：GetClientsData()　オーバーロード
        //引　数   ：検索条件
        //戻り値   ：条件一致顧客データ
        //機　能   ：条件一致商品顧客データの取得
        ///////////////////////////////
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>


        ///////////////////////////////
        //メソッド名：GetClientsDspData()
        //引　数   ：なし
        //戻り値   ：表示用顧客データ
        //機　能   ：表示用顧客データの取得
        ///////////////////////////////
        public List<M_Client> GetClientDspData()
        {
            List<M_Client> Client = new List<M_Client>();
            try
            {
                var context = new SalesManagement_DevContext();
                Client = context.M_Clients.Where(x => x.ClFlag == 0).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Client;
        }

        ///////////////////////////////
        //メソッド名：GetClientsData()　オーバーロード
        //引　数   ：検索条件
        //戻り値   ：条件一致顧客データ
        //機　能   ：条件一致商品顧客データの取得
        ///////////////////////////////

        public List<M_Client> Getdubblwdata(M_Client selectCondition)
        {
            List<M_Client> client = new List<M_Client>();
            /*
                ClAddress = addresstxt.Text.Trim(),
                ClFAX = ClPostaltxt.Text.Trim(),
                ClPostal = ClFaxtxt.Text.Trim()
             */
            try
            {
                var context = new SalesManagement_DevContext();
                client = context.M_Clients.Where(x => x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.ClName.Contains(selectCondition.ClName) &&
                                                 x.ClFlag == 0 &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.ClPhone.Contains(selectCondition.ClPhone) &&
                                                 x.ClAddress.Contains(selectCondition.ClAddress) &&
                                                 x.ClFAX.Contains(selectCondition.ClFAX) &&
                                                 x.ClPostal.Contains(selectCondition.ClPostal)).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return client;
        }
        public List<M_Client> GetCldata(M_Client selectCondition)
        {
            List<M_Client> client = new List<M_Client>();


            try
            {
                var context = new SalesManagement_DevContext();
                client = context.M_Clients.Where(x => x.ClID.ToString().Contains(selectCondition.ClID.ToString()) &&
                                                 x.ClName.Contains(selectCondition.ClName) &&
                                                 x.ClFlag == 0 &&
                                                 x.ClPhone.Contains(selectCondition.ClPhone) &&
                                                 x.ClAddress.Contains(selectCondition.ClAddress) &&
                                                 x.ClFAX.Contains(selectCondition.ClFAX) &&
                                                 x.ClPostal.Contains(selectCondition.ClPostal)).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return client;
        }
        public List<M_Client> GetSodata(M_Client selectCondition)
        {
            List<M_Client> client = new List<M_Client>();


            try
            {
                var context = new SalesManagement_DevContext();
                client = context.M_Clients.Where(x => x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.ClName.Contains(selectCondition.ClName) &&
                                                 x.ClFlag == 0 &&
                                                 x.ClPhone.Contains(selectCondition.ClPhone) &&
                                                 x.ClAddress.Contains(selectCondition.ClAddress) &&
                                                 x.ClFAX.Contains(selectCondition.ClFAX) &&
                                                 x.ClPostal.Contains(selectCondition.ClPostal)).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return client;
        }
        public List<M_Client> Getnodata(M_Client selectCondition)
        {
            List<M_Client> client = new List<M_Client>();


            try
            {
                var context = new SalesManagement_DevContext();
                client = context.M_Clients.Where(x =>
                                                 x.ClName.Contains(selectCondition.ClName) &&
                                                 x.ClFlag == 0 &&
                                                 x.ClPhone.Contains(selectCondition.ClPhone) &&
                                                 x.ClAddress.Contains(selectCondition.ClAddress) &&
                                                 x.ClFAX.Contains(selectCondition.ClFAX) &&
                                                 x.ClPostal.Contains(selectCondition.ClPostal)).ToList();
                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return client;
        }
        public List<M_clhistory> getdetail(M_clhistory selectCondition)
        {
            List<M_clhistory> history = new List<M_clhistory>();
            try
            {
                var context = new SalesManagement_DevContext();
                history = context.M_Clhistory.Where(x => x.ClID == selectCondition.ClID).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return history;
        }


        ///////////////////////////////
        //メソッド名：GetClientsIDData()　オーバーロード
        //引　数   ：検索条件
        //戻り値   ：条件一致顧客データ
        //機　能   ：条件一致商品顧客データの取得
        ///////////////////////////////
        public List<M_Client> GetClientsIDData(M_Client selectCondition)
        {
            List<M_Client> client = new List<M_Client>();

            try
            {
                var context = new SalesManagement_DevContext();
                client = context.M_Clients.Where(x => x.ClID == selectCondition.ClID).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return client;
        }
        public List<M_Client> GetClientstextData(M_Client selectCondition)
        {
            List<M_Client> client = new List<M_Client>();

            try
            {
                var context = new SalesManagement_DevContext();
                client = context.M_Clients.Where(x => x.SoID == selectCondition.SoID ||
                                                      x.ClPhone == selectCondition.ClPhone ||
                                                      x.ClAddress == selectCondition.ClAddress ||
                                                      x.ClPostal == selectCondition.ClPostal ||
                                                      x.ClFAX == selectCondition.ClFAX).ToList();
                context.SaveChanges();

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
