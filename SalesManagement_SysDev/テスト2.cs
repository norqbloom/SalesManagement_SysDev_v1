using System;
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
    public partial class テスト2 : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        OrderDateAccess orderDateAccess = new OrderDateAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        private static List<M_Product> products;

        private string _OrID;
        public テスト2(string OrID)
        {
            InitializeComponent();
            _OrID = OrID;
        }

        private void テスト2_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            textBoxOrID2.Text = _OrID;
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].HeaderText = "受注ID";
            dataGridView1.Columns[1].HeaderText = "商品ID商品";
            dataGridView1.Columns[2].HeaderText = "数量";
            dataGridView1.Columns[3].HeaderText = "合計金額";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var regOrderDetail = GenerateDataAtRegistration_Detail();

            RegistrationOrderDetail(regOrderDetail);

            //Formのデータグリッドビュー
            SetFormDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBoxOrID2.Text.Trim(), textBoxPrID.Text.Trim(), textBoxOrQuantity.Text.Trim(), textBoxOrTotalPrice.Text.Trim());
        }

        private void dataGridViewDspProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPrID.Text = dataGridViewDspProduct.CurrentRow.Cells[0].Value.ToString();
            textBoxPrName.Text = dataGridViewDspProduct.CurrentRow.Cells[2].Value.ToString();
            textBoxOrQuantity.Text = "";
            textBoxOrTotalPrice.Text = "";
        }

        private void textBoxQuality_TextChanged(object sender, EventArgs e)
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

        private void ClearInput()
        {
            textBoxOrID2.Text = "";
            textBoxPrID.Text = "";
            textBoxPrName.Text = "";
            textBoxOrQuantity.Text = "";
            textBoxOrTotalPrice.Text = "";
        }

        private T_OrderDetail GenerateDataAtRegistration_Detail()
        {
            var list = (from row in dataGridView1.Rows.Cast<DataGridViewRow>()
                        from cell in row.Cells.Cast<DataGridViewCell>()
                        select new
                        {
                            //project into your new class from the row and cell vars.
                        }).ToList();

            return new T_OrderDetail
            {
                OrID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                PrID = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()),
                OrQuantity = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()),
                OrTotalPrice = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString())
            };
        }

        private void RegistrationOrderDetail(T_OrderDetail regOrderDetail)
        {
            bool flg = orderDateAccess.AddorderdetailData(regOrderDetail);
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
            textBoxOrID2.Focus();
            ClearInput();
        }

        private void SetFormDataGridView()
        {
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "20";
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            //読み取り専用に指定
            dataGridViewDspProduct.ReadOnly = true;
            //行内をクリックすることで行を選択
            dataGridViewDspProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridViewDspOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー位置の指定
            dataGridViewDspProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            products = productDataAccess.GetProductDataDsp(radioint);
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDspProduct.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();
            dataGridViewDspProduct.Refresh();

            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";

            dataGridViewDspProduct.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();

            foreach (DataGridViewColumn clm in dataGridViewDspProduct.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //各列幅の指定
            dataGridViewDspProduct.Columns[0].Width = 100;
            dataGridViewDspProduct.Columns[1].Width = 100;
            dataGridViewDspProduct.Columns[2].Width = 100;
            dataGridViewDspProduct.Columns[3].Width = 100;
            dataGridViewDspProduct.Columns[4].Width = 100;
            dataGridViewDspProduct.Columns[5].Width = 100;
            dataGridViewDspProduct.Columns[6].Width = 100;
            dataGridViewDspProduct.Columns[7].Width = 100;
            dataGridViewDspProduct.Columns[8].Width = 100;
            dataGridViewDspProduct.Columns[9].Width = 100;
            dataGridViewDspProduct.Columns[10].Width = 100;
            dataGridViewDspProduct.Columns[11].Width = 100;

            //各列の文字位置の指定
            dataGridViewDspProduct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewの総ページ数
            //labelPage.Text = "/" + ((int)Math.Ceiling(orders.Count / (double)pageSize)) + "ページ";
        }

        
    }
}
