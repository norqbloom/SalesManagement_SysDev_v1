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
        public bool CheckEmployeesCDExistence(int EmpID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.M_Employees.Any(x => x.EmID == EmpID);
                context.SaveChanges();
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
        public bool SelectEmployeeExistenceCheck(string EmpID, string EmPass)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.M_Employees.Any(x => x.EmID.ToString() == EmpID && x.EmPassword == EmPass);
                //flg = context.M_Employees.Any(x => x.EmID.ToString().Contains(EmID)
                //                                  && x.EmPassword.Contains(EmPass));
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

        internal static bool CheckemployeeCDExistence(int v)
        {
            throw new NotImplementedException();
        }

        internal static bool CheckPrCDExistence(int v)
        {
            throw new NotImplementedException();
        }

        public List<M_Employee> Getdubblwdata(M_Employee selectCondition)
        {
            List<M_Employee> employee = new List<M_Employee>();


            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                 x.EmFlag == 0 &&
                                                 //x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 //x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 //x.EmName.Contains(selectCondition.EmName) &&
                                                 //x.PoID.ToString().Contains(selectCondition.PoID.ToString()) &&
                                                 //x.EmHiredate.Contains(selectCondition.EmHiredate) &&
                                                 x.EmPhone.Contains(selectCondition.EmPhone)
                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetPrMaget(M_Employee selectCondition)
        {
            List<M_Employee> employee = new List<M_Employee>();

            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                 x.EmFlag == 0 &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.EmName.Contains(selectCondition.EmName) &&
                                                 //x.EmHiredate.Contains(selectCondition.EmHiredate) &&
                                                 x.EmPhone.Contains(selectCondition.EmPhone)
                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetPrScget(M_Employee selectCondition)
        {
            List<M_Employee> employee = new List<M_Employee>();

            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                 x.EmFlag == 0 &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                 x.EmName.Contains(selectCondition.EmName) &&
                                                 x.PoID.ToString().Contains(selectCondition.PoID.ToString()) &&
                                                 //x.EmHiredate.Contains(selectCondition.EmHiredate) &&
                                                 x.EmPhone.Contains(selectCondition.EmPhone)
                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetMaScget(M_Employee selectCondition)
        {
            List<M_Employee> employee = new List<M_Employee>();

            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                 x.EmFlag == 0 &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.EmName.Contains(selectCondition.EmName) &&
                                                 x.PoID.ToString().Contains(selectCondition.PoID.ToString()) &&
                                                 //x.EmHiredate.Contains(selectCondition.EmHiredate) &&
                                                 x.EmPhone.Contains(selectCondition.EmPhone)
                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetMaget(M_Employee selectCondition)
        {
            List<M_Employee> employee = new List<M_Employee>();

            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                 x.EmFlag == 0 &&
                                                 x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                 x.EmName.Contains(selectCondition.EmName) &&
                                                 //x.EmHiredate.Contains(selectCondition.EmHiredate) &&
                                                 x.EmPhone.Contains(selectCondition.EmPhone)
                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> Getdateemget(M_Employee selectCondition)
        {
            List<M_Employee> employee = new List<M_Employee>();

            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                     x.EmFlag == 0 &&
                                                     x.EmID==selectCondition.EmID &&
                                                     x.EmName.Contains(selectCondition.EmName) &&
                                                     //x.EmHiredate.Contains(selectCondition.EmHiredate) &&
                                                     x.EmPhone.Contains(selectCondition.EmPhone)
                                                     ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetScget(M_Employee selectCondition)
        {
            List<M_Employee> employee = new List<M_Employee>();

            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                 x.EmFlag == 0 &&
                                                 x.EmName.Contains(selectCondition.EmName) &&
                                                 x.PoID.ToString().Contains(selectCondition.PoID.ToString()) &&
                                                 //x.EmHiredate.Contains(selectCondition.EmHiredate) &&
                                                 x.EmPhone.Contains(selectCondition.EmPhone)
                                                 ).ToList();                context.SaveChanges();

                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> Getnolwget(M_Employee selectCondition)
        {
            List<M_Employee> employee = new List<M_Employee>();

            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                 x.EmFlag == 0 &&
                                                 x.EmName.Contains(selectCondition.EmName) &&
                                                 //x.EmHiredate.Contains(selectCondition.EmHiredate) &&
                                                 x.EmPhone.Contains(selectCondition.EmPhone)
                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetPronlyHdata(M_Employee selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                x.PoID.ToString().Contains(selectCondition.PoID.ToString()) &&
                                                x.EmFlag == 0 &&
                                                x.EmName.Contains(selectCondition.EmName) &&
                                                x.EmHiredate > starttime && x.EmHiredate < stoptime &&
                                                x.EmPhone.Contains(selectCondition.EmPhone)).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetdateHemget(M_Employee selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                x.EmFlag == 0 &&
                                                x.EmName.Contains(selectCondition.EmName) &&
                                                x.EmHiredate > starttime && x.EmHiredate < stoptime &&
                                                x.EmPhone.Contains(selectCondition.EmPhone)).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetHPrMaget(M_Employee selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                x.EmFlag == 0 &&
                                                x.EmName.Contains(selectCondition.EmName) &&
                                                x.EmHiredate > starttime && x.EmHiredate < stoptime &&
                                                x.EmPhone.Contains(selectCondition.EmPhone)).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetHPrScget(M_Employee selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                x.EmID.ToString().Contains(selectCondition.EmID.ToString()) &&
                                                x.PoID.ToString().Contains(selectCondition.PoID.ToString()) &&
                                                x.EmFlag == 0 &&
                                                x.EmName.Contains(selectCondition.EmName) &&
                                                x.EmHiredate > starttime && x.EmHiredate < stoptime &&
                                                x.EmPhone.Contains(selectCondition.EmPhone)).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetHMaScget(M_Employee selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                x.PoID.ToString().Contains(selectCondition.PoID.ToString()) &&
                                                x.EmFlag == 0 &&
                                                x.EmName.Contains(selectCondition.EmName) &&
                                                x.EmHiredate > starttime && x.EmHiredate < stoptime &&
                                                x.EmPhone.Contains(selectCondition.EmPhone)).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetHMaget(M_Employee selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                x.SoID.ToString().Contains(selectCondition.SoID.ToString()) &&
                                                x.EmFlag == 0 &&
                                                x.EmName.Contains(selectCondition.EmName) &&
                                                x.EmHiredate > starttime && x.EmHiredate < stoptime &&
                                                x.EmPhone.Contains(selectCondition.EmPhone)).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetHScget(M_Employee selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                x.PoID.ToString().Contains(selectCondition.PoID.ToString()) &&
                                                x.EmFlag == 0 &&
                                                x.EmName.Contains(selectCondition.EmName) &&
                                                x.EmHiredate > starttime && x.EmHiredate < stoptime &&
                                                x.EmPhone.Contains(selectCondition.EmPhone)).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetHnolwget(M_Employee selectCondition, DateTime starttime, DateTime stoptime)
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                x.EmFlag == 0 &&
                                                x.EmName.Contains(selectCondition.EmName) &&
                                                x.EmHiredate > starttime && x.EmHiredate < stoptime &&
                                                x.EmPhone.Contains(selectCondition.EmPhone)).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        ///////////////////////////////
        //メソッド名：UpPass
        //引　数   ：パスワード
        //戻り値   ：True or False
        //機　能   ：パスワードの更新
        ///////////////////////////////

        public bool UpPass(M_Employee updpass)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Emps = context.M_Employees.Single(x => x.EmID == updpass.EmID);
                Emps.EmPassword = updpass.EmPassword;
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public List<Emphistory> getdetail(Emphistory selectCondition)
        {
            List<Emphistory> emphistory = new List<Emphistory>();
            try
            {
                var context = new SalesManagement_DevContext();
                emphistory = context.emphistories.Where(x => x.EmID == selectCondition.EmID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return emphistory;
        }
        public List<M_EmployeeDsp> GetProductData2(int radioint)
        {
            List<M_EmployeeDsp> employee = new List<M_EmployeeDsp>();

            try
            {   
                var context = new SalesManagement_DevContext();
                var tb = from t1 in context.M_Employees
                         where t1.EmFlag == radioint              
                         select new
                         {
                             t1.EmID,
                             t1.EmName,
                             t1.SoID,
                             t1.PoID,
                             t1.EmHiredate,
                             t1.EmPassword,
                             t1.EmPhone,
                             t1.EmFlag,
                             t1.EmHidden,
                         };
               
                foreach (var p in tb)
                {
                    employee.Add(new M_EmployeeDsp()
                    {
                        EmID = p.EmID,
                        EmName = p.EmName,
                        SoID = p.SoID,
                        PoID = p.PoID,
                        EmHiredate = p.EmHiredate,
                        EmPassword = p.EmPassword,
                        EmPhone = p.EmPhone,
                        EmFlag = p.EmFlag,
                        EmHidden = p.EmHidden,
                    });
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetEmIDdate(M_Employee selectCondition)
        {
            List<M_Employee> employee = new List<M_Employee>();

            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                                                 x.EmFlag == 0 &&
                                                 x.EmID.ToString().Contains(selectCondition.EmID.ToString()) 
                                                 ).ToList();
                context.SaveChanges();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }
        public List<M_Employee> GetEmployeeDataDsp(int radioint)
        {
            List<M_Employee> emp = new List<M_Employee>();

            try
            {
                var context = new SalesManagement_DevContext();
                emp = context.M_Employees.Where(x => x.EmFlag == radioint).ToList();
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return emp;
        }

    }
}
