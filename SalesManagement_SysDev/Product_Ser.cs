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
        private static List<Prhistory> history;
   



        public Product_Ser()
        {
            InitializeComponent();
        }
        private void invcnt()
        {
            labelPr.Visible = false;
            labelMa.Visible = false;
            labelSc.Visible = false;
            datetime.Visible = false;
            userid.Visible = false;
            username.Visible = false;
            uptime.Visible = false;
            upuserid.Visible = false;
            upusername.Visible = false;
        }
        private void incntok()
        {
            labelPr.Visible = true;
            labelMa.Visible = true;
            labelSc.Visible = true;
            datetime.Visible = true;
            userid.Visible = true;
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
                    else
                    {
                        //商品のみ
                        priddate();
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

        
        }
        private void SetSelectData()
        {
            dataGridViewDsp.DataSource = products;
        }

        private void dateMaget()
        {
            if (checkBoxdate.Checked == true)
            {
                M_Product selectCondition = new M_Product()
                {
                    MaID = int.Parse(textBoxMaID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim(),
                };
                products = productDataAccess.GetMaHdata(selectCondition,dateTimePickerPrReleaseDate.Value,dateTimePickerPrReleaseDate2.Value);
            }
            else
            {
                M_Product selectCondition = new M_Product()
                {
                    MaID = int.Parse(textBoxMaID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim(),
                };
                products = productDataAccess.GetMadata(selectCondition);
            }

        }
        private void datedubblwget()
        {
            if (checkBoxdate.Checked == true)
            {
                M_Product selectCondition = new M_Product()
                {
                    PrID = int.Parse(textBoxPrID.Text.Trim()),
                    MaID = int.Parse(textBoxMaID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    ScID = int.Parse(textBoxScID.Text.Trim()),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim(),
                };
                products = productDataAccess.GetdubblwHdata(selectCondition, dateTimePickerPrReleaseDate.Value, dateTimePickerPrReleaseDate2.Value);

            }
            else
            {
                M_Product selectCondition = new M_Product()
                {
                    PrID = int.Parse(textBoxPrID.Text.Trim()),
                    MaID = int.Parse(textBoxMaID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    ScID = int.Parse(textBoxScID.Text.Trim()),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim(),
                };
                products = productDataAccess.Getdubblwdata(selectCondition);

            }


        }
        private void dateScget()
        {
            if (checkBoxdate.Checked == true)
            {
                M_Product selectCondition = new M_Product()
                {
                    PrName = textBoxPrName.Text.Trim(),
                    ScID = int.Parse(textBoxScID.Text.Trim()),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim(),
                };
                products = productDataAccess.GetScHdata(selectCondition, dateTimePickerPrReleaseDate.Value, dateTimePickerPrReleaseDate2.Value);

            }
            else
            {
                M_Product selectCondition = new M_Product()
                {
                    PrName = textBoxPrName.Text.Trim(),
                    ScID = int.Parse(textBoxScID.Text.Trim()),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim(),
                };
                products = productDataAccess.GetScdata(selectCondition);

            }
        }
        private void datenolwget()
        {
            if (checkBoxdate.Checked == true)
            {
                M_Product selectCondition = new M_Product()
                {
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim()
                };
                products = productDataAccess.GetnoHdata(selectCondition, dateTimePickerPrReleaseDate.Value, dateTimePickerPrReleaseDate2.Value);

            }
            else
            {
                M_Product selectCondition = new M_Product()
                {
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim()
                };
                products = productDataAccess.Getnodata(selectCondition);

            }


        }
        private void datePrMaget()
        {
            if (checkBoxdate.Checked == true)
            {
                M_Product selectCondition = new M_Product()
                {
                    PrID = int.Parse(textBoxPrID.Text.Trim()),
                    MaID = int.Parse(textBoxMaID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim(),
                };
                products = productDataAccess.GetPrMaHdata(selectCondition, dateTimePickerPrReleaseDate.Value, dateTimePickerPrReleaseDate2.Value);

            }
            else
            {
                M_Product selectCondition = new M_Product()
                {
                    PrID = int.Parse(textBoxPrID.Text.Trim()),
                    MaID = int.Parse(textBoxMaID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim(),
                };
                products = productDataAccess.GetPrMadata(selectCondition);

            }


        }
        private void datePrScget()
        {
            if (checkBoxdate.Checked == true)
            {
                M_Product selectCondition = new M_Product()
                {
                    PrID = int.Parse(textBoxPrID.Text.Trim()),
                    ScID = int.Parse(textBoxScID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim()
                };
                products = productDataAccess.GetPrScHdata(selectCondition, dateTimePickerPrReleaseDate.Value, dateTimePickerPrReleaseDate2.Value);

            }
            else
            {
                M_Product selectCondition = new M_Product()
                {
                    PrID = int.Parse(textBoxPrID.Text.Trim()),
                    ScID = int.Parse(textBoxScID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim()
                };
                products = productDataAccess.GetPrScdata(selectCondition);

            }


        }
        private void priddate()
        {
            if (checkBoxdate.Checked == true)
            {
                M_Product selectCondition = new M_Product()
                {
                    PrID = int.Parse(textBoxPrID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim()
                };
                products = productDataAccess.GetPronlyHdata(selectCondition, dateTimePickerPrReleaseDate.Value, dateTimePickerPrReleaseDate2.Value);

            }
            else
            {
                M_Product selectCondition = new M_Product()
                {
                    PrID = int.Parse(textBoxPrID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim()
                };
                products = productDataAccess.GetPronlydata(selectCondition);

            }


        }
        private void dateMaScget()
        {
            if (checkBoxdate.Checked == true)
            {
                M_Product selectCondition = new M_Product()
                {
                    ScID = int.Parse(textBoxScID.Text.Trim()),
                    MaID = int.Parse(textBoxMaID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim()
                };
                products = productDataAccess.GetMaScHdata(selectCondition, dateTimePickerPrReleaseDate.Value, dateTimePickerPrReleaseDate2.Value);

            }
            else
            {
                M_Product selectCondition = new M_Product()
                {
                    ScID = int.Parse(textBoxScID.Text.Trim()),
                    MaID = int.Parse(textBoxMaID.Text.Trim()),
                    PrName = textBoxPrName.Text.Trim(),
                    PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                    PrColor = textBoxPrColor.Text.Trim()
                };
                products = productDataAccess.GetMaScdata(selectCondition);

            }

        }
        ///////////////////////////////
        //メソッド名：SetFormDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューの設定
        ///////////////////////////////
        private void SetFormDataGridView()
        {
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "10";
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
            if (radioButton1.Checked == true)
            {
                radioint = 2;
            }
            else
            {
                radioint = 0;
            }
            // 商品データの取得
            products = productDataAccess.GetProductDataDsp(radioint);
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
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";

            dataGridViewDsp.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();

            //列名の中央揃え
            foreach (DataGridViewColumn clm in dataGridViewDsp.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //各列幅の指定
            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 100;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 100;
            dataGridViewDsp.Columns[4].Visible = false;
            dataGridViewDsp.Columns[5].Width = 100;
            dataGridViewDsp.Columns[6].Width = 100;
            dataGridViewDsp.Columns[7].Width = 100;
            dataGridViewDsp.Columns[8].Width = 100;
            dataGridViewDsp.Columns[9].Width = 100;
            dataGridViewDsp.Columns[10].Width = 100;
            dataGridViewDsp.Columns[11].Width = 200;

            //各列の文字位置の指定
            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dataGridViewの総ページ数
            labelPage.Text = "/" + ((int)Math.Ceiling(products.Count / (double)pageSize)) + "ページ";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetFormDataGridView();
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
        private void ButtonCle_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {
            textBoxPrID.Text = "";
            textBoxMaID.Text = "";
            textBoxPrName.Text = "";
            textBoxScID.Text = "";
            textBoxPrModelNumber.Text = "";
            textBoxPrColor.Text = "";
            dateTimePickerPrReleaseDate.Value = DateTime.Now;
            checkBoxPrFlag.Checked = false;
        }


        //ここから右側↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓

        private void dataGridViewDsp_SelectionChanged(object sender, EventArgs e)
        {
            int number;
            int PrIDtxt;
            number = (int)dataGridViewDsp.CurrentRow.Cells[1].Value;
            PrIDtxt = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            labelPr.Text = PrIDtxt.ToString();

            serchdateset(PrIDtxt);
            setdatedetail();
        }
        private void serchdateset(int number)
        {
            Prhistory selectCondition = new Prhistory
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

            labelPr.Text = x.PrID;
            labelMa.Text = x.MaID;
            labelSc.Text = x.ScID;
            datetime.Text = x.RegisteredDate;
            userid.Text = x.regUserID;
            username.Text = x.regUserName;
            uptime.Text = x.UpDateTime;
            upuserid.Text = x.LastupdatedUserID;
            upusername.Text = x.LastupdatedUserName;
            incntok();
        }
    }
}
