using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


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
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
        ///////////////////////////////
        //メソッド名：SelectEmployeeExistenceCheck()
        //引　数   ：社員コード、パスワード
        //戻り値   ：True or False
        //機　能   ：部分一致する社員コード、パスワードの有無を確認
        //          ：部分一致データありの場合True
        //          ：部分一致データなしの場合False
        ///////////////////////////////
        public bool SelectEmployeeExistenceCheck(string EmID, string EmPass)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.M_Employees.Any(x => x.EmID.ToString() == EmID && x.EmPassword == EmPass);
                //flg = context.M_Employees.Any(x => x.EmID.ToString().Contains(EmID)
                //                                  && x.EmPassword.Contains(EmPass));
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddEmpData()
        //引　数   ：社員データ
        //戻り値   ：True or False
        //機　能   ：部分一致する社員コード、パスワードの有無を確認
        //          ：部分一致データありの場合True
        //          ：部分一致データなしの場合False
        ///////////////////////////////
        public bool AddEmpData(M_Employee regEmp)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Employees.Add(regEmp);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdEmployeeData(M_Employee updEmp)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Emps = context.M_Employees.Single(x => x.EmID == updEmp.EmID);
                Emps.EmID = updEmp.EmID;
                Emps.EmName = updEmp.EmName;
                Emps.SoID = updEmp.SoID;
                Emps.PoID = updEmp.PoID;
                Emps.EmHiredate = updEmp.EmHiredate;
                Emps.EmPassword = updEmp.EmPassword;
                Emps.EmPhone = updEmp.EmPhone;
                Emps.EmFlag = updEmp.EmFlag;
                Emps.EmHidden = updEmp.EmHidden;

                context.SaveChanges();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

    }
}
