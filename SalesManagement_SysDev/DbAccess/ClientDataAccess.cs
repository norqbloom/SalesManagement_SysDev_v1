using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    class ClientDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckDivisionCDExistence()
        //引　数   ：顧客コード
        //戻り値   ：True or False
        //機　能   ：一致する部署コードの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////

        public bool CheckClientCDExistence(int ClID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.M_Clients.Any(x => x.ClID == ClID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                
            }
            return flg;
        }



    }
}
