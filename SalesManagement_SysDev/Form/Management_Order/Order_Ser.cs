using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Order
{
    public partial class Order_Ser : Form
    {
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        MessageDsp messageDsp = new MessageDsp();
        private static List<OrHistory> Orhistory;
        OrderDateAccess orderdateAccess = new OrderDateAccess();
        private static List<T_Order> orders;
        private static List<T_OrderDsp> Or1;
        private static int grid = 10;

        public Order_Ser()
        {
            InitializeComponent();
        }

        private void invcnt()
        {
            //labelOr.Visible = false;
            //labelSo.Visible = false;
            //labelEm.Visible = false;
            //labelCl.Visible = false;
            //datetime.Visible = false;
            //userid.Visible = false;
            //username.Visible = false;
            //uptime.Visible = false;
            //upuserid.Visible = false;
            //upusername.Visible = false;
        }
        private void incntok()
        {
            //labelOr.Visible = true;
            //labelSo.Visible = true;
            //labelEm.Visible = true;
            //labelCl.Visible = true;
            //datetime.Visible = true;
            //userid.Visible = true;
            //username.Visible = true;
            //uptime.Visible = true;
            //upuserid.Visible = true;
            //upusername.Visible = true;
        }

        private void Order_Ser_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            invcnt();
            dataGridViewDsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button_Ser_Click(object sender, EventArgs e)
        {
            if (!GetClientDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }

        private void button_Cle_Click(object sender, EventArgs e)
        {

        }

        private void button_First_Click(object sender, EventArgs e)
        {

        }

        private void button_Prev_Click(object sender, EventArgs e)
        {

        }

        private void button_Next_Click(object sender, EventArgs e)
        {

        }

        private void button_Last_Click(object sender, EventArgs e)
        {

        }

        private bool GetClientDataAtSelect()
        {
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxOrID.Focus();
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
            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            return true;
        }
        private void GenerateDataAtSelect()
        {
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //全部
                            datefull();
                            return;
                        }
                        else
                        {
                            //OrID,SoID,EmID
                            dateorsoem();
                            return;
                        }
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //OrID,SoID,ClID
                            dateorsocl();
                            return;
                        }
                        else
                        {
                            //OrID,SoID
                            dateorso();
                            return;
                        }
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //OrID,EmID,ClID
                            dateoremcl();
                            return;
                        }
                        else
                        {
                            //OrID,EmID
                            dateorem();
                            return;
                        }
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //OrID,ClID
                            dateorcl();
                            return;
                        }
                        else
                        {
                            //OrID
                            dateor();
                            return;
                        }

                    }
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //SoID,EmID,ClID
                            datesoemcl();
                            return;
                        }
                        else
                        {
                            //SoID,Emid
                            dateemso();
                            return;
                        }
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //SoID.ClID
                            datesocl();
                            return;
                        }
                        else
                        {
                            //SoID
                            dateso();
                            return;
                        }
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //EmID,ClID
                            dateemcl();
                        }
                        else
                        {
                            //EmID
                            dateem();
                            return;
                        }

                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //ClID
                            datecl();
                            return;
                        }
                        else
                        {
                            //何もなし
                            dateNo();
                            return;
                        }
                    }

                }

            }
        }

        private void SetSelectData()
        {
            dataGridViewDsp.DataSource = orders;
        }

        private void datefull()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getfull(selectCondition);
        }
        private void dateorsoem()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getorsoem(selectCondition);

        }
        private void dateorso()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getorso(selectCondition);
        }
        private void dateor()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getor(selectCondition);
        }
        private void dateNo()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.GetNo(selectCondition);
        }
        private void dateorsocl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getorsocl(selectCondition);
        }
        private void dateorem()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getorem(selectCondition);
        }
        private void dateorcl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getorcl(selectCondition);
        }
        private void dateoremcl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getoremcl(selectCondition);
        }
        private void datesoemcl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getsoemcl(selectCondition);
        }
        private void datesocl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getsocl(selectCondition);
        }
        private void dateemcl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getemcl(selectCondition);

        }
        private void datecl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getcl(selectCondition);
        }
        private void dateem()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getem(selectCondition);
        }
        private void dateso()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getso(selectCondition);
        }
        private void dateemso()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
            };
            orders = orderdateAccess.Getemso(selectCondition);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////
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
            //if (radioButton1.Checked == true)
            //{
            //    radioint = 2;
            //}
            //else
            //{
            //    radioint = 0;
            //}
            // 商品データの取得
            Or1 = orderdateAccess.GetProductData2(radioint);

            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Or1.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            labelPage.Text = "/" + ((int)Math.Ceiling(Or1.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();

        }

        private void dataGridViewDspOrder_SelectionChanged(object sender, EventArgs e)
        {
            int number;
            int OrIDtxt;
            OrIDtxt = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            number = (int)dataGridViewDsp.CurrentRow.Cells[1].Value;
            //labelOr.Text = textBoxOrID.ToString();
            serchdateset(number);
            setdatedetail();
        }

        private void serchdateset(int number)
        {

            OrHistory selectCondition = new OrHistory
            {
                OrID = number.ToString(),

            };
            Orhistory = orderdateAccess.getdetail(selectCondition);
        }
        private void setdatedetail()
        {
            var x = Orhistory.FirstOrDefault();
            if (x == null)
            {
                invcnt();
                return;
            }

            //labelOr.Text = x.OrID;
            //labelSo.Text = x.SoID;
            //labelEm.Text = x.EmID;
            //labelCl.Text = x.ClID;
            //datetime.Text = x.RegisteredDate;
            //userid.Text = x.regUserID;
            //username.Text = x.regUserName;
            //uptime.Text = x.UpDateTime;
            //upuserid.Text = x.LastupdatedUserID;
            //upusername.Text = x.LastupdatedUserName;
            incntok();


        }
    }
}
