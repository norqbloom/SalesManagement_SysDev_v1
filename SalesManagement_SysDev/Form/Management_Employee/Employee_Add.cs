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
    public partial class Employee_Add : Form
    {
        
        MessageDsp messageDsp = new MessageDsp();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        PasswordHash passwordHash = new PasswordHash();
        private static List<M_Employee> employees;
        private static List<M_EmployeeDsp> Emp1;

        public Employee_Add()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //データ確認
            if (!GetEmpDataReg())
                return;

            //社員情報作成
            var regEmp = GenerateDataAtRegistration();

            //社員情報登録
            RegistrationStaff(regEmp);
            var reghis = GeneratehistoryDataAtRegistration();
            RegistrationClhistory(reghis);
        }

        private bool GetEmpDataReg()
        {
            //EmIDの確認 社員
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                //Emid半角英数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    messageDsp.DspMsg("M6001");
                    textBoxEmID.Focus();
                    return false;
                }
                //Emid文字数チェック
                if (textBoxEmID.TextLength > 6)
                {
                    messageDsp.DspMsg("M6002");
                    textBoxEmID.Focus();
                    return false;
                }

                int EmpID = int.Parse(textBoxEmID.Text.Trim());
                if (employeeDataAccess.CheckEmployeesCDExistence(EmpID))
                {
                    messageDsp.DspMsg("M6003");
                    textBoxEmID.Focus();
                    return false;
                }

            }
            else
            {
                messageDsp.DspMsg("M6004");
                textBoxEmID.Focus();
                return false;
            }

            //社員名の確認
            if (!String.IsNullOrEmpty(textBoxEmName.Text.Trim()))
            {
                //名前文字数
                if (textBoxEmName.TextLength > 50)
                {
                    messageDsp.DspMsg("M6006");
                    textBoxEmName.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M6007");
                textBoxEmName.Focus();
                return false;
            }
            //SoID確認　営業所
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                //SOid型確認
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1005");
                    textBoxSoID.Focus();
                    return false;
                }
                //soid文字数チェック
                if (textBoxSoID.TextLength > 2)
                {
                    messageDsp.DspMsg("M1006");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1008");
                textBoxSoID.Focus();
                return false;
            }

            //PoID確認 役職ID
            if (!String.IsNullOrEmpty(textBoxPoID.Text.Trim()))
            {
                //PoID型確認
                if (!dataInputFormCheck.CheckNumeric(textBoxPoID.Text.Trim()))
                {
                    MessageBox.Show("半角数字やしw");　//messageDsp.DspMsg("M6021");
                    textBoxPoID.Focus();
                    return false;
                }
                //PoID文字数チェック
                if (textBoxPoID.TextLength > 2)
                {
                    MessageBox.Show("PoIDは文字数は2文字");　//messageDsp.DspMsg("M6022");
                    textBoxPoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("PoID入力せい");　//messageDsp.DspMsg("M6023");
                textBoxPoID.Focus();
                return false;
            }

            //パスワードの確認
            if (!String.IsNullOrEmpty(textBoxEmPassword.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(textBoxEmPassword.Text.Trim()))
                {
                    MessageBox.Show("半角英数字やしw"); //messageDsp.DspMsg("M6025");
                    textBoxEmPassword.Focus();
                    return false;
                }
                //パスワード文字数チェック
                if (textBoxEmPassword.TextLength > 10)
                {
                    MessageBox.Show("パスワードは文字数は10文字"); //messageDsp.DspMsg("M6026");
                    textBoxEmPassword.Focus();
                    return false;
                }

            }
            else
            {
                MessageBox.Show("パスワード入力せい"); //messageDsp.DspMsg("M6024");
                textBoxEmPassword.Focus();
                return false;
            }

            //電話番号確認
            if (!String.IsNullOrEmpty(textBoxEmPhone.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(textBoxEmPhone.Text.Trim()))
                {
                    messageDsp.DspMsg("M1015");
                    textBoxEmPhone.Focus();
                    return false;
                }
                //電話番号文字数チェック
                if (textBoxEmPhone.TextLength > 13)
                {
                    messageDsp.DspMsg("M1016");
                    textBoxEmPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号入力せい"); //messageDsp.DspMsg("M1035");
                textBoxEmPhone.Focus();
                return false;
            }

            if (checkBoxEmFlag.CheckState == CheckState.Indeterminate)
            {

                MessageBox.Show("不確定な状況"); //messageDsp.DspMsg("M6027");
                checkBoxEmFlag.Focus();
                return false;
            }


            return true;
        }
        private M_Employee GenerateDataAtRegistration()
        {
            int checkflg;
            if (checkBoxEmFlag.Checked == true)
            {
                checkflg = 2;
            }
            else
            {
                checkflg = 0;
            }


            string pw = passwordHash.CreatePasswordHash(textBoxEmPassword.Text.Trim());
            return new M_Employee
            {

                EmID = int.Parse(textBoxEmID.Text.Trim()),
                EmName = textBoxEmName.Text.Trim(),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                PoID = int.Parse(textBoxPoID.Text.Trim()),
                EmHiredate = dateTimePickerEmHiredate.Value.ToString(),
                EmPassword = pw,
                EmPhone = textBoxEmPhone.Text.Trim(),
                EmFlag = checkflg,
                EmHidden = textBoxEmHidden.Text.Trim()


            };
        }


        private void RegistrationStaff(M_Employee regEmp)
        {
            DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            //登録
            bool flg = employeeDataAccess.AddEmpData(regEmp);
            if (flg == true)
                MessageBox.Show("ok");　//messageDsp.DspMsg("M6012");
            else
                MessageBox.Show("no");　//messageDsp.DspMsg("M6013");


        }
        private Emphistory GeneratehistoryDataAtRegistration()
        {
            DateTime dt = DateTime.Now;
            string regtime = dt.ToString("MM/dd HH;mm");

            return new Emphistory
            {
                EmID = textBoxEmID.Text,
                SoID = textBoxSoID.Text,
                PoID = textBoxPoID.Text,
                RegisteredDate = regtime,
                regUserID = template.EmID.ToString(),
                regUserName = template.loginName,
                UpDateTime = "なし",
                LastupdatedUserID = "なし",
                LastupdatedUserName = "なし"

            };
        }
        private void RegistrationClhistory(Emphistory reghis)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.emphistories.Add(reghis);
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void change_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }
        
        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Emp1.Skip(pageSize * pageNo).Take(pageSize).ToList();

            //列名の中央揃え
            foreach (DataGridViewColumn clm in dataGridViewDsp.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //各列幅の指定
            dataGridViewDsp.Columns[0].Width = 80;
            dataGridViewDsp.Columns[1].Width = 80;
            dataGridViewDsp.Columns[2].Width = 200;
            dataGridViewDsp.Columns[3].Width = 200;
            dataGridViewDsp.Columns[4].Width = 200;
            dataGridViewDsp.Columns[5].Width = 80;
            dataGridViewDsp.Columns[6].Width = 80;
            dataGridViewDsp.Columns[7].Width = 100;
            dataGridViewDsp.Columns[8].Width = 150;



            //各列の文字位置の指定
            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            //dataGridViewの総ページ数
            labelPage.Text = "/" + ((int)Math.Ceiling(Emp1.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();

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
            Emp1 = employeeDataAccess.GetProductData2(radioint);

            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }

        private void buttonFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            dataGridViewDsp.DataSource = employees.Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridViewDsp.DataSource = employees.Skip(pageSize * pageNo).Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
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
                dataGridViewDsp.DataSource = employees.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
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
            dataGridViewDsp.DataSource = employees.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void Employee_Add_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }
        private void SetFormDataGridView()
        {
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "20";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPageNo_TextChanged(object sender, EventArgs e)
        {

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
    }
}
