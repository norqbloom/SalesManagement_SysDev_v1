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
    public partial class Product_Add : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        private static List<M_ProductDsp> Product;

        public Product_Add()
        {
            InitializeComponent();
        }

        private void Pro_Add_Button_Click(object sender, EventArgs e)
        {
            //商品データ取得
            if (!GetValidDataAtRegistration())
            {
                return;
            }
            //商品情報作成
            var regProduct = GenerateDataAtRegistration();
            //商品情報登録
            RegistrationProduct(regProduct);
        }

        private bool GetValidDataAtRegistration()
        {
            //商品データの適否
            if (!String.IsNullOrEmpty(PrID.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(PrID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2001");//商品IDは半角数字入力です
                    PrID.Focus();
                    return false;
                }
                //文字数　
                if(PrID.TextLength != 6)
                {
                    messageDsp.DspMsg("M2002");//商品IDは6文字です
                    PrID.Focus();
                    return false;
                }
                //存在なしチェック
                if (productDataAccess.CheckPrIDExistence(PrID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2003");//商品IDは既に存在しています
                    PrID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2004");//商品IDが入力されていません
                PrID.Focus();
                return false;
            }
            //メーカIDの適否
            if (!String.IsNullOrEmpty(MaID.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(MaID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2005");//メーカIDは半角数字入力です
                    MaID.Focus();
                    return false;
                }
                //文字数　
                if (PrID.TextLength != 6)
                {
                    messageDsp.DspMsg("M2006");//メーカIDは4文字です
                    MaID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2008");//メーカIDが入力されていません
                MaID.Focus();
                return false;
            }
            //商品名の適否
            if (!String.IsNullOrEmpty(PrName.Text.Trim()))
            {
                //文字数
                if(PrName.TextLength > 50)
                {
                    messageDsp.DspMsg("M2010");//商品名は50文字以下です
                    PrName.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2011");//商品名が入力されていません
                PrName.Focus();
                return false;
            }
            //価格の適否
            if (!String.IsNullOrEmpty(Price.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(Price.Text.Trim()))
                {
                    messageDsp.DspMsg("M2012");//価格は半角数字入力です
                    Price.Focus();
                    return false;
                }
                //文字数
                if(Price.TextLength > 9)
                {
                    messageDsp.DspMsg("M2014");//価格は9文字以下です
                    Price.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2013");//価格が入力されていません
                Price.Focus();
                return false;
            }
            //安全在庫数の適否
            if (!String.IsNullOrEmpty(PrSafetyStock.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(PrSafetyStock.Text.Trim()))
                {
                    messageDsp.DspMsg("M2016");//安全在庫数は半角数字入力です
                    PrSafetyStock.Focus();
                    return false;
                }
                //文字数
                if(PrSafetyStock.TextLength > 4)
                {
                    messageDsp.DspMsg("M2017");//安全在庫数は4文字以下です
                    PrSafetyStock.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2015");//安全在庫数が入力されていません
                PrSafetyStock.Focus();
                return false;
            }
            //小分類IDの適否
            if (!String.IsNullOrEmpty(ScID.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(ScID.Text.Trim()))
                {
                    messageDsp.DspMsg("M2020");//小分類IDは半角数字入力です
                    ScID.Focus();
                    return false;
                }
                //文字数
                if(ScID.TextLength > 2)
                {
                    messageDsp.DspMsg("M2019");//小分類IDは2文字以下です
                    ScID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2018");//小分類IDが入力されていません
                ScID.Focus();
                return false;
            }
            //型番の適否
            if (!String.IsNullOrEmpty(PrModelNumber.Text.Trim()))
            {
                //文字数
                if(PrModelNumber.TextLength > 20)
                {
                    messageDsp.DspMsg("M2022");//型番は20文字以下です
                    PrModelNumber.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2021");//型番が入力されていません
                PrModelNumber.Focus();
                return false;
            }
            //色の適否
            if (!String.IsNullOrEmpty(PrColor.Text.Trim()))
            {
                //文字数
                if(PrColor.TextLength > 20)
                {
                    messageDsp.DspMsg("M2025");//色は20文字以下です
                    PrColor.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M2026");//色は入力されていません
                PrColor.Focus();
                return false;
            }
            //商品管理フラグ
            if(PrFlag.CheckState == CheckState.Indeterminate)
            {
                messageDsp.DspMsg("");
                PrFlag.Focus();
                return false;
            }
            //非表示理由
            if(PrFlag.Checked == true)
            {
                if (!String.IsNullOrEmpty(PrHidden.Text.Trim()))
                {
                    messageDsp.DspMsg("M");
                    PrFlag.Focus();
                    return false;
                }
            }
            return true;
        }
 
        private M_Product GenerateDataAtRegistration()
        {
            //フラグが選択されている場合
            int checkflg;
            if (PrFlag.Checked == true)
            {
                checkflg = 1;
            }
            else
            {
                checkflg = 0;
            }

            //登録情報のセット
            return new M_Product
            {
                PrID = int.Parse(PrID.Text.Trim()),
                MaID = int.Parse(MaID.Text.Trim()),
                PrName = PrName.Text.Trim(),
                Price = int.Parse(Price.Text.Trim()),
                PrSafetyStock = int.Parse(PrSafetyStock.Text.Trim()),
                ScID = int.Parse(ScID.Text.Trim()),
                PrModelNumber = PrModelNumber.Text.Trim(),
                PrColor = PrColor.Text.Trim(),
                PrReleaseDate = DateTime.Parse(PrReleaseDate.Text.Trim()),
                PrFlag =  checkflg,
                PrHidden = PrHidden.Text.Trim()
            }; 
        }

        private void RegistrationProduct(M_Product regProduct)
        {
            //登録確認メッセージ
            DialogResult result = messageDsp.DspMsg("M2029");//商品データを登録してよろしいですか？
            if(result == DialogResult.Cancel)
            {
                return;
            }

            //商品情報の登録
            bool flg = productDataAccess.AddProductData(regProduct);
            if(flg == true)
            {
                messageDsp.DspMsg("M2030");//商品データを登録しました
            }
            else
            {
                messageDsp.DspMsg("M2031");//商品データ登録に失敗しました
            }
            PrID.Focus();

            //入力エリアのクリア
            //ClearInput();
            //画面更新
            GetDataGridView();
            
        }

        private void ClearInput()
        {
            PrID.Text = "";
            MaID.Text = "";
            PrName.Text = "";
            Price.Text = "";
            PrSafetyStock.Text = "";
            ScID.Text = "";
            PrModelNumber.Text = "";
            PrColor.Text = "";
            PrReleaseDate.Value = DateTime.Now;
            PrFlag.Checked = false;
            PrHidden.Text = "";
        }

        private void GetDataGridView()
        {
            //商品データの取得
            Product = productDataAccess.GetProductData();

            SetDataGridView();
        }

        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Product.Skip(pageSize * pageNo).Take(pageSize).ToList();
            //各列幅の指定
            dataGridViewDsp.Columns[0].Width = 80;
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[2].Width = 130;
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].Visible = false;
            dataGridViewDsp.Columns[4].Width = 130;
            dataGridViewDsp.Columns[4].Visible = false;
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].Visible = false;
            dataGridViewDsp.Columns[6].Width = 130;
            dataGridViewDsp.Columns[6].Visible = false;
            dataGridViewDsp.Columns[7].Width = 130;
            dataGridViewDsp.Columns[7].Visible = false;
            dataGridViewDsp.Columns[8].Width = 130;
            dataGridViewDsp.Columns[8].Visible = false;
            dataGridViewDsp.Columns[9].Width = 130;
            dataGridViewDsp.Columns[9].Visible = false;
            dataGridViewDsp.Columns[10].Width = 130;
            dataGridViewDsp.Columns[10].Visible = false;
            //dataGridViewDsp.Columns[11].Width = 50;
            //dataGridViewDsp.Columns[11].Visible = false;
            //dataGridViewDsp.Columns[12].Width = 100;
            //dataGridViewDsp.Columns[13].Width = 50;
            //dataGridViewDsp.Columns[13].Visible = false;
            //dataGridViewDsp.Columns[14].Width = 100;
            //dataGridViewDsp.Columns[15].Width = 50;
            //dataGridViewDsp.Columns[15].Visible = false;
            //dataGridViewDsp.Columns[16].Width = 100;
            //dataGridViewDsp.Columns[17].Width = 50;
            //dataGridViewDsp.Columns[17].Visible = false;
            //dataGridViewDsp.Columns[18].Width = 100;
            //dataGridViewDsp.Columns[19].Width = 100;
            //dataGridViewDsp.Columns[20].Width = 130;
            //dataGridViewDsp.Columns[20].Visible = false;
            //dataGridViewDsp.Columns[21].Width = 80;
            //dataGridViewDsp.Columns[22].Width = 250;

            //各列の文字位置の指定
            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //dataGridViewの総ページ数
            labelPage.Text = "/" + ((int)Math.Ceiling(Product.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();

        }

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

        private void Product_Add_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }
    }

}
