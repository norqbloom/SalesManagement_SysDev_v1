﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class テスト : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        OrderDateAccess orderDateAccess = new OrderDateAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        private static List<T_Order> orders;
        private static List<M_Product> products;
        public テスト()
        {
            InitializeComponent();
        }
        private void テスト_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            dateTimePickerOrDate.Value = DateTime.Now;
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (!GetValidDataAtRegistration())
            {
                return;
            }

            var regOrder = GenerateDataAtRegistration();
            var regOrderDetail = GenerateDataAtRegistration_Detail();

            RegistrationOrder(regOrder);
            RegistrationOrderDetail(regOrderDetail);

            //Formのデータグリッドビュー
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

            Confirm_OpenForm();
        }

        private void button_Cle_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void button_Con_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void textBoxOrQuantity_TextChanged(object sender, EventArgs e)
        {
            int Price = 0;
            string Quantity = textBoxOrQuantity.Text.Trim();
            int PriceTotal = 0;

            if (Quantity != "")
            {
                Price = int.Parse(dataGridViewDspProduct.CurrentRow.Cells[3].Value.ToString());
                PriceTotal = Price * int.Parse(textBoxOrQuantity.Text.Trim());
                textBoxOrTotalPrice.Text = PriceTotal.ToString();
            }
            else
            {
                return;
            }
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
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
            if ((int)dataGridViewDspOrder.CurrentRow.Cells[7].Value == 0)
            {
                checkBoxOrFlag.Checked = false;
            }
            else
            {
                checkBoxOrFlag.Checked = true;
            }
            //非表示理由の状態を判断
            if (dataGridViewDspOrder.CurrentRow.Cells[8].Value == null)
            {
                textBoxOrHidden.Text = String.Empty;
            }
            else
            {
                textBoxOrHidden.Text = dataGridViewDspOrder.CurrentRow.Cells[8].Value.ToString();
            }
        }
        private void dataGridViewDspProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //データグリッドビューからクリックされたデータを各入力エリアへ
            textBoxPrID.Text = dataGridViewDspProduct.CurrentRow.Cells[0].Value.ToString();
            textBoxPrName.Text = dataGridViewDspProduct.CurrentRow.Cells[2].Value.ToString();
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
            checkBoxOrFlag.Checked = false;
            textBoxOrHidden.Text = "";
        }

        //Add
        private bool GetValidDataAtRegistration()
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

                if(textBoxOrID.TextLength > 6)
                {
                    MessageBox.Show("2");
                    //messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }

                if (orderDateAccess.CheckOrIDExistence(textBoxOrID.Text.Trim()))
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

            if(checkBoxOrStateFlag.CheckState == CheckState.Indeterminate)
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
            if(checkBoxOrFlag.Checked == true)
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

        private void RegistrationOrder(T_Order regOrder)
        {
            DialogResult result = MessageBox.Show("追加しますか");
            //DialogResult result = messageDsp.DspMsg("");
            if(result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = orderDateAccess.AddorderData(regOrder);
        }

        private void RegistrationOrderDetail (T_OrderDetail regOrderDetail)
        {
            bool flg = orderDateAccess.AddorderdetailData(regOrderDetail);
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
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "20";
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            //読み取り専用に指定
            dataGridViewDspOrder.ReadOnly = true;
            dataGridViewDspProduct.ReadOnly = true;
            //行内をクリックすることで行を選択
            dataGridViewDspOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDspProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridViewDspOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー位置の指定
            dataGridViewDspOrder.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            int radioint = 0;
            int radioint2 = 0;
            if(radioButton1.Checked == true)
            {
                radioint = 2;
            }
            else
            {
                radioint = 0;
            }
            orders = orderDateAccess.GetOrderDataDsp(radioint);
            products = productDataAccess.GetProductDataDsp(radioint);
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDspOrder.DataSource = orders.Skip(pageSize * pageNo).Take(pageSize).ToList();
            dataGridViewDspProduct.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();
            dataGridViewDspOrder.Refresh();
            dataGridViewDspProduct.Refresh();
            
            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";
            
            dataGridViewDspOrder.DataSource = orders.Skip(pageSize * pageNo).Take(pageSize).ToList();
            dataGridViewDspProduct.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();
            
            foreach (DataGridViewColumn clm in dataGridViewDspOrder.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn clm in dataGridViewDspProduct.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //各列幅の指定
            dataGridViewDspOrder.Columns[0].Width = 100;
            dataGridViewDspOrder.Columns[1].Width = 100;
            dataGridViewDspOrder.Columns[2].Width = 100;
            dataGridViewDspOrder.Columns[3].Width = 100;
            dataGridViewDspOrder.Columns[4].Width = 100;
            dataGridViewDspOrder.Columns[5].Width = 100;
            dataGridViewDspOrder.Columns[6].Width = 100;
            dataGridViewDspOrder.Columns[7].Width = 100;
            dataGridViewDspOrder.Columns[8].Width = 100;

            dataGridViewDspProduct.Columns[0].Width = 100;
            dataGridViewDspProduct.Columns[1].Visible = false;
            dataGridViewDspProduct.Columns[2].Width = 100;
            dataGridViewDspProduct.Columns[3].Width = 100;
            dataGridViewDspProduct.Columns[4].Visible = false;
            dataGridViewDspProduct.Columns[5].Width = 100;
            dataGridViewDspProduct.Columns[6].Visible = false;
            dataGridViewDspProduct.Columns[7].Visible = false;
            dataGridViewDspProduct.Columns[8].Visible = false;
            dataGridViewDspProduct.Columns[9].Visible = false;
            dataGridViewDspProduct.Columns[10].Visible = false;
            dataGridViewDspProduct.Columns[11].Visible = false;

            //各列の文字位置の指定
            dataGridViewDspOrder.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspOrder.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspOrder.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspOrder.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspOrder.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspOrder.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspOrder.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspOrder.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspOrder.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dataGridViewDspProduct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewの総ページ数
            labelPage.Text = "/" + ((int)Math.Ceiling(orders.Count / (double)pageSize)) + "ページ";
        }

        private void Confirm_OpenForm()
        {
            Form form = new テスト2();
            form.Show();

            textBoxOrID.Text.Trim();
        }

        
    }
}
