using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Product
{
    public partial class Product_Ser : Form
    {
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        MessageDsp messageDsp = new MessageDsp();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        private static List<M_Product> products;
        private static List<M_clhistory> history;


        public Product_Ser()
        {
            InitializeComponent();
        }
        private void invcnt()
        {
            label5.Visible = false;
            IDtxt.Visible = false;
            datetime.Visible = false;
            userid.Visible = false;
            username.Visible = false;
            uptime.Visible = false;
            upuserid.Visible = false;
            upusername.Visible = false;
        }
        private void incntok()
        {
            label5.Visible = true;
            IDtxt.Visible = true;
            datetime.Visible = true;
            userid.Visible = true;
            username.Visible = true;
            uptime.Visible = true;
            upuserid.Visible = true;
            upusername.Visible = true;
        }

        private void Product_Ser_Load(object sender, EventArgs e)
        {
            invcnt();
        }

        private void ButtonSer_Click(object sender, EventArgs e)
        {
            //入力データ確認
            if (!GetClientDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }
        private bool GetClientDataAtSelect()
        {
            //PrID確認
            if (!String.IsNullOrEmpty(textBoxPrID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxPrID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxPrID.Focus();
                    return false;
                }
            }
            //MaID確認
            if (!String.IsNullOrEmpty(textBoxMaID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxMaID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1005");
                    textBoxMaID.Focus();
                    return false;
                }
            }
            ////Clphone確認
            //if (!String.IsNullOrEmpty(ClPhonetxt.Text.Trim()))
            //{
            //    if (!dataInputFormCheck.CheckHalfChar(ClPhonetxt.Text.Trim()))
            //    {
            //        messageDsp.DspMsg("M1015");
            //        ClPhonetxt.Focus();
            //        return false;

            //    }

            //}
            return true;
        }

        private void GenerateDataAtSelect()
        {
            if (!String.IsNullOrEmpty(textBoxMaID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(textBoxMaID.Text.Trim()))
                {
                    datedubblwget();
                }
                else
                {
                    dateClget();
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(textBoxMaID.Text.Trim()))
                {
                    dateSoget();
                }
                else
                {
                    datenolwget();
                }

            }

        }
        private void SetSelectData()
        {
            dataGridViewDsp.DataSource = products;
        }
        private void dateClget()
        {
            M_Product selectCondition = new M_Product()
            {
                PrID = int.Parse(textBoxPrID.Text.Trim()),
                PrName = textBoxPrName.Text.Trim(),
                
            };
            products = productDataAccess.GetProductData(selectCondition);

        }
        private void dateSoget()
        {
            M_Product selectCondition = new M_Product()
            {
                PrID = int.Parse(textBoxPrID.Text.Trim()),
                PrName = textBoxPrName.Text.Trim(),
               
            };
            products = productDataAccess.GetProductData(selectCondition);

        }
        private void datedubblwget()
        {
            M_Product selectCondition = new M_Product()
            {
                PrID = int.Parse(textBoxPrID.Text.Trim()),
                MaID = int.Parse(textBoxMaID.Text.Trim()),
                PrName = textBoxPrName.Text.Trim(),
            };
            products = productDataAccess.Getdubblwdata(selectCondition);

        }
        private void datenolwget()
        {
            M_Product selectCondition = new M_Product()
            {
                PrName = textBoxPrID.Text.Trim()
            };
            products = productDataAccess.Getnodata(selectCondition);

        }
        private void SetFormDataGridView()
        {
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDsp.ReadOnly = true;
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "10";
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SetDataGridView();

        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDsp.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        //ここから右側↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int number;
            int ClIDtxt;
            number = (int)dataGridViewDsp.CurrentRow.Cells[1].Value;
            ClIDtxt = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            label5.Text = ClIDtxt.ToString();

            serchdateset(number);
            setdatedetail();
        }

        private void serchdateset(int number)
        {

            M_clhistory selectCondition = new M_clhistory
            {
                ClID = number.ToString(),

            };
            history = clientDataAccess.getdetail(selectCondition);
        }
        private void setdatedetail()
        {
            var x = history.FirstOrDefault();
            if (x == null)
            {
                invcnt();
                return;
            }

            IDtxt.Text = x.ClID;
            datetime.Text = x.RegisteredDate;
            userid.Text = x.regUserID;
            username.Text = x.regUserName;
            uptime.Text = x.UpDateTime;
            upuserid.Text = x.LastupdatedUserID;
            upusername.Text = x.LastupdatedUserName;
            incntok();


        }
        private void label9_Click(object sender, EventArgs e)
        {
            /*
            ClIDtxt.Visible = false;
            datetime.Visible = false;
            userid.Visible = false;
            username.Visible = false;
            uptime.Visible = false;
            upuserid.Visible = false;
            upusername.Visible = false;
             */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}