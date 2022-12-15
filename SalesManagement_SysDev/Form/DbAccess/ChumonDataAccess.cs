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
                flg = context.M_Chumons.Any(x => x.ChID == ChID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：DeleteChumonsData()
        //引　数   ：注文データ
        //戻り値   ：True or False
        //機　能   ：注文データの削除
        //          ：削除成功の場合True
        //          ：削除失敗の場合False
        ///////////////////////////////
        public bool DeleteChumonData(int delChumonID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var chumons = context.M_Chumons.Single(x => x.ChID == delChumonID);
                context.M_Chumons.Remove(chumons);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        internal bool DeleteChumonData(M_Chumon delChumonID)
        {
            throw new NotImplementedException();
        }

        ///////////////////////////////
        //メソッド名：ConfirmChumonsData()
        //引　数   ：注文データ
        //戻り値   ：True or False
        //機　能   ：注文データの確定
        //          ：確定成功の場合True
        //          ：確定失敗の場合False
        ///////////////////////////////
        private bool ConfirmChumonData(int conChumon)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var chumons = context.M_Chumons.Single(x => x.ChID == conChumon);
                context.M_Chumons.Remove(chumons);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        internal bool ConfirmChumonData(M_Chumon conChumon)
        {
            throw new NotImplementedException();
        }

        ///////////////////////////////
        //メソッド名：GetChumonsData()
        //引　数   ：なし
        //戻り値   ：注文データ
        //機　能   ：注文データの取得
        ///////////////////////////////
        public List<M_Chumon> GetChumonData()
        {
            List<M_Chumon> Chumon = new List<M_Chumon>();
            try
            {
                var context = new SalesManagement_DevContext();
                Chumon = context.M_Chumons.ToList();
                context.Dispose();

                return Chumon;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Chumon;
        }

        ///////////////////////////////
        //メソッド名：GetChumonsDspData()
        //引　数   ：なし
        //戻り値   ：表示用注文データ
        //機　能   ：表示用注文データの取得
        ///////////////////////////////
        public List<M_Chumon> GetChumonDspData()
        {
            List<M_Chumon> Chumon = new List<M_Chumon>();
            try
            {
                var context = new SalesManagement_DevContext();
                Chumon = context.M_Chumons.Where(x => x.ChFlag == 0).ToList();
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
        public List<M_Chumon> Getdubblwdata(M_Chumon selectCondition)
        {
            List<M_Chumon> chumon = new List<M_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.M_Chumons.Where(x =>
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

        public List<M_Chumon> GetChSodata(M_Chumon selectCondition)
        {
            List<M_Chumon> chumon = new List<M_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.M_Chumons.Where(x =>
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
        public List<M_Chumon> GetChEmdata(M_Chumon selectCondition)
        {
            List<M_Chumon> chumon = new List<M_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.M_Chumons.Where(x =>
                                                 x.ChID.ToString().Contains(selectCondition.ClID.ToString()) &&
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
        public List<M_Chumon> GetSoEmdata(M_Chumon selectCondition)
        {
            List<M_Chumon> chumon = new List<M_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.M_Chumons.Where(x =>
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



        public List<M_Chumon> GetSodata(M_Chumon selectCondition)
        {
            List<M_Chumon> chumon = new List<M_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.M_Chumons.Where(x =>
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
        public List<M_Chumon> GetEmdata(M_Chumon selectCondition)
        {
            List<M_Chumon> chumon = new List<M_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.M_Chumons.Where(x =>
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
        public List<M_Chumon> Getnodata(M_Chumon selectCondition)
        {
            List<M_Chumon> chumon = new List<M_Chumon>();


            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.M_Chumons.Where(x =>
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
        public List<M_Chhistory> getdetail(M_Chhistory selectCondition)
        {
            List<M_Chhistory> history = new List<M_Chhistory>();
            try
            {
                var context = new SalesManagement_DevContext();
                history = context.M_Chhistory.Where(x => x.ChID == selectCondition.ChID).ToList();
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
