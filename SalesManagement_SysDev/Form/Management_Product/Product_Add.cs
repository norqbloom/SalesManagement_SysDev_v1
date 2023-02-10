﻿using System;
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
    public partial class Product_Add : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        //データグリッドビュー用のプロダクトデータ
        private static List<M_Product> products;
        private static int grid = 9;
        public Product_Add()
        {
            InitializeComponent();
        }

        private void Product_Add_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();

        //デートタイムピッカーの設定
        SetFormDateTimePiker();
            var context = new SalesManagement_DevContext();
            var a = context.M_Products.Count();
            int countplus = a + 1;
            textBoxPrID.Text = countplus.ToString();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //商品データ取得
            if (!GetValidDataAtRegistration())
            {
                return;
            }
            //商品情報作成
            var regProduct = GenerateDataAtRegistration();
            RegistrationProduct(regProduct);

            var reghis = GeneratehistoryDataAtRegistration();
            RegistrationClhistory(reghis);
            
            //データグリッドビューの再ロード
            SetFormDataGridView();
        }

        private void button_Cle_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void button_Hide_Click(object sender, EventArgs e)
        {

        }

        private void button_First_Click_1(object sender, EventArgs e)
        {
            int pageSize = grid;
            dataGridViewDsp.DataSource = products.Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        private void button_Prev_Click_1(object sender, EventArgs e)
        {
            int pageSize = grid;
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

        private void button_Next_Click_1(object sender, EventArgs e)
        {
            int pageSize = grid;
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

        private void button_Last_Click_1(object sender, EventArgs e)
        {
            int pageSize = grid;
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(products.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = products.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void SetFormDateTimePiker()
        {
            dateTimePickerPrReleaseDate.Value = DateTime.Now;
            dateTimePickerPrReleaseDate.Checked = true;
        }

        private void ClearInput()
        {
            textBoxPrID.Text = "";
            textBoxMaID.Text = "";
            textBoxPrName.Text = "";
            textBoxPrice.Text = "";
            textBoxPrSafetyStock.Text = "";
            textBoxScID.Text = "";
            textBoxPrModelNumber.Text = "";
            textBoxPrColor.Text = "";
            dateTimePickerPrReleaseDate.Value = DateTime.Now;
        }

        private bool GetValidDataAtRegistration()
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
                //存在なしチェック
                if (productDataAccess.CheckPrIDExistence(textBoxPrID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2003");//商品IDは既に存在しています
                    textBoxPrID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2004");//商品IDが入力されていません
                textBoxPrID.Focus();
                return false;
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
                if (textBoxPrID.TextLength > 6)
                {
                    messageDsp.DspMsg("M2006");//メーカIDは4文字です
                    textBoxMaID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2008");//メーカIDが入力されていません
                textBoxMaID.Focus();
                return false;
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
            else
            {
                messageDsp.DspMsg("M2011");//商品名が入力されていません
                textBoxPrName.Focus();
                return false;
            }
            //価格の適否
            if (!String.IsNullOrEmpty(textBoxPrice.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(textBoxPrice.Text.Trim()))
                {
                    messageDsp.DspMsg("M2012");//価格は半角数字入力です
                    textBoxPrice.Focus();
                    return false;
                }
                //文字数
                if (textBoxPrice.TextLength > 9)
                {
                    messageDsp.DspMsg("M2014");//価格は9文字以下です
                    textBoxPrice.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2013");//価格が入力されていません
                textBoxPrice.Focus();
                return false;
            }
            //安全在庫数の適否
            if (!String.IsNullOrEmpty(textBoxPrSafetyStock.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(textBoxPrSafetyStock.Text.Trim()))
                {
                    messageDsp.DspMsg("M2016");//安全在庫数は半角数字入力です
                    textBoxPrSafetyStock.Focus();
                    return false;
                }
                //文字数
                if (textBoxPrSafetyStock.TextLength > 4)
                {
                    messageDsp.DspMsg("M2017");//安全在庫数は4文字以下です
                    textBoxPrSafetyStock.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2015");//安全在庫数が入力されていません
                textBoxPrSafetyStock.Focus();
                return false;
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
            else
            {
                messageDsp.DspMsg("M2018");//小分類IDが入力されていません
                textBoxScID.Focus();
                return false;
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
            else
            {
                messageDsp.DspMsg("M2021");//型番が入力されていません
                textBoxPrModelNumber.Focus();
                return false;
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
            else
            {
                messageDsp.DspMsg("M2026");//色は入力されていません
                textBoxPrColor.Focus();
                return false;
            }         
            return true;
            }
        private M_Product GenerateDataAtRegistration()
        {
            //フラグが選択されている場合
            int checkflg = 0;
            //登録情報のセット
            return new M_Product
            {
                PrID = int.Parse(textBoxPrID.Text.Trim()),
                MaID = int.Parse(textBoxMaID.Text.Trim()),
                PrName = textBoxPrName.Text.Trim(),
                Price = int.Parse(textBoxPrice.Text.Trim()),
                PrSafetyStock = int.Parse(textBoxPrSafetyStock.Text.Trim()),
                ScID = int.Parse(textBoxScID.Text.Trim()),
                PrModelNumber = textBoxPrModelNumber.Text.Trim(),
                PrColor = textBoxPrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(dateTimePickerPrReleaseDate.Text),
                PrFlag = checkflg,
                PrHidden = null
            };
        }

        private void RegistrationProduct(M_Product regProduct)
        {
            //登録確認メッセージ
            DialogResult result = messageDsp.DspMsg("M2029");//商品データを登録してよろしいですか？
            if (result == DialogResult.Cancel)
            {
                return;
            }

            //商品情報の登録
            bool flg = productDataAccess.AddProductData(regProduct);
            if (flg == true)
            {
                messageDsp.DspMsg("M2030");//商品データを登録しました
            }
            else
            {
                messageDsp.DspMsg("M2031");//商品データ登録に失敗しました
            }
            textBoxPrID.Focus();


        }

        private M_Prohistory GeneratehistoryDataAtRegistration()
        {
            DateTime dt = DateTime.Now;
            string regtime = dt.ToString("MM/dd HH;mm");

            return new M_Prohistory
            {
                PrID=textBoxPrID.Text,
                RegisteredDate = regtime,
                regUserID = template.EmID.ToString(),
                regUserName = template.loginName,
                UpDateTime = "なし",
                LastupdatedUserID = "なし",
                LastupdatedUserName = "なし"
            };
        }
        private void RegistrationClhistory(M_Prohistory reghis)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Prohistory.Add(reghis);
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //入力エリアのクリア
            ClearInput();
        }
        
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
        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの取得
        ///////////////////////////////
        private void GetDataGridView()
        {
            int radioint = 0;
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
            int pageSize = grid;
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
            dataGridViewDsp.Columns[0].Width = 50;
            dataGridViewDsp.Columns[1].Width = 50;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 100;
            dataGridViewDsp.Columns[4].Visible = false;
            dataGridViewDsp.Columns[5].Width = 75;
            dataGridViewDsp.Columns[6].Width = 70;
            dataGridViewDsp.Columns[7].Width = 100;
            dataGridViewDsp.Columns[8].Width = 90;
            dataGridViewDsp.Columns[9].Width = 70;
            dataGridViewDsp.Columns[10].Width = 85;
            //dataGridViewDsp.Columns[11].Width = 200;

            //dataGridViewの総ページ数
            labelPage.Text = "/" + ((int)Math.Ceiling(products.Count / (double)pageSize)) + "ページ";
        }
    }
}
