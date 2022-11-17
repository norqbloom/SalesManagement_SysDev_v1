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
                flg = context.M_Employees.Any(x => x.EmID.ToString().Contains(EmID)
                                                  && x.EmPassword.Contains(EmPass));
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        ///////////////////////////////
        //メソッド名：UpdateEmpData()
        //引　数   ：スタッフデータ
        //戻り値   ：True or False
        //機　能   ：スタッフデータの更新
        //          ：更新成功の場合True
        //          ：更新失敗の場合False
        ///////////////////////////////
        ///

        public bool UpdateEmpData(M_Employee updEmp)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Employee = context.M_Employees.Single(x => x.EmID == updEmp.EmID);

                Employee.EmName = updEmp.EmName;
                Employee.SoID = updEmp.SoID;
                Employee.PoID = updEmp.PoID;
                Employee.EmHiredate = updEmp.EmHiredate;
                Employee.EmPassword = updEmp.EmPassword;
                Employee.EmPhone = updEmp.EmPhone;
                Employee.EmFlag = updEmp.EmFlag;
                Employee.EmHidden = updEmp.EmHidden;
                //パスワード入力時のみ更新
                if (!String.IsNullOrEmpty(updEmp.EmPassword))
                    Employee.EmPassword = updEmp.EmPassword;

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
        //メソッド名：DeleteEmpData()
        //引　数   ：スタッフデータ
        //戻り値   ：True or False
        //機　能   ：スタッフデータの削除
        //          ：削除成功の場合True
        //          ：削除失敗の場合False
        ///////////////////////////////

        public bool DeleteEmpDate(string delEmID)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Employee = context.M_Employees.Single(x => x.EmID.ToString() == delEmID);
                context.M_Employees.Remove(Employee);
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
        public List<M_Employee> GetEmployeeDate()
        {
            List<M_Employee> Employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                Employee = context.M_Employees.ToList();
                context.Dispose();

                return Employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Employee;
        }


    }


}