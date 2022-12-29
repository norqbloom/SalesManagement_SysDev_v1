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
        private static List<M_EmployeeDsp> Emp1;
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
                    MessageBox.Show("社員コードは半角数値入力です","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void dateemget()
        {
            //emのみ
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
            //Em・Soのみ
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
        private void dateMaScget()
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
            employees = EmployeeDataAccess.GetMaScget(selectCondition);
        }
        private void dateMaget()
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
        private void dateScget()
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
        private void datenolwget()
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

        private void Employee_Ser_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            invcnt();
        }
        private void SetFormDataGridView()
        {
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "20";
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            //読み取り専用に指定
            dataGridView1.ReadOnly = true;
            //行内をクリックすることで行を選択
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //ヘッダー位置の指定
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //データグリッドビューのデータ取得
            GetDataGridView();

        }
        private void GetDataGridView()
        {

            int radioint = 0;
            if (radioButton1.Checked == true)
            {
                radioint = 2;
            }
            else
            {
                radioint = 0;
            }
            // 商品データの取得
            Emp1 = EmployeeDataAccess.GetProductData2(radioint);

            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridView1.DataSource = Emp1.Skip(pageSize * pageNo).Take(pageSize).ToList();

            //列名の中央揃え
            foreach (DataGridViewColumn clm in dataGridView1.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //各列幅の指定
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 150;



            //各列の文字位置の指定
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            //dataGridViewの総ページ数
            labelPage.Text = "/" + ((int)Math.Ceiling(Emp1.Count / (double)pageSize)) + "ページ";

            dataGridView1.Refresh();

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
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int number;
            number = (int)dataGridView1.CurrentRow.Cells[0].Value;
            serchdateset(number);
            setdatedetail();
        }
        

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxEmID.Text = "";
            textBoxSoID.Text = "";
            textBoxPoID.Text = "";
            textBoxEmName.Text = "";
            textBoxEmPassword.Text = "";
            dateTimePickerEmHiredate.Value = DateTime.Now;
            checkBoxEmFlag.Checked = false;
            textBoxEmPhone.Text = "";
            textBoxEmHidden.Text = "";
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int number;
            int EmIDtxt;
            //int SoIDtxt;
            //int PoIDtxt;
            number = (int)dataGridView1.CurrentRow.Cells[1].Value;
            EmIDtxt = (int)dataGridView1.CurrentRow.Cells[0].Value;
            //SoIDtxt = (int)dataGridView1.CurrentRow.Cells[2].Value;
            //PoIDtxt = (int)dataGridView1.CurrentRow.Cells[3].Value;
            labelEm.Text = textBoxEmID.ToString();
            //labelSo.Text = textBoxSoID.ToString();
            //labelPo.Text = textBoxPoID.ToString();

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

            labelEm.Text = x.EmID;
            labelSo.Text = x.SoID;
            labelPo.Text = x.PoID;
            datetime.Text = x.RegisteredDate;
            userid.Text = x.regUserID;
            username.Text = x.regUserName;
            uptime.Text = x.UpDateTime;
            upuserid.Text = x.LastupdatedUserID;
            upusername.Text = x.LastupdatedUserName;
            incntok();


        }

        private void change_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void buttonFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            dataGridView1.DataSource = employees.Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridView1.DataSource = employees.Skip(pageSize * pageNo).Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(employees.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridView1.DataSource = employees.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(employees.Count / (double)pageSize);
            if (pageNo >= lastPage)
                textBoxPageNo.Text = lastPage.ToString();
            else
                textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(employees.Count / (double)pageSize) - 1;
            dataGridView1.DataSource = employees.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void textBoxPageNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            dataGridView1.DataSource = employees.Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridView1.DataSource = employees.Skip(pageSize * pageNo).Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(employees.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridView1.DataSource = employees.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(employees.Count / (double)pageSize);
            if (pageNo >= lastPage)
                textBoxPageNo.Text = lastPage.ToString();
            else
                textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(employees.Count / (double)pageSize) - 1;
            dataGridView1.DataSource = employees.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }
    }
}
