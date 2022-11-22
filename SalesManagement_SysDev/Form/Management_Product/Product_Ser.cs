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
        private static List<M_Prohistory> history;


        public Product_Ser()
        {
            InitializeComponent();
        }
        private void invcnt()
        {
            label5.Visible = false;
            IDtxt.Visible = false;
            datetime.Visible = false;
            upusername.Visible = false;
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
            upusername.Visible = true;
            username.Visible = true;
            uptime.Visible = true;
            upuserid.Visible = true;
            upusername.Visible = true;
        }

        private void Product_Ser_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            invcnt();
        }

        private void ButtonSer_Click(object sender, EventArgs e)
        {
            //入力データ確認
            if (!GetProductDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }
        private bool GetProductDataAtSelect()
        {
            //商品データの適否
            if (!String.IsNullOrEmpty(textBoxPrID.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(textBoxPrID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2001");//商品IDは半角数字入力です
                    textBoxPrID.Focus();
                    return false;
                }
                //文字数　
                if (textBoxPrID.TextLength > 6)
                {
                    messageDsp.DspMsg("M2002");//商品IDは6文字です
                    textBoxPrID.Focus();
                    return false;
                }
            }
            //メーカIDの適否
            if (!String.IsNullOrEmpty(textBoxMaID.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(textBoxMaID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2005");//メーカIDは半角数字入力です
                    textBoxMaID.Focus();
                    return false;
                }
                //文字数　
                if (textBoxPrID.TextLength != 6)
                {
                    messageDsp.DspMsg("M2006");//メーカIDは4文字です
                    textBoxMaID.Focus();
                    return false;
                }
            }
            //商品名の適否
            if (!String.IsNullOrEmpty(textBoxPrName.Text.Trim()))
            {
                //文字数
                if (textBoxPrName.TextLength > 50)
                {
                    messageDsp.DspMsg("M2010");//商品名は50文字以下です
                    textBoxPrName.Focus();
                    return false;
                }
            }
            //小分類IDの適否
            if (!String.IsNullOrEmpty(textBoxScID.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(textBoxScID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2020");//小分類IDは半角数字入力です
                    textBoxScID.Focus();
                    return false;
                }
                //文字数
                if (textBoxScID.TextLength > 2)
                {
                    messageDsp.DspMsg("M2019");//小分類IDは2文字以下です
                    textBoxScID.Focus();
                    return false;
                }
            }
            //型番の適否
            if (!String.IsNullOrEmpty(textBoxPrModelNumber.Text.Trim()))
            {
                //文字数
                if (textBoxPrModelNumber.TextLength > 20)
                {
                    messageDsp.DspMsg("M2022");//型番は20文字以下です
                    textBoxPrModelNumber.Focus();
                    return false;
                }
            }
            //色の適否
            if (!String.IsNullOrEmpty(textBoxPrColor.Text.Trim()))
            {
                //文字数
                if (textBoxPrColor.TextLength > 20)
                {
                    messageDsp.DspMsg("M2025");//色は20文字以下です
                    textBoxPrColor.Focus();
                    return false;
                }
            }
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
                MaID = int.Parse(textBoxMaID.Text.Trim()),
                PrName = textBoxPrName.Text.Trim(),
                ScID = int.Parse(textBoxScID.Text.Trim()),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(dateTimePickerPrReleaseDate.Text)
                
            };
            products = productDataAccess.GetProductData(selectCondition);

        }
        private void dateSoget()
        {
            M_Product selectCondition = new M_Product()
            {
                PrID = int.Parse(textBoxPrID.Text.Trim()),
                MaID = int.Parse(textBoxMaID.Text.Trim()),
                PrName = textBoxPrName.Text.Trim(),
                ScID = int.Parse(textBoxScID.Text.Trim()),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(dateTimePickerPrReleaseDate.Text)
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
                ScID = int.Parse(textBoxScID.Text.Trim()),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(dateTimePickerPrReleaseDate.Text)
            };
            products = productDataAccess.Getdubblwdata(selectCondition);

        }
        private void datenolwget()
        {
            M_Product selectCondition = new M_Product()
            {
                PrID = int.Parse(textBoxPrID.Text.Trim()),
                MaID = int.Parse(textBoxMaID.Text.Trim()),
                PrName = textBoxPrName.Text.Trim(),
                ScID = int.Parse(textBoxScID.Text.Trim()),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(dateTimePickerPrReleaseDate.Text.Trim())
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

        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();
            labelPage.Text = "/" + ((int)Math.Ceiling(products.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
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

            M_Prohistory selectCondition = new M_Prohistory
            {
                PrID = number.ToString(),

            };
            history = productDataAccess.getdetail(selectCondition);
        }
        private void setdatedetail()
        {
            var x = history.FirstOrDefault();
            if (x == null)
            {
                invcnt();
                return;
            }

            IDtxt.Text = x.PrID;
            datetime.Text = x.RegisteredDate;
            upusername.Text = x.regUserID;
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