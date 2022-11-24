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
            }  
            return true;
        }

        private void GenerateDataAtSelect()
        {
            //ここから
            if (!String.IsNullOrEmpty(textBoxPrID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(textBoxMaID.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(textBoxScID.Text.Trim()))
                    {
                        //全て入力されている
                        datedubblwget();
                        return;
                    }
                    else
                    {
                        //商品・メーカーのみ
                        datePrMaget();
                        return;
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(textBoxScID.Text.Trim()))
                    {
                       　//商品・小分類のみ
                        datePrScget();
                        return;
                    }
                }
            }
            else if (!String.IsNullOrEmpty(textBoxMaID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(textBoxScID.Text.Trim()))
                {
                    //メーカー・小分類のみ
                    dateMaScget();
                    return;
                }
                else
                {
                    //メーカーのみ
                    dateMaget();
                    return;
                }
            }
            else if (!String.IsNullOrEmpty(textBoxScID.Text.Trim()))
            {
                //小分類のみ
                dateScget();
                return;
            }
            else
            {
                //何も入力されていない
                datenolwget();
                return;
            }

            if (!String.IsNullOrEmpty(textBoxPrID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(textBoxMaID.Text.Trim()))
                {
                    datedubblwget();
                }
                else
                {
                    datePrget();
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(textBoxMaID.Text.Trim()))
                {
                    dateMaget();
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
        private void datePrget()
        {
            DateTime Dt = DateTime.Parse(dateTimePickerPrReleaseDate.Text.Trim());

            M_Product selectCondition = new M_Product()
            {
                PrID = int.Parse(textBoxPrID.Text.Trim()),
                PrName = textBoxPrName.Text.Trim(),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(dateTimePickerPrReleaseDate.Text.Trim()).Date
            };
            products = productDataAccess.GetPrdata(selectCondition);

        }
        private void dateMaget()
        {
            M_Product selectCondition = new M_Product()
            {
                MaID = int.Parse(textBoxMaID.Text.Trim()),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(dateTimePickerPrReleaseDate.Text)
            };
            products = productDataAccess.GetMadata(selectCondition);

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
        private void dateScget()
        {
            M_Product selectCondition = new M_Product()
            {
                PrName = textBoxPrName.Text.Trim(),
                ScID = int.Parse(textBoxScID.Text.Trim()),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(dateTimePickerPrReleaseDate.Text)
            };
            products = productDataAccess.GetScdata(selectCondition);

        }
        private void datenolwget()
        {
            DateTime Dt = DateTime.Parse(dateTimePickerPrReleaseDate.Text.Trim());

            M_Product selectCondition = new M_Product()
            {
                PrName = textBoxPrName.Text.Trim(),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(dateTimePickerPrReleaseDate.Text.Trim())
            };
            MessageBox.Show(Dt.ToString("yyyy/MM/dd"));
            products = productDataAccess.Getnodata(selectCondition);

        }
        private void datePrMaget()
        {
            DateTime Dt = DateTime.Parse(dateTimePickerPrReleaseDate.Text.Trim());
            M_Product selectCondition = new M_Product()
            {
                PrID = int.Parse(textBoxPrID.Text.Trim()),
                MaID = int.Parse(textBoxMaID.Text.Trim()),
                PrName = textBoxPrName.Text.Trim(),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(Dt.ToString("yyyy/mm/dd"))
            };
            products = productDataAccess.GetPrMadata(selectCondition);

        }
        private void datePrScget()
        {
            M_Product selectCondition = new M_Product()
            {
                PrID = int.Parse(textBoxPrID.Text.Trim()),
                ScID = int.Parse(textBoxScID.Text.Trim()),
                PrName = textBoxPrName.Text.Trim(),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(dateTimePickerPrReleaseDate.Text.Trim())
            };
            products = productDataAccess.GetPrScdata(selectCondition);

        }
        private void dateMaScget()
        {
            M_Product selectCondition = new M_Product()
            {
                ScID = int.Parse(textBoxScID.Text.Trim()),
                MaID = int.Parse(textBoxMaID.Text.Trim()),
                PrName = textBoxPrName.Text.Trim(),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(dateTimePickerPrReleaseDate.Text.Trim())
            };
            products = productDataAccess.GetMaScdata(selectCondition);

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

        private void dataGridViewDsp_SelectionChanged(object sender, EventArgs e)
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

        private void change_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void buttonFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            dataGridViewDsp.DataSource = products.Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridViewDsp.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(products.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(products.Count / (double)pageSize);
            if (pageNo >= lastPage)
                textBoxPageNo.Text = lastPage.ToString();
            else
                textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(products.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        
    }
    }
