using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    class EmployeeDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckEmployeesCDExistence()
        //引　数   ：社員コード
        //戻り値   ：True or False
        //機　能   ：一致する社員コードの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        ///
        public bool CheckEmployeesCDExistence(int EmID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.M_Employees.Any(x => x.EmID == EmID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                //メッセージ
            }
            return flg;
        }

    }
}
