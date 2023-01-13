using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesManagement_SysDev.DbAccess;

namespace SalesManagement_SysDev.Management_Stock
{
    public partial class Stock_Upd : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        StockDataAccess stockDataAccess = new StockDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();


        public Stock_Upd()
        {
            InitializeComponent();
        }

        private void Stock_Upd_Button_Click(object sender, EventArgs e)
        {
            if (!GetValidDataAtUpdate())
            {
                return;
            }

            var upStock = GenerateDataAtUpdate();


            UpdateItem(upStock);
        }

        private bool GetValidDataAtUpdate()
        {
            //StIDの適否 　
            if (!string.IsNullOrEmpty(StID.Text.Trim()))
            {
                //StID半角英数字チェック
                if (!dataInputFormCheck.CheckNumeric(StID.Text.Trim()))
                {
                    messageDsp.DspMsg("M3001"); //在庫IDは半角数字入力です
                    StID.Focus();
                    return false;
                }
                //文字数チェック
                if (StID.TextLength > 6)
                {
                    messageDsp.DspMsg("M3003"); //在庫ID6文字以内
                    StID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("M3004"); //在庫ID入力してない
                StID.Focus();
                return false;
            }

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
                if (PrID.TextLength > 6)
                {
                    messageDsp.DspMsg("M2002");//商品IDは6文字です
                    PrID.Focus();
                    return false;
                }
                //存在ありチェック
                if (!productDataAccess.CheckPrIDExistence(PrID.Text.Trim()))
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

            if (!String.IsNullOrEmpty(StQuantity.Text.Trim()))
            {
                //文字種
                if (!dataInputFormCheck.CheckNumeric(StQuantity.Text.Trim()))
                {
                    messageDsp.DspMsg("M3005");//安全在庫数は半角数字入力です
                    StQuantity.Focus();
                    return false;
                }
                //文字数　
                if (StQuantity.TextLength > 6)
                {
                    messageDsp.DspMsg("M3006");//安全在庫数は4文字です
                    StQuantity.Focus();
                    return false;
                }

            }
            else
            {
                messageDsp.DspMsg("M3004");//安全在庫数が入力されていません
                PrID.Focus();
                return false;
            }

            //在庫管理フラグ
            if (StFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("在庫フラグが不確定な状態です"); //messageDsp.DspMsg("M4028");
                StFlag.Focus();
                return false;
            }
            return true;
        }

            private T_Stock GenerateDataAtUpdate()
            {
                int checkflg;
                if (StFlag.Checked == true)
                {
                    checkflg = 1;
                }
                else
                {
                    checkflg = 0;
                }
                return new T_Stock
                {
                    StID = int.Parse(StID.Text),
                    PrID = int.Parse(PrID.Text),
                    StQuantity = int.Parse(StQuantity.Text),
                    StFlag = checkflg,
                };
            }

             private void UpdateItem(T_Stock upStock)
             {
                DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
                if (result == DialogResult.Cancel)
                return;
                 //登録
                bool flg = stockDataAccess.UpdateStockData(upStock);
                if (flg == true)
                MessageBox.Show("ok"); //messageDsp.DspMsg("M6015");
                else
                MessageBox.Show("no"); //messageDsp.DspMsg("M6016");
             }
    }
}
