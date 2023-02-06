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
    public partial class Order : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        OrderDateAccess orderDateAccess = new OrderDateAccess();
        OrderDetailDataAccess orderDetailDataAccess = new OrderDetailDataAccess();
        ChumonDataAccess chumonDataAccess = new ChumonDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        private static List<M_Product> products;
        private static List<T_Order> orders;
        private static List<T_OrderDetail> orderDetails;
        private static int grid_OrID = 0;
        private static int grid = 1;
        private static int grid_OrFlg = 0;

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            dateTimePickerOrDate.Value = DateTime.Now;
            var context = new SalesManagement_DevContext();
            var a = context.T_Orders.Count();
            int countplus = a + 1;
            textBoxOrID.Text = countplus.ToString();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (!GetValidDataAtRegistration())
            {
                return;
            }

            var regOrder = GenerateDataAtRegistration();
            RegistrationOrder(regOrder);
            //Formのデータグリッドビュー
            SetFormDataGridView();
        }

        private void button_Add_Pro_Click(object sender, EventArgs e)
        {
            var regOrderDetail = GenerateDataAtRegistration_Detail();

            RegistrationOrderDetail(regOrderDetail);

            SetFormDataGridView();
        }

        private void button_Con_Click(object sender, EventArgs e)
        {
            if (!GetValidDataUpdate())
            {
                return;
            }

            //受注T更新
            var updProduct = GenerateDataAtUpdate();
            UpdateProduct(updProduct);

            //注文T登録
            var regChumon = GenerateDataAtRegistrationChumon();
            RegistrationChumon(regChumon);

            //注文詳細T登録
            if (GenerateDataAtRegistrationChumonDetail())
            {
                return;
            }

            SetFormDataGridView();

        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (!GetValidDataDelete())
            {
                return;
            }

            var delOrder = GenerateDataAtDelete();

            DeleteOrder(delOrder);

            SetFormDataGridView();
        }

        private void button_Cle_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void button_hide_nonhide_Click(object sender, EventArgs e)
        {
            if (button_hide_nonhide.Text == "表示")
            {
                button_hide_nonhide.Text = "非表示";
                grid_OrFlg = 2;
                orders = orderDateAccess.GetOrderDataDsp(grid_OrFlg);
                SetDataGridView();
            }
            else
            {
                button_hide_nonhide.Text = "表示";
                grid_OrFlg = 0;
                orders = orderDateAccess.GetOrderDataDsp(grid_OrFlg);
                SetDataGridView();
            }
        }

        private void button_hide_nonhide_con_Click(object sender, EventArgs e)
        {
            if (button_hide_nonhide_con.Text == "確定済")
            {
                button_hide_nonhide_con.Text = "未確定";
                //grid_OrFlg = 2;
                //orders = orderDateAccess.GetOrderDataDsp(grid_OrFlg, 0);
                int grid_StateFlg = 1;
                int grid_Orflg = 0;
                orders = orderDateAccess.GetOrderDataDsp_kakutei(grid_StateFlg,grid_Orflg);
                SetDataGridView();
            }
            else
            {
                button_hide_nonhide_con.Text = "確定済";
                //grid_OrFlg = 0;
                //orders = orderDateAccess.GetOrderDataDsp(grid_OrFlg, 0);
                int grid_StateFlg = 0;
                int grid_Orflg = 0;
                orders = orderDateAccess.GetOrderDataDsp_kakutei(grid_StateFlg, grid_Orflg);
                SetDataGridView();
            }
        }

        private void button_First_Order_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            dataGridViewDspOrder.DataSource = orders.Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDspOrder.Refresh();
            //ページ番号の設定
            textBoxPageNo_Order.Text = "1";
        }

        private void button_Prev_Order_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridViewDspOrder.DataSource = orders.Skip(pageSize * pageNo).Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDspOrder.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                textBoxPageNo_Order.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo_Order.Text = "1";
        }

        private void button_Next_Order_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo_Order.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(orders.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDspOrder.DataSource = orders.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDspOrder.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(orders.Count / (double)pageSize);
            if (pageNo >= lastPage)
                textBoxPageNo_Order.Text = lastPage.ToString();
            else
                textBoxPageNo_Order.Text = (pageNo + 1).ToString();
        }

        private void button_Last_Order_Click(object sender, EventArgs e)
        {
            int pageSize = grid;
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(orders.Count / (double)pageSize) - 1;
            dataGridViewDspOrder.DataSource = orders.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDspOrder.Refresh();
            //ページ番号の設定
            textBoxPageNo_Order.Text = (pageNo + 1).ToString();
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

        private void dataGridViewDspOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //データグリッドビューからクリックされたデータを各入力エリアへ
            textBoxOrID.Text = dataGridViewDspOrder.CurrentRow.Cells[0].Value.ToString();
            textBoxSoID.Text = dataGridViewDspOrder.CurrentRow.Cells[1].Value.ToString();
            textBoxEmID.Text = dataGridViewDspOrder.CurrentRow.Cells[2].Value.ToString();
            textBoxClID.Text = dataGridViewDspOrder.CurrentRow.Cells[3].Value.ToString();
            textBoxClChange.Text = dataGridViewDspOrder.CurrentRow.Cells[4].Value.ToString();
            dateTimePickerOrDate.Text = dataGridViewDspOrder.CurrentRow.Cells[5].Value.ToString();
            textBoxOrHidden.Text = dataGridViewDspOrder.CurrentRow.Cells[6].Value.ToString();
            //チェックボックスの状態を判断
            if ((int)dataGridViewDspOrder.CurrentRow.Cells[6].Value == 0)
            {
                checkBoxOrStateFlag.Checked = false;
            }
            else
            {
                checkBoxOrStateFlag.Checked = true;
            }
            //if ((int)dataGridViewDspOrder.CurrentRow.Cells[7].Value == 0)
            //{
            //    checkBoxOrFlag.Checked = false;
            //}
            //else
            //{
            //    checkBoxOrFlag.Checked = true;
            //}
            //非表示理由の状態を判断
            if (dataGridViewDspOrder.CurrentRow.Cells[8].Value == null)
            {
                textBoxOrHidden.Text = String.Empty;
            }
            else
            {
                textBoxOrHidden.Text = dataGridViewDspOrder.CurrentRow.Cells[8].Value.ToString();
            }


            grid_OrID = (int)dataGridViewDspOrder.CurrentRow.Cells[0].Value;

            orderDetails = orderDetailDataAccess.GetOrderDetailDataOrID(grid_OrID);
            GetDataGridView2();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDspProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPrID.Text = dataGridViewDspProduct.CurrentRow.Cells[0].Value.ToString();
            textBoxPrName.Text = dataGridViewDspProduct.CurrentRow.Cells[2].Value.ToString();
            textBoxPrice.Text = dataGridViewDspProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBoxOrQuantity_TextChanged(object sender, EventArgs e)
        {
            int Price = int.Parse(textBoxPrice.Text.Trim());
            string str_Quantity = textBoxOrQuantity.Text.Trim();
            int PriceTotal;

            if (str_Quantity != "")
            {
                PriceTotal = Price * int.Parse(textBoxOrQuantity.Text.Trim());
                textBoxOrTotalPrice.Text = PriceTotal.ToString();
            }
            else
            {
                return;
            }
        }

        private void textBoxPrID_TextChanged(object sender, EventArgs e)
        {
            int SuPrID;
            if (!String.IsNullOrEmpty(textBoxPrID.Text.Trim()))
            {
                SuPrID = int.Parse(textBoxPrID.Text.Trim());
            }
            else
            {
                SuPrID = -1;
            }

            M_Product selectCondition = new M_Product()
            {
                PrID = SuPrID
            };
            products = productDataAccess.GetProductIDData(selectCondition);
            var x = products.FirstOrDefault();
            if (x == null)
            {
                //invcnt();
                return;
            }
            textBoxPrName.Text = x.PrName;
            textBoxPrice.Text = x.Price.ToString();
        }

        private void ClearInput()
        {
            textBoxOrID.Text = "";
            textBoxSoID.Text = "";
            textBoxEmID.Text = "";
            textBoxClID.Text = "";
            textBoxClChange.Text = "";
            dateTimePickerOrDate.Value = DateTime.Now;
            checkBoxOrStateFlag.Checked = false;
            //checkBoxOrFlag.Checked = false;
            textBoxOrHidden.Text = "";

            textBoxPrID.Text = "";
            textBoxPrName.Text = "";
            textBoxOrQuantity.Text = "";
            textBoxPrice.Text = "";
            textBoxOrTotalPrice.Text = "";
        }

        private bool GetValidDataAtRegistration()
        {
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    messageDsp.DspMsg("M4023");
                    textBoxOrID.Focus();
                    return false;
                }

                if (textBoxOrID.TextLength > 6)
                {
                    messageDsp.DspMsg("M4022");
                    textBoxOrID.Focus();
                    return false;
                }

                if (orderDateAccess.CheckOrIDExistence(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("Existence");
                    //messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M4024");
                textBoxOrID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1005");
                    textBoxSoID.Focus();
                    return false;
                }

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

            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    messageDsp.DspMsg("M6001");
                    textBoxEmID.Focus();
                    return false;
                }

                if (textBoxEmID.TextLength > 6)
                {
                    MessageBox.Show("M6002");
                    //messageDsp.DspMsg("");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("M6004");
                //messageDsp.DspMsg("");
                textBoxEmID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    MessageBox.Show("M1001");
                    //messageDsp.DspMsg("");
                    textBoxClID.Focus();
                    return false;
                }

                if (textBoxClID.TextLength > 6)
                {
                    MessageBox.Show("M1002");
                    //messageDsp.DspMsg("");
                    textBoxClID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("M1004");
                //messageDsp.DspMsg("");
                textBoxClID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxClChange.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckFullWidth(textBoxClChange.Text.Trim()))
                {
                    MessageBox.Show("14");
                    //messageDsp.DspMsg("");
                    textBoxClChange.Focus();
                    return false;
                }

                if (textBoxClChange.TextLength > 50)
                {
                    MessageBox.Show("15");
                    //messageDsp.DspMsg("");
                    textBoxClChange.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("16");
                //messageDsp.DspMsg("");
                textBoxClChange.Focus();
                return false;
            }

            if (checkBoxOrStateFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("17");
                //messageDsp.DspMsg("");
                checkBoxOrStateFlag.Focus();
                return false;
            }

            if (checkBoxOrFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("18");
                //messageDsp.DspMsg("");
                checkBoxOrFlag.Focus();
                return false;
            }

            if (checkBoxOrFlag.Checked == true)
            {
                if (!String.IsNullOrEmpty(textBoxOrHidden.Text.Trim()))
                {
                    MessageBox.Show("19");
                    //messageDsp.DspMsg("");
                    checkBoxOrFlag.Focus();
                    return false;
                }
            }
            return true;
        }

        private T_Order GenerateDataAtRegistration()
        {
            int checkFlg;
            string hidden;
            if (checkBoxOrFlag.Checked == true)
            {
                checkFlg = 2;
            }
            else
            {
                checkFlg = 0;
            }

            if (checkFlg == 0)
            {
                hidden = String.Empty;
            }
            else
            {
                hidden = textBoxOrHidden.Text.Trim();
            }
            return new T_Order
            {
                OrID = 0,
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
                OrStateFlag = 0,
                OrFlag = checkFlg,
                OrHidden = hidden
            };
        }

        private T_OrderDetail GenerateDataAtRegistration_Detail()
        {
            return new T_OrderDetail
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                PrID = int.Parse(textBoxPrID.Text.Trim()),
                OrQuantity = int.Parse(textBoxOrQuantity.Text.Trim()),
                OrTotalPrice = int.Parse(textBoxOrTotalPrice.Text.Trim())
            };
        }

        private T_Chumon GenerateDataAtRegistrationChumon()
        {
            int checkFlg;
            string hidden;
            if (checkBoxOrFlag.Checked == true)
            {
                checkFlg = 2;
            }
            else
            {
                checkFlg = 0;
            }

            if (checkFlg == 0)
            {
                hidden = String.Empty;
            }
            else
            {
                hidden = textBoxOrHidden.Text.Trim();
            }

            return new T_Chumon
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = null,
                ClID = int.Parse(textBoxClID.Text.Trim()),
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ChDate = DateTime.Now,
                ChStateFlag = 0,
                ChFlag = checkFlg,
                ChHidden = hidden
            };
        }

        private bool GenerateDataAtRegistrationChumonDetail()
        {
            int a;
            int b;
            int a1;
            var context = new SalesManagement_DevContext();
            var c = context.T_OrderDetails.First(x => x.OrID.ToString() == textBoxOrID.Text);
            var d = context.T_OrderDetails.Count();
            for (int i = 1; i <= d; i++)
            {
                c = context.T_OrderDetails.SingleOrDefault(x => x.OrID.ToString() == textBoxOrID.Text && x.OrDetailID == i);
                if (!(c == null))
                {
                    a = c.PrID;
                    b = c.OrQuantity;
                    var xx = context.T_Chumons.First(x => x.OrID.ToString() == textBoxOrID.Text);
                    a1 = xx.ChID;
                    T_ChumonDetail e = new T_ChumonDetail
                    {
                        ChDetailID = 0,
                        ChID = a1,
                        PrID = a,
                        ChQuantity = b
                    };
                    context.T_ChumonDetails.Add(e);
                }
            }
            context.SaveChanges();
            context.Dispose();
            MessageBox.Show("OK");
            return true;
        }

        private void RegistrationOrder(T_Order regOrder)
        {
            bool flg = orderDateAccess.AddorderData(regOrder);
            DialogResult result = messageDsp.DspMsg("M4025");
            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (flg == true)
            {
                messageDsp.DspMsg("M4026");
            }
            else
            {
                messageDsp.DspMsg("M4027");
            }
            textBoxOrID.Focus();
        }

        private void RegistrationOrderDetail(T_OrderDetail regOrderDetail)
        {
            bool flg = orderDateAccess.AddorderdetailData(regOrderDetail);
            DialogResult result = MessageBox.Show("追加しますか(詳細)");
            //DialogResult result = messageDsp.DspMsg("");
            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (flg == true)
            {
                MessageBox.Show("追加しました");
                //messageDsp.DspMsg("");
            }
            else
            {
                MessageBox.Show("追加できませんでした");
                //messageDsp.DspMsg("");
            }
            textBoxOrID.Focus();
            ClearInput();
        }

        private void RegistrationChumon(T_Chumon regChumon)
        {
            bool flg = chumonDataAccess.AddchumonData(regChumon);
            DialogResult result = MessageBox.Show("追加しますか");
            //DialogResult result = messageDsp.DspMsg("");
            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (flg == true)
            {
                MessageBox.Show("追加しました");
                //messageDsp.DspMsg("");
            }
            else
            {
                MessageBox.Show("追加できませんでした");
                //messageDsp.DspMsg("");
            }
            textBoxOrID.Focus();
        }

        //Delete
        private bool GetValidDataDelete()
        {
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("1");
                    //messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }

                if (textBoxOrID.TextLength > 6)
                {
                    MessageBox.Show("2");
                    //messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }

                if (!orderDateAccess.CheckOrIDExistence(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("3");
                    //messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("4");
                //messageDsp.DspMsg("");
                textBoxOrID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    MessageBox.Show("5");
                    //messageDsp.DspMsg("");
                    textBoxSoID.Focus();
                    return false;
                }

                if (textBoxSoID.TextLength > 2)
                {
                    MessageBox.Show("6");
                    //messageDsp.DspMsg("");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("7");
                //messageDsp.DspMsg("");
                textBoxSoID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    MessageBox.Show("8");
                    //messageDsp.DspMsg("");
                    textBoxEmID.Focus();
                    return false;
                }

                if (textBoxEmID.TextLength > 6)
                {
                    MessageBox.Show("9");
                    //messageDsp.DspMsg("");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("10");
                //messageDsp.DspMsg("");
                textBoxEmID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    MessageBox.Show("11");
                    //messageDsp.DspMsg("");
                    textBoxClID.Focus();
                    return false;
                }

                if (textBoxClID.TextLength > 6)
                {
                    MessageBox.Show("12");
                    //messageDsp.DspMsg("");
                    textBoxClID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("13");
                //messageDsp.DspMsg("");
                textBoxClID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxClChange.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckFullWidth(textBoxClChange.Text.Trim()))
                {
                    MessageBox.Show("14");
                    //messageDsp.DspMsg("");
                    textBoxClChange.Focus();
                    return false;
                }

                if (textBoxClChange.TextLength > 50)
                {
                    MessageBox.Show("15");
                    //messageDsp.DspMsg("");
                    textBoxClChange.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("16");
                //messageDsp.DspMsg("");
                textBoxClChange.Focus();
                return false;
            }

            if (checkBoxOrStateFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("17");
                //messageDsp.DspMsg("");
                checkBoxOrStateFlag.Focus();
                return false;
            }

            if (checkBoxOrFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("18");
                //messageDsp.DspMsg("");
                checkBoxOrFlag.Focus();
                return false;
            }

            if (checkBoxOrFlag.Checked == true)
            {
                if (String.IsNullOrEmpty(textBoxOrHidden.Text.Trim()))
                {
                    MessageBox.Show("19");
                    //messageDsp.DspMsg("");
                    checkBoxOrFlag.Focus();
                    return false;
                }
            }
            return true;
        }

        private T_Order GenerateDataAtDelete()
        {
            int checkFlg = 2;
            string hidden;
            if (checkFlg == 0)
            {
                hidden = String.Empty;
            }
            else
            {
                hidden = textBoxOrHidden.Text.Trim();
            }
            return new T_Order
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
                OrStateFlag = 0,
                OrFlag = checkFlg,
                OrHidden = hidden
            };
        }

        private void DeleteOrder(T_Order delOrder)
        {
            DialogResult result = MessageBox.Show("削除しますか？");
            //DialogResult result = messageDsp.DspMsg("");
            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = orderDateAccess.DeleteOrderData(delOrder);
            if (flg == true)
            {
                MessageBox.Show("削除しました");
                //messageDsp.DspMsg("");
            }
            else
            {
                MessageBox.Show("削除できませんでした");
                //messageDsp.DspMsg("");
            }
            textBoxOrID.Focus();

            ClearInput();
        }

        private void SetFormDataGridView()
        {
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            //読み取り専用に指定
            dataGridViewDspOrder.ReadOnly = true;
            dataGridViewDsp.ReadOnly = true;
            dataGridViewDspProduct.ReadOnly = true;
            //行内をクリックすることで行を選択
            dataGridViewDspOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDspProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー位置の指定
            dataGridViewDspOrder.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //データグリッドビューのデータ取得
            GetDataGridView();

        }

        private void GetDataGridView()
        {
            orders = orderDateAccess.GetOrderDataDsp(grid_OrFlg);
            orderDetails = orderDetailDataAccess.GetOrderDetailDataDsp(0);
            products = productDataAccess.GetProductDataDsp(grid_OrFlg);
            SetDataGridView();
        }
        private void GetDataGridView2()
        {
            orderDetails = orderDetailDataAccess.GetOrderDetailDataOrID(grid_OrID);
            SetDataGridView2();
        }

        private void SetDataGridView()
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDspOrder.DataSource = orders.Skip(pageSize * pageNo).Take(pageSize).ToList();
            dataGridViewDsp.DataSource = orderDetails.Skip(pageSize * pageNo).Take(pageSize).ToList();
            dataGridViewDspProduct.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();
            dataGridViewDspOrder.Refresh();
            dataGridViewDsp.Refresh();
            dataGridViewDspProduct.Refresh();

            if (pageNo + 1 > 1)
                textBoxPageNo_Order.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo_Order.Text = "1";

            dataGridViewDspOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn clm in dataGridViewDspOrder.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn clm in dataGridViewDsp.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn clm in dataGridViewDspProduct.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //各列幅の指定
            dataGridViewDspOrder.Columns[0].Width = 50;
            dataGridViewDspOrder.Columns[1].Width = 60;
            dataGridViewDspOrder.Columns[2].Width = 50;
            dataGridViewDspOrder.Columns[3].Width = 50;
            dataGridViewDspOrder.Columns[4].Width = 100;
            dataGridViewDspOrder.Columns[5].Width = 100;
            dataGridViewDspOrder.Columns[6].Width = 90;
            dataGridViewDspOrder.Columns[7].Width = 90;

            dataGridViewDspProduct.Columns[1].Visible = false;
            dataGridViewDspProduct.Columns[4].Visible = false;
            dataGridViewDspProduct.Columns[5].Visible = false;
            dataGridViewDspProduct.Columns[6].Visible = false;
            dataGridViewDspProduct.Columns[7].Visible = false;
            dataGridViewDspProduct.Columns[8].Visible = false;
            dataGridViewDspProduct.Columns[9].Visible = false;
            dataGridViewDspProduct.Columns[10].Visible = false;
            dataGridViewDspProduct.Columns[11].Visible = false;

            //dataGridViewの総ページ数
            labelPage_Order.Text = "/" + ((int)Math.Ceiling(orders.Count / (double)pageSize)) + "ページ";
        }
        private void SetDataGridView2()
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = orderDetails.Skip(pageSize * pageNo).Take(pageSize).ToList();
            dataGridViewDsp.Refresh();

            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";

            foreach (DataGridViewColumn clm in dataGridViewDsp.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //dataGridViewの総ページ数
            labelPage.Text = "/" + ((int)Math.Ceiling(orders.Count / (double)pageSize)) + "ページ";
        }


        /// <summary>
        /// T_Orderの更新処理
        /// </summary>
        /// <returns></returns>
        private bool GetValidDataUpdate()
        {
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("1");
                    //messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }

                if (textBoxOrID.TextLength > 6)
                {
                    MessageBox.Show("2");
                    //messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }

                if (!orderDateAccess.CheckOrIDExistence(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("3");
                    //messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("4");
                //messageDsp.DspMsg("");
                textBoxOrID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    MessageBox.Show("5");
                    //messageDsp.DspMsg("");
                    textBoxSoID.Focus();
                    return false;
                }

                if (textBoxSoID.TextLength > 2)
                {
                    MessageBox.Show("6");
                    //messageDsp.DspMsg("");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("7");
                //messageDsp.DspMsg("");
                textBoxSoID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    MessageBox.Show("8");
                    //messageDsp.DspMsg("");
                    textBoxEmID.Focus();
                    return false;
                }

                if (textBoxEmID.TextLength > 6)
                {
                    MessageBox.Show("9");
                    //messageDsp.DspMsg("");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("10");
                //messageDsp.DspMsg("");
                textBoxEmID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    MessageBox.Show("11");
                    //messageDsp.DspMsg("");
                    textBoxClID.Focus();
                    return false;
                }

                if (textBoxClID.TextLength > 6)
                {
                    MessageBox.Show("12");
                    //messageDsp.DspMsg("");
                    textBoxClID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("13");
                //messageDsp.DspMsg("");
                textBoxClID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxClChange.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckFullWidth(textBoxClChange.Text.Trim()))
                {
                    MessageBox.Show("14");
                    //messageDsp.DspMsg("");
                    textBoxClChange.Focus();
                    return false;
                }

                if (textBoxClChange.TextLength > 50)
                {
                    MessageBox.Show("15");
                    //messageDsp.DspMsg("");
                    textBoxClChange.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("16");
                //messageDsp.DspMsg("");
                textBoxClChange.Focus();
                return false;
            }

            if (checkBoxOrStateFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("17");
                //messageDsp.DspMsg("");
                checkBoxOrStateFlag.Focus();
                return false;
            }

            if (checkBoxOrFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("18");
                //messageDsp.DspMsg("");
                checkBoxOrFlag.Focus();
                return false;
            }

            if (checkBoxOrFlag.Checked == true)
            {
                if (!String.IsNullOrEmpty(textBoxOrHidden.Text.Trim()))
                {
                    MessageBox.Show("19");
                    //messageDsp.DspMsg("");
                    checkBoxOrFlag.Focus();
                    return false;
                }
            }
            return true;
        }

        private T_Order GenerateDataAtUpdate()
        {
            int checkFlg;
            string hidden;
            if (checkBoxOrFlag.Checked == true)
            {
                checkFlg = 2;
            }
            else
            {
                checkFlg = 0;
            }

            if (checkFlg == 0)
            {
                hidden = String.Empty;
            }
            else
            {
                hidden = textBoxOrHidden.Text.Trim();
            }

            return new T_Order
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
                OrStateFlag = 1,
                OrFlag = checkFlg,
                OrHidden = hidden
            };
        }

        private void UpdateProduct(T_Order updOrder)
        {
            //更新確認メッセージ
            DialogResult result = messageDsp.DspMsg("M2033");//商品データを更新してよろしいですか？
            if (result == DialogResult.Cancel)
            {
                return;
            }
            //商品情報の更新   
            bool flg = orderDateAccess.UpdateOrdersData(updOrder);
            if (flg == true)
            {
                messageDsp.DspMsg("M2034");//商品データを更新しました
            }
            else
            {
                messageDsp.DspMsg("M2035");//商品データ更新に失敗しました
            }
            textBoxOrID.Focus();
        }      
    }
}
