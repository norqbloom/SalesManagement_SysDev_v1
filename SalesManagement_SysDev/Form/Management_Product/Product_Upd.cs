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
    public partial class Product_Upd : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        public Product_Upd()
        {
            InitializeComponent();
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            //妥当は商品データ取得
            if (!GetValidDataUpdate())
            {
                return;
            }

            //商品情報作成
            var updProduct = GenerateDataAtUpdate();

            //商品情報更新
            UpdateProduct(updProduct);
        }

        private bool GetValidDataUpdate()
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
                //存在ありチェック
                if (!productDataAccess.CheckPrIDExistence(textBoxPrID.Text.Trim()))
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
                if (textBoxPrID.TextLength > 4)
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
            //商品管理フラグ
            if (checkBoxPrFlag.CheckState == CheckState.Indeterminate)
            {
                messageDsp.DspMsg("");//メッセージ不明
                checkBoxPrFlag.Focus();
                return false;
            }
            //非表示理由
            if (checkBoxPrFlag.Checked == true)
            {
                if (!String.IsNullOrEmpty(textBoxPrHidden.Text.Trim()))
                {
                    messageDsp.DspMsg("M");//メッセージ不明
                    checkBoxPrFlag.Focus();
                    return false;
                }
            }
            return true;
        }

        private M_Product GenerateDataAtUpdate()
        {
            //フラグが選択されている場合
            int checkflg;
            if (checkBoxPrFlag.Checked == true)
            {
                checkflg = 2;
            }
            else
            {
                checkflg = 0;
            }
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
                PrReleaseDate = dateTimePickerPrReleaseDate.Text.Trim(),
                PrFlag = checkflg,
                PrHidden = textBoxPrHidden.Text.Trim()
            };
        }

        private void UpdateProduct(M_Product updProduct)
        {
            //更新確認メッセージ
            DialogResult result = messageDsp.DspMsg("M2033");//商品データを更新してよろしいですか？
            if(result == DialogResult.Cancel)
            {
                return;
            }
            //商品情報の更新   
            bool flg = productDataAccess.UpdateProductData(updProduct);
            if(flg == true)
            {
                messageDsp.DspMsg("M2034");//商品データを更新しました
            }
            else
            {
                messageDsp.DspMsg("M2035");//商品データ更新に失敗しました
            }
            textBoxPrID.Focus();
            //入力エリアのクリア
            ClearInput();
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
            checkBoxPrFlag.Checked = false;
            textBoxPrHidden.Text = "";
        }
    }
}
