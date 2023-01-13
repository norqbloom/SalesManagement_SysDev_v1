using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Hattyu
{
    public partial class Hattyu_Ser : Form
    {
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        MessageDsp messageDsp = new MessageDsp();
        HattyuDataAccess HattyuDataAccess = new HattyuDataAccess();
        private static List<T_Hattyu> Hattyus;
        //private static List<Hahistory> hathistory;

        public Hattyu_Ser()
        {
            InitializeComponent();
        }

        private void Hattyu_Ser_Button_Click(object sender, EventArgs e)
        {
            //入力データ確認
            if (!GetHattyuDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }
        private bool GetHattyuDataAtSelect()
        {
            //CoID確認
            if (!String.IsNullOrEmpty(HaID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(HaID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2028");
                    HaID.Focus();
                    return false;
                }


            }
            //メーカIDの適否
            if (!String.IsNullOrEmpty(MaID.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(MaID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2005");//メーカIDは半角数字入力です
                    MaID.Focus();
                    return false;
                }
                //文字数
                if (MaID.TextLength > 6)
                {
                    messageDsp.DspMsg("2006");
                    MaID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("2008");
                MaID.Focus();
                return false;
            }


            // EmIDの確認 社員
            if (!String.IsNullOrEmpty(EmID.Text.Trim()))

            {
                //Emid半角英数字チェック
                if (!dataInputFormCheck.CheckNumeric(EmID.Text.Trim()))
                {
                    messageDsp.DspMsg("M6001");
                    EmID.Focus();
                    return false;
                }
                //Emid文字数チェック
                if (EmID.TextLength > 6)
                {
                    messageDsp.DspMsg("M6002");
                    EmID.Focus();
                    return false;
                }
                //int EmpID = int.Parse(EmID.Text.Trim());
                if (EmployeeDataAccess.CheckPrCDExistence(int.Parse(EmID.Text.Trim())))
                {
                    messageDsp.DspMsg("M6003");
                    EmID.Focus();
                    return false;
                }

            }
            else
            {
                messageDsp.DspMsg("M6004");
                EmID.Focus();
                return false;
            }
            return true;
        }
        private void GenerateDataAtSelect()
        {
            if (!String.IsNullOrEmpty(HaID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(MaID.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(EmID.Text.Trim()))
                    {
                        //全て入力されている
                        datedubblwget();
                        return;
                    }
                    else
                    {
                        //Ma・Emのみ
                        dateHaget();
                        return;
                    }


                }
                else
                {
                    if (!String.IsNullOrEmpty(EmID.Text.Trim()))
                    {
                       　//Em・Poのみ
                        dateEmget();
                        return;
                    }
                    else
                    {

                        dateHaget();
                        return;
                    }
                }
            }
            else if (!String.IsNullOrEmpty(MaID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(EmID.Text.Trim()))
                {
                    //のみ
                    dateMaget();
                    return;
                }
                else
                {
                    //何も入力されていない
                    datenolwget();
                    return;
                }
            }
        }

        private void SetSelectData()
        {
            dataGridView1.DataSource = Hattyus;
        }
        private void datedubblwget()
        {
            //全て入力されている
            T_Hattyu selectCondition = new T_Hattyu()
            {
                HaID = int.Parse(HaID.Text.Trim()),
                MaID = int.Parse(MaID.Text.Trim()),
                EmID = int.Parse(EmID.Text.Trim()),
            };
            Hattyus = HattyuDataAccess.Getdubblwdata(selectCondition);
        }

        private void dateHaget()
        { // 12/8
            DateTime Dt = DateTime.Parse(HaDate.Text.Trim());
            T_Hattyu selectCondition = new T_Hattyu()
            {
                HaID = int.Parse(HaID.Text.Trim()),
                MaID = int.Parse(MaID.Text.Trim()),
                HaDate = HaDate.Value
            };
            Hattyus = HattyuDataAccess.GetHadata(selectCondition);

        }
        private void dateEmget()
        {
            //Em・Poのみ
            T_Hattyu selectCondition = new T_Hattyu()
            {
                EmID = int.Parse(EmID.Text.Trim()),
                HaID = int.Parse(HaID.Text.Trim()),
            };
            Hattyus = HattyuDataAccess.GetEmdata(selectCondition);
        }
        private void dateMaget()
        {

            T_Hattyu selectCondition = new T_Hattyu()
            {
                EmID = int.Parse(EmID.Text.Trim()),
                HaID = int.Parse(HaID.Text.Trim())
            };
            Hattyus = HattyuDataAccess.GetMadata(selectCondition);
        }
        private void datenolwget()
        {
            //何も入力されていない
            T_Hattyu selectCondition = new T_Hattyu()
            {
                EmID = int.Parse(EmID.Text.Trim()),
                HaID = int.Parse(HaID.Text.Trim()),
                HaDate = HaDate.Value
            };
            Hattyus = HattyuDataAccess.Getnolwget(selectCondition);
        }
        private void Hattyu_Ser_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            invcnt();
        }

        private void SetFormDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void SetDataGridView()
        {

            //列名の中央揃え
            foreach (DataGridViewColumn clm in dataGridView1.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //各列幅の指定
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[9].Width = 100;
            dataGridView1.Columns[10].Width = 100;
            dataGridView1.Columns[11].Width = 200;

            //各列の文字位置の指定
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

        private void invcnt()
        {
            HaID.Visible = false;
            MaID.Visible = false;
            EmID.Visible = false;
            HaDate.Visible = false;
            HaHidden.Visible = false;
        }
    }
}




