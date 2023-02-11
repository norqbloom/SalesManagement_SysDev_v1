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
        private static List<M_Employee> Emp1;
        private static int grid = 30;

        public Employee_Add()
        {
            InitializeComponent();
        }

        private void Employee_Add_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();

            var context = new SalesManagement_DevContext();
            var a = context.M_Employees.Count();
            int countplus = a + 1;
            textBoxEmID.Text = countplus.ToString();
        }

        private void button_Add_Click(object sender, EventArgs e)
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
            SetFormDataGridView();
        }

        private void button_Cle_Click(object sender, EventArgs e)
        {
            textBoxSoID.Text = "";
            textBoxPoID.Text = "";
            textBoxEmName.Text = "";
            dateTimePickerEmHiredate.Value = DateTime.Now; 
            textBoxEmPhone.Text = "";
        }

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
            int pageNo = int.Parse(textBoxPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(Emp1.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Emp1.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Emp1.Count / (double)pageSize);
            if (pageNo >= lastPage)
                textBoxPageNo.Text = lastPage.ToString();
            else
                textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Emp1.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Emp1.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private bool GetEmpDataReg()
        {
            //EmIDの確認 社員
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                //Emid半角英数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    messageDsp.DspMsg("M6001");//社員IDは半角数字入力です
                    textBoxEmID.Focus();
                    return false;
                }
                //Emid文字数チェック
                if (textBoxEmID.TextLength > 6)
                {
                    messageDsp.DspMsg("M6002");//社員IDは６文字です
                    textBoxEmID.Focus();
                    return false;
                }

                int EmpID = int.Parse(textBoxEmID.Text.Trim());
                if (employeeDataAccess.CheckEmployeesCDExistence(EmpID))
                {
                    messageDsp.DspMsg("M6003");//入力された社員IDは既に存在しています
                    textBoxEmID.Focus();
                    return false;
                }

            }
            else
            {
                messageDsp.DspMsg("M6004");//社員IDが入力されていません
                textBoxEmID.Focus();
                return false;
            }

            //社員名の確認
            if (!String.IsNullOrEmpty(textBoxEmName.Text.Trim()))
            {
                //名前文字数
                if (textBoxEmName.TextLength > 50)
                {
                    messageDsp.DspMsg("M6006");//社員名は50文字以下です
                    textBoxEmName.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M6007");//社員名が入力されていません
                textBoxEmName.Focus();
                return false;
            }
            //SoID確認　営業所
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                //SOid型確認
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1005");//営業所IDは半角数字入力です
                    textBoxSoID.Focus();
                    return false;
                }
                //soid文字数チェック
                if (textBoxSoID.TextLength > 2)
                {
                    messageDsp.DspMsg("M1006");//営業所IDは2文字以下です
                    textBoxSoID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1008");//営業所IDが入力されていません
                textBoxSoID.Focus();
                return false;
            }

            //PoID確認 役職ID
            if (!String.IsNullOrEmpty(textBoxPoID.Text.Trim()))
            {
                //PoID型確認
                if (!dataInputFormCheck.CheckNumeric(textBoxPoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M6021");//役職IDは数字入力です
                    textBoxPoID.Focus();
                    return false;
                }
                //PoID文字数チェック
                if (textBoxPoID.TextLength > 2)
                {
                    messageDsp.DspMsg("M6022");//役職ID2文字以下です
                    textBoxPoID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M6023");//役職IDを入力してください
                textBoxPoID.Focus();
                return false;
            }

            //電話番号確認
            if (!String.IsNullOrEmpty(textBoxEmPhone.Text.Trim()))
            {
                //文字型
                if (!dataInputFormCheck.CheckHalfAlphabetNumeric(textBoxEmPhone.Text.Trim()))
                {
                    messageDsp.DspMsg("M1015");//電話番号は半角数値入力です
                    textBoxEmPhone.Focus();
                    return false;
                }
                //電話番号文字数チェック
                if (textBoxEmPhone.TextLength > 13)
                {
                    messageDsp.DspMsg("M1016");//電話番号は13文字以下です
                    textBoxEmPhone.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M1035");//電話番号が入力されていません
                textBoxEmPhone.Focus();
                return false;
            }
            return true;
        }

        private M_Employee GenerateDataAtRegistration()
        {
            Random pw = new Random();
            byte[] rndary = new byte[1];
            pw.NextBytes(rndary);

            return new M_Employee
            {

                EmID = int.Parse(textBoxEmID.Text.Trim()),
                EmName = textBoxEmName.Text.Trim(),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                PoID = int.Parse(textBoxPoID.Text.Trim()),
                EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text),
                EmPassword = pw.ToString(),
                EmPhone = textBoxEmPhone.Text.Trim(),
                EmFlag = 0,
                EmHidden = String.Empty
            };
        }

        private void RegistrationStaff(M_Employee regEmp)
        {
            DialogResult result = messageDsp.DspMsg("M6011");//社員データを登録してよろしいですか？
            if (result == DialogResult.Cancel)
                return;
            //登録
            bool flg = employeeDataAccess.AddEmpData(regEmp);
            if (flg == true)
                messageDsp.DspMsg("M6012");//社員データを登録しました
            else
                messageDsp.DspMsg("M6013");//社員データ登録に失敗しました


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
        private void GetDataGridView()
        {

            int radioint = 0;
            // 商品データの取得
            Emp1 = employeeDataAccess.GetEmployeeDataDsp(radioint);

            // DataGridViewに表示するデータを指定
            SetDataGridView();
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



    }
}
