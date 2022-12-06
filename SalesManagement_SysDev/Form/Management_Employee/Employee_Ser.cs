using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Employee
{
    public partial class Employee_Ser : Form
    {
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        MessageDsp messageDsp = new MessageDsp();
        private static List<M_Employee> employees;
        private static List<Emphistory> emphistories;
        EmployeeDataAccess EmployeeDataAccess = new EmployeeDataAccess();
        public Employee_Ser()
        {
            InitializeComponent();
        }

        private void buttonSer_Click(object sender, EventArgs e)
        {
            //入力データ確認
            if (!GetClientDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }
        private bool GetClientDataAtSelect()
        {
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxPoID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxPoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxPoID.Focus();
                    return false;
                }
            }
            return true;
        }
        private void GenerateDataAtSelect()
        {
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(textBoxPoID.Text.Trim()))
                    {
                        //全て入力されている
                        datedubblwget();
                        return;
                    }
                    else 
                    {
                        //Em・Soのみ
                        datePrMaget();
                        return;
                    }

                }
                else
                {
                    if (!String.IsNullOrEmpty(textBoxPoID.Text.Trim()))
                    {
                       　//Em・Poのみ
                        datePrScget();
                        return;
                    }
                    else
                    {
                        //emのみ
                        dateemget();
                        return;
                    }
                }
            }
            else if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(textBoxPoID.Text.Trim()))
                {
                    //So・Poのみ
                    dateMaScget();
                    return;
                }
                else
                {
                    //Soのみ
                    dateMaget();
                    return;
                }
            }
            else if (!String.IsNullOrEmpty(textBoxPoID.Text.Trim()))
            {
                //Poのみ
                dateScget();
                return;
            }
            else
            {
                //何も入力されていない
                datenolwget();
                return;
            }
        }
        private void SetSelectData()
        {
            dataGridView1.DataSource = employees;
        }
        private void datedubblwget()
        {
            M_Employee selectCondition = new M_Employee()
            {
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmName = textBoxEmName.Text.Trim(),
                PoID = int.Parse(textBoxPoID.Text.Trim()),
                EmPhone = textBoxEmPhone.Text.Trim(),
                //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
            };
            employees = EmployeeDataAccess.G(selectCondition);
        }
        private void dateemget()
        {
            M_Employee selectCondition = new M_Employee()
            {
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                EmName = textBoxEmName.Text.Trim(),
                EmPhone = textBoxEmPhone.Text.Trim(),
                //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
            };
            employees = EmployeeDataAccess.Getdateemget(selectCondition);
        }
        private void datePrMaget()
        {
            M_Employee selectCondition = new M_Employee()
            {
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmName = textBoxEmName.Text.Trim(),
                EmPhone = textBoxEmPhone.Text.Trim(),
                //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
            };
            employees = EmployeeDataAccess.GetPrMaget(selectCondition);
        }
        private void datePrScget()
        {
            M_Employee selectCondition = new M_Employee()
            {
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                PoID = int.Parse(textBoxPoID.Text.Trim()),
                EmName = textBoxEmName.Text.Trim(),
                EmPhone = textBoxEmPhone.Text.Trim(),
                //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
            };
            employees = EmployeeDataAccess.GetPrScget(selectCondition);
        }
        private void dateMaScget()
        {
            M_Employee selectCondition = new M_Employee()
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                PoID = int.Parse(textBoxPoID.Text.Trim()),
                EmName = textBoxEmName.Text.Trim(),
                EmPhone = textBoxEmPhone.Text.Trim(),
                //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
            };
            employees = EmployeeDataAccess.GetMaScget(selectCondition);
        }
        private void dateMaget()
        {
            M_Employee selectCondition = new M_Employee()
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmName = textBoxEmName.Text.Trim(),
                EmPhone = textBoxEmPhone.Text.Trim(),
                //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
            };
            employees = EmployeeDataAccess.GetMaget(selectCondition);
        }
        private void dateScget()
        {
            M_Employee selectCondition = new M_Employee()
            {
                PoID = int.Parse(textBoxSoID.Text.Trim()),
                EmName = textBoxEmName.Text.Trim(),
                EmPhone = textBoxEmPhone.Text.Trim(),
                //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
            };
            employees = EmployeeDataAccess.GetScget(selectCondition);
        }
        private void datenolwget()
        {
            M_Employee selectCondition = new M_Employee()
            {
                EmName = textBoxEmName.Text.Trim(),
                EmPhone = textBoxEmPhone.Text.Trim(),
                //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
            };
            employees = EmployeeDataAccess.Getnolwget(selectCondition);
        }

        private void Employee_Ser_Load(object sender, EventArgs e)
        {
            invcnt();
        }
        private void invcnt()
        {
            labelEm.Visible = false;
            labelSo.Visible = false;
            labelPo.Visible = false;
            datetime.Visible = false;
            userid.Visible = false;
            username.Visible = false;
            uptime.Visible = false;
            upuserid.Visible = false;
            upusername.Visible = false;
        }
        private void incntok()
        {
            labelEm.Visible = true;
            labelSo.Visible = true;
            labelPo.Visible = true;
            datetime.Visible = true;
            userid.Visible = true;
            username.Visible = true;
            uptime.Visible = true;
            upuserid.Visible = true;
            upusername.Visible = true;
        }
        private void setdatedetail()
        {
            var x = emphistories.FirstOrDefault();
            if (x == null)
            {
                invcnt();
                return;
            }

            labelEm.Text = x.hisNo;
            labelSo.Text = x.EmID;
            labelPo.Text = x.SoID;
            datetime.Text = x.RegisteredDate;
            upusername.Text = x.regUserID;
            username.Text = x.regUserName;
            uptime.Text = x.UpDateTime;
            upuserid.Text = x.LastupdatedUserID;
            upusername.Text = x.LastupdatedUserName;
            incntok();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int number;
            number = (int)dataGridView1.CurrentRow.Cells[0].Value;
            serchdateset(number);
            setdatedetail();
        }
        private void serchdateset(int number)
        {
         
            Emphistory selectCondition = new Emphistory
            {
                EmID = number.ToString(),

            };
            emphistories = EmployeeDataAccess.getdetail(selectCondition);
        }
    }
}
