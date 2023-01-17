﻿using System;
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
    public partial class Employee_Upd : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        private static List<M_Employee> employees;
        PasswordHash passwordHash = new PasswordHash();
        private static int grid = 10;

        public Employee_Upd()
        {
            InitializeComponent();
        }

        private void button_Upd_Click(object sender, EventArgs e)
        {
            // 5.3.2.1 妥当な商品データ取得
            if (!GetValidDataAtUpdate())
            {
                return;
            }

            // 5.3.2.2 スタッフ情報作成
            var updemp = GenerateDataAtUpdate();

            // 5.3.2.3 スタッフ情報更新
            UpdateItem(updemp);
            SetFormDataGridView();
        }

        private void button_Cle_Click(object sender, EventArgs e)
        {
            textBoxEmID.Text = "";
            textBoxSoID.Text = "";
            textBoxPoID.Text = "";
            textBoxEmName.Text = "";
            dateTimePickerEmHiredate.Value = DateTime.Now;
            checkBoxEmFlag.Checked = false;
            textBoxEmPhone.Text = "";
            textBoxEmHidden.Text = "";
        }

        private void Employee_Upd_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            dataGridViewDsp.DataSource = employees.Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
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

        private void button_Next_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
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

        private void button_Last_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(employees.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = employees.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private bool GetValidDataAtUpdate()
        {
            //EmIDの確認
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
                if (!employeeDataAccess.CheckEmployeesCDExistence(int.Parse(textBoxEmID.Text.Trim())))
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
            //SoID確認 営業所
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

            //PoID確認　役職
            if (!String.IsNullOrEmpty(textBoxPoID.Text.Trim()))
            {
                //PoID型確認
                if (!dataInputFormCheck.CheckNumeric(textBoxPoID.Text.Trim()))
                {
                    MessageBox.Show("役職IDは半角数字入力です");　//messageDsp.DspMsg("M6021");
                    textBoxPoID.Focus();
                    return false;
                }
                //PoID文字数チェック
                if (textBoxPoID.TextLength > 2)
                {
                    MessageBox.Show("役職IDは文字数は2文字以下です");　//messageDsp.DspMsg("M6022");
                    textBoxPoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("役職IDを入力してください");　//messageDsp.DspMsg("M6023");
                textBoxPoID.Focus();
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
                MessageBox.Show("電話番号入力してください");　//messageDsp.DspMsg("M1035");
                textBoxEmPhone.Focus();
                return false;
            }

            if (checkBoxEmFlag.CheckState == CheckState.Indeterminate)
            {

                MessageBox.Show("社員管理フラグが不確定な状況です");　//messageDsp.DspMsg("M6027");
                checkBoxEmFlag.Focus();
                return false;
            }


            return true;
        }
        private M_Employee GenerateDataAtUpdate()
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

            return new M_Employee
            {

                EmID = int.Parse(textBoxEmID.Text.Trim()),
                EmName = textBoxEmName.Text.Trim(),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                PoID = int.Parse(textBoxPoID.Text.Trim()),
                EmHiredate = DateTime.Parse(dateTimePickerEmHiredate.Text),
                //EmPassword = pw.ToString(),
                EmPhone = textBoxEmPhone.Text.Trim(),
                EmFlag = checkflg,
                //EmHidden = textBoxEmHidden.Text.Trim()


            };
        }
        private void UpdateItem(M_Employee updemp)
        {
            DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            //登録
            bool flg = employeeDataAccess.UpdEmployeeData(updemp);
            if (flg == true)
                MessageBox.Show("社員情報を登録しました");　//messageDsp.DspMsg("M6015");
            else
                MessageBox.Show("社員情報の登録に失敗しました");　//messageDsp.DspMsg("M6016");
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int number;
            number = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            M_Employee selectCondition = new M_Employee()
            {
                EmID = number
            };

            employees = employeeDataAccess.GetEmIDdate(selectCondition);
            var x = employees.FirstOrDefault();
            textBoxEmID.Text = x.EmID.ToString();
            textBoxEmName.Text = x.EmName;
            textBoxSoID.Text = x.SoID.ToString();
            textBoxPoID.Text = x.PoID.ToString();
            dateTimePickerEmHiredate.Text = x.EmHiredate.ToString();
            textBoxEmPhone.Text = x.EmPhone;
            //textBoxEmHidden.Text = x.EmHidden;
            //チェックボックスの状態を判断
            if ((int)dataGridViewDsp.CurrentRow.Cells[7].Value == 0)
            {
                checkBoxEmFlag.Checked = false;
            }
            else
            {
                checkBoxEmFlag.Checked = true;
            }
            //各種Formロードと各種ボタンに下記を入力する
            SetFormDataGridView();
        }

        private static List<M_Employee> Emp1;

        ///////////////////////////////
        //メソッド名：SetFormDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューの設定
        ///////////////////////////////
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
        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの取得
        ///////////////////////////////
        private void GetDataGridView()
        {

            int radioint = 0;
            // 商品データの取得
            Emp1 = employeeDataAccess.GetEmployeeDataDsp(radioint);

            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
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

        private void button_Hide_Click(object sender, EventArgs e)
        {
            int number = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            MessageBox.Show("非表示にしてもよろしいでしょうか？");
            employeeDataAccess.upflg(number);
            setdata();
        }

        private void setdata()
        {
            Emp1 = employeeDataAccess.GetEmployeeDataDsp1();
            dataGridViewDsp.DataSource = Emp1;
        }
    }
}
