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
        OrderDetailDataAccess orderDetailDataAccess = new OrderDetailDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        private static List<T_OrderDetail> orderDetails;

        private string _OrID;
        public テスト2(string OrID)
        {
            InitializeComponent();
            _OrID = OrID;
        }

        private void テスト2_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            textBoxOrID.Text = _OrID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var regOrderDetail = GenerateDataAtRegistration_Detail();

            RegistrationOrderDetail(regOrderDetail);

            //Formのデータグリッドビュー
            SetFormDataGridView();
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
            textBoxOrID.Text = "";
            textBoxPrID.Text = "";
            textBoxPrName.Text = "";
            textBoxOrQuantity.Text = "";
            textBoxOrTotalPrice.Text = "";
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
            orderDetails = orderDetailDataAccess.GetOrderDetailDataDsp(radioint);
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDspProduct.DataSource = orderDetails.Skip(pageSize * pageNo).Take(pageSize).ToList();
            dataGridViewDspProduct.Refresh();

            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";

            dataGridViewDspProduct.DataSource = orderDetails.Skip(pageSize * pageNo).Take(pageSize).ToList();

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

            //各列の文字位置の指定
            dataGridViewDspProduct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDspProduct.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewの総ページ数
            //labelPage.Text = "/" + ((int)Math.Ceiling(orders.Count / (double)pageSize)) + "ページ";
        }

        
    }
}
