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
        private static List<M_Employee> Emp1;
        private static int grid = 30;

        public Employee_Ser()
        {
            InitializeComponent();
        }

        private void button_Ser_Click(object sender, EventArgs e)
        {
            //入力データ確認
            if (!GetEmployetDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }

        private void button_Cle_Click(object sender, EventArgs e)
        {
            textBoxEmID.Text = "";
            textBoxSoID.Text = "";
            textBoxPoID.Text = "";
            textBoxEmName.Text = "";
            dateTimePickerEmHiredate.Value = DateTime.Now;
            textBoxEmPhone.Text = "";
            //textBoxEmHidden.Text = "";
        }
        //private void setdata()
        //{
        //    employees = EmployeeDataAccess.GetEmployeeDspData();
        //    dataGridViewDsp.DataSource = clie;
        //}
        private void button_First_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            dataGridViewDsp.DataSource = Emp1.Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Emp1.Skip(pageSize * pageNo).Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Emp1.Skip(pageSize * pageNo).Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Emp1.Skip(pageSize * pageNo).Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";
        }

        private void Employee_Ser_Load_1(object sender, EventArgs e)
        {
            SetFormDataGridView();
            invcnt();
        }

        private bool GetEmployetDataAtSelect()
        {
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    MessageBox.Show("社員コードは半角数値入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error); //messageDsp.DspMsg("M6001");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1005");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxPoID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxPoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M6021");
                    textBoxPoID.Focus();
                    return false;
                }
            }
            return true;
        }
        private void GenerateDataAtSelect()
        {
            if(!checkBoxEmFlag.Checked == true)
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
            else
            {
                try
                {
                    var context = new SalesManagement_DevContext();
                    employees = context.M_Employees.Where(x => x.EmFlag == 2).ToList();
                    SetDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void SetSelectData()
        {
            dataGridViewDsp.DataSource = employees;
        }
        private void datedubblwget()
        {
            if (checkBoxdate.Checked == true)
            {
                //全て入力されている
                M_Employee selectCondition = new M_Employee()
                {
                    EmID = int.Parse(textBoxEmID.Text.Trim()),
                    SoID = int.Parse(textBoxSoID.Text.Trim()),
                    EmName = textBoxEmName.Text.Trim(),
                    PoID = int.Parse(textBoxPoID.Text.Trim()),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.GetPronlyHdata(selectCondition, dateTimePickerEmHiredate.Value, dateTimePickerEmHiredate2.Value);
            }
            else
            {
                //全て入力されている
                M_Employee selectCondition = new M_Employee()
                {
                    EmID = int.Parse(textBoxEmID.Text.Trim()),
                    SoID = int.Parse(textBoxSoID.Text.Trim()),
                    EmName = textBoxEmName.Text.Trim(),
                    PoID = int.Parse(textBoxPoID.Text.Trim()),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.GetMaScget(selectCondition);
            }
        }

        private void dateemget()
        {
            if (checkBoxdate.Checked == true)
            {
                //emのみ
                M_Employee selectCondition = new M_Employee()
                {
                    EmID = int.Parse(textBoxEmID.Text.Trim()),
                    EmName = textBoxEmName.Text.Trim(),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.GetdateHemget(selectCondition, dateTimePickerEmHiredate.Value, dateTimePickerEmHiredate2.Value);
            }
            else
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
        }
        private void datePrMaget()
        {
            if (checkBoxdate.Checked == true)
            {
                //Em・Soのみ
                M_Employee selectCondition = new M_Employee()
                {
                    EmID = int.Parse(textBoxEmID.Text.Trim()),
                    SoID = int.Parse(textBoxSoID.Text.Trim()),
                    EmName = textBoxEmName.Text.Trim(),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.GetHPrMaget(selectCondition, dateTimePickerEmHiredate.Value, dateTimePickerEmHiredate2.Value);
            }
            else
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
        }
        private void datePrScget()
        {
            if (checkBoxdate.Checked == true)
            {
                //Em・Poのみ
                M_Employee selectCondition = new M_Employee()
                {
                    EmID = int.Parse(textBoxEmID.Text.Trim()),
                    PoID = int.Parse(textBoxPoID.Text.Trim()),
                    EmName = textBoxEmName.Text.Trim(),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.GetHPrScget(selectCondition, dateTimePickerEmHiredate.Value, dateTimePickerEmHiredate2.Value);
            }
            else
            {
                //Em・Poのみ
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
        }
        private void dateMaScget()
        {
            if (checkBoxdate.Checked == true)
            {
                //So・Poのみ
                M_Employee selectCondition = new M_Employee()
                {
                    SoID = int.Parse(textBoxSoID.Text.Trim()),
                    PoID = int.Parse(textBoxPoID.Text.Trim()),
                    EmName = textBoxEmName.Text.Trim(),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.GetHMaScget(selectCondition, dateTimePickerEmHiredate.Value, dateTimePickerEmHiredate2.Value);
            }
            else
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
        }
        private void dateMaget()
        {
            if (checkBoxdate.Checked == true)
            {
                //Soのみ
                M_Employee selectCondition = new M_Employee()
                {
                    SoID = int.Parse(textBoxSoID.Text.Trim()),
                    EmName = textBoxEmName.Text.Trim(),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.GetHMaget(selectCondition, dateTimePickerEmHiredate.Value, dateTimePickerEmHiredate2.Value);
            }
            else
            {
                //Soのみ
                M_Employee selectCondition = new M_Employee()
                {
                    SoID = int.Parse(textBoxSoID.Text.Trim()),
                    EmName = textBoxEmName.Text.Trim(),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.GetMaget(selectCondition);
            }
        }
        private void dateScget()
        {
            if (checkBoxdate.Checked == true)
            {
                //Poのみ
                M_Employee selectCondition = new M_Employee()
                {
                    PoID = int.Parse(textBoxSoID.Text.Trim()),
                    EmName = textBoxEmName.Text.Trim(),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.GetHScget(selectCondition, dateTimePickerEmHiredate.Value, dateTimePickerEmHiredate2.Value);
            }
            else
            {
                //Poのみ
                M_Employee selectCondition = new M_Employee()
                {
                    PoID = int.Parse(textBoxSoID.Text.Trim()),
                    EmName = textBoxEmName.Text.Trim(),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.GetScget(selectCondition);
            }
        }
        private void datenolwget()
        {
            if (checkBoxdate.Checked == true)
            {
                //何も入力されていない
                M_Employee selectCondition = new M_Employee()
                {
                    EmName = textBoxEmName.Text.Trim(),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.GetHnolwget(selectCondition, dateTimePickerEmHiredate.Value, dateTimePickerEmHiredate2.Value);
            }
            else
            {
                //何も入力されていない
                M_Employee selectCondition = new M_Employee()
                {
                    EmName = textBoxEmName.Text.Trim(),
                    EmPhone = textBoxEmPhone.Text.Trim(),
                    //EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text.Trim())
                };
                employees = EmployeeDataAccess.Getnolwget(selectCondition);
            }
        }

        private void Employee_Ser_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            invcnt();
        }
        private void SetFormDataGridView()
        {
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            //読み取り専用に指定
            dataGridViewDsp.ReadOnly = true;
            //行内をクリックすることで行を選択
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //ヘッダー位置の指定
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //データグリッドビューのデータ取得
            GetDataGridView();

        }
        private void GetDataGridView()
        {

            int radioint = 0;
            // 商品データの取得
            Emp1 = EmployeeDataAccess.GetEmployeeDataDsp(radioint);

            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Emp1.Skip(pageSize * pageNo).Take(pageSize).ToList();

            //列名の中央揃え
            foreach (DataGridViewColumn clm in dataGridViewDsp.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //各列幅の指定
            //dataGridViewDsp.Columns[0].Width = 80;
            //dataGridViewDsp.Columns[1].Width = 80;
            //dataGridViewDsp.Columns[2].Width = 200;
            //dataGridViewDsp.Columns[3].Width = 200;
            //dataGridViewDsp.Columns[4].Width = 200;
            //dataGridViewDsp.Columns[5].Width = 80;
            //dataGridViewDsp.Columns[6].Width = 80;
            //dataGridViewDsp.Columns[7].Width = 100;
            //dataGridViewDsp.Columns[8].Width = 150;



            //各列の文字位置の指定
            //dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            //dataGridViewの総ページ数
            labelPage.Text = "/" + ((int)Math.Ceiling(Emp1.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();

        }
        private void invcnt()
        {
            //labelEm.Visible = false;
            //labelSo.Visible = false;
            //labelPo.Visible = false;
            //datetime.Visible = false;
            //userid.Visible = false;
            //username.Visible = false;
            //uptime.Visible = false;
            //upuserid.Visible = false;
            //upusername.Visible = false;
        }
        private void incntok()
        {
            //labelEm.Visible = true;
            //labelSo.Visible = true;
            //labelPo.Visible = true;
            //datetime.Visible = true;
            //userid.Visible = true;
            //username.Visible = true;
            //uptime.Visible = true;
            //upuserid.Visible = true;
            //upusername.Visible = true;
        }


        private void dataGridViewDsp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //int number;
            //number = (int)dataGridViewDsp.CurrentRow.Cells[1].Value;
            //serchdateset(number);
            //setdatedetail();
        }

        private void dataGridViewDsp_SelectionChanged(object sender, EventArgs e)
        {
            int number;
            int EmIDtxt;
            number = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            EmIDtxt = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            labelEmID.Text = textBoxEmID.ToString();

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
        private void setdatedetail()
        {
            var x = emphistories.FirstOrDefault();
            if (x == null)
            {
                invcnt();
                return;
            }

            labelEmID.Text = x.EmID;
            labelcreatedate.Text = x.RegisteredDate;
            labelcreateid.Text = x.regUserID;
            labelcreatename.Text = x.regUserName;
            llabelcreateupddate.Text = x.UpDateTime;
            labelcreateupdid.Text = x.LastupdatedUserID;
            labelcreateupdname.Text = x.LastupdatedUserName;
            incntok();


        }

        private void button_Hide_Click(object sender, EventArgs e)
        {
            int number = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            MessageBox.Show("非表示にしてもよろしいでしょうか？");
            EmployeeDataAccess.upflg(number);
            setdata();
        }

        private void setdata()
        {
            Emp1 = EmployeeDataAccess.GetEmployeeDataDsp1();
            dataGridViewDsp.DataSource = Emp1;
        }

        private void button_Del_Click(object sender, EventArgs e)
        {

        }

        
    }
}
