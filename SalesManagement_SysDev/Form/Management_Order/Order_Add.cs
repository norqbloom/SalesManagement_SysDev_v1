using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Order
{
    public partial class Order_Add : Form
    {
        //メッセージ表示用クラスのインスタンス化
        MessageDsp messageDsp = new MessageDsp();
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        OrderDateAccess orderDateAccess = new OrderDateAccess();
        public Order_Add()
        {
            InitializeComponent();
        }
        private void Order_Add_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //登録
            if (!GetclientDataAtRegistration())
                return;
            var regCl = GenerateDataAtRegistration();
            //RegistrationOrder(regOr);
        }

        private bool GetclientDataAtRegistration()
        {
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (textBoxOrID.Text.Length >= 6)
                {
                    MessageBox.Show("6文字いない");
                    textBoxOrID.Focus();
                    return false;
                }
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("数値のみ");
                    textBoxOrID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (textBoxSoID.Text.Length >= 2)
                {
                    MessageBox.Show("2文字いない");
                    textBoxSoID.Focus();
                    return false;
                }
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    MessageBox.Show("数値のみ");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (textBoxEmID.Text.Length >= 6)
                {
                    MessageBox.Show("6文字いない");
                    textBoxEmID.Focus();
                    return false;
                }
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    MessageBox.Show("数値のみ");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (textBoxClID.Text.Length >= 6)
                {
                    MessageBox.Show("6文字いない");
                    textBoxClID.Focus();
                    return false;
                }
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    MessageBox.Show("数値のみ");
                    textBoxClID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxClChange.Text.Trim()))
            {
                if (textBoxClChange.Text.Length >= 50)
                {
                    MessageBox.Show("50文字いない");
                    textBoxClChange.Focus();
                    return false;
                }
            }
            if (checkBoxOrStateFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("");
                checkBoxOrStateFlag.Focus();
                return false;
            }
            if (checkBoxOrFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("");
                checkBoxOrFlag.Focus();
                return false;
            }
            return true;
        }
        private T_Order GenerateDataAtRegistration()
        {
            int checkflg;
            if(checkBoxOrFlag.Checked == true)
            {
                checkflg = 1;
            }
            else
            {
                checkflg = 0;
            }
            return new T_Order
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
                OrStateFlag = int.Parse(checkBoxOrStateFlag.Text),
                OrFlag = checkflg,
                OrHidden = textBoxOrHidden.Text
            };
        }
        private void RegistrationClient(T_Order regClient)
        {
            DialogResult result = MessageBox.Show("確認", MessageBoxButtons.OKCancel.ToString());
            if (result == DialogResult.Cancel)
                return;
            //bool flg = orderDataAccess.AddClientData(regClient);
            //if (flg == true)
            //    messageDsp.DspMsg("M1022");
            //else
            //    messageDsp.DspMsg("M1023");
            

        }
        private void Ord_Del_Button_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                MessageBox.Show("M4015", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOrID.Focus();
                return;

            }
            result = MessageBox.Show("M4011");
            
        }

        private void checkBoxOrStateFlag_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
