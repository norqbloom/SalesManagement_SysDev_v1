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
            return true;
        }

        private M_Product GenerateDataAtRegistration()
        {
            return new M_Product
            {

            }; 
        }

        private void RegistrationProduct(M_Product regProduct)
        {

        }

        private void Pro_Add_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
