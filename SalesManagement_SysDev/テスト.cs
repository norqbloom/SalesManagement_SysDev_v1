using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class テスト : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        OrderDateAccess orderDateAccess = new OrderDateAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        private static List<T_Order> orders;
        public テスト()
        {
            InitializeComponent();
        }
        private void テスト_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (!GetValidDataAtRegistration())
            {
                return;
            }

            var regOrder = GenerateDataAtRegistration();

            RegistrationOrder(regOrder);

            //Formのデータグリッドビュー
        }
        private void ClearInput()
        {
            textBoxOrID.Text = "";
            textBoxSoID.Text = "";
            textBoxEmID.Text = "";
            textBoxClID.Text = "";
            textBoxClChange.Text = "";
            dateTimePickerOrDate.Value = DateTime.Now;
            checkBoxOrStateFlag.Checked = false;
            checkBoxOrFlag.Checked = false;
            textBoxOrHidden.Text = "";
        }

        private bool GetValidDataAtRegistration()
        {
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }

                if(textBoxOrID.TextLength > 6)
                {
                    messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }

                if (orderDateAccess.CheckOrIDExistence(textBoxOrID.Text.Trim()))
                {
                    messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("");
                textBoxOrID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("");
                    textBoxSoID.Focus();
                    return false;
                }

                if (textBoxSoID.TextLength > 2)
                {
                    messageDsp.DspMsg("");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("");
                textBoxSoID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    messageDsp.DspMsg("");
                    textBoxEmID.Focus();
                    return false;
                }

                if (textBoxEmID.TextLength > 6)
                {
                    messageDsp.DspMsg("");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("");
                textBoxEmID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    messageDsp.DspMsg("");
                    textBoxClID.Focus();
                    return false;
                }

                if (textBoxClID.TextLength > 6)
                {
                    messageDsp.DspMsg("");
                    textBoxClID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("");
                textBoxClID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxClChange.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckFullWidth(textBoxClChange.Text.Trim()))
                {
                    messageDsp.DspMsg("");
                    textBoxClChange.Focus();
                    return false;
                }

                if (textBoxClChange.TextLength > 50)
                {
                    messageDsp.DspMsg("");
                    textBoxClChange.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.DspMsg("");
                textBoxClChange.Focus();
                return false;
            }

            if(checkBoxOrStateFlag.CheckState == CheckState.Indeterminate)
            {
                messageDsp.DspMsg("");
                checkBoxOrStateFlag.Focus();
                return false;
            }

            if (checkBoxOrFlag.CheckState == CheckState.Indeterminate)
            {
                messageDsp.DspMsg("");
                checkBoxOrFlag.Focus();
                return false;
            }

            if (checkBoxOrFlag.Checked == true)
            {
                if (!String.IsNullOrEmpty(textBoxOrHidden.Text.Trim()))
                {
                    messageDsp.DspMsg("");
                    checkBoxOrFlag.Focus();
                    return false;
                }
            }
            return true;
        }

        private T_Order GenerateDataAtRegistration()
        {
            int checkFlg;
            if(checkBoxOrFlag.Checked == true)
            {
                checkFlg = 2;
            }
            else
            {
                checkFlg = 0;
            }

            return new T_Order
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
                OrStateFlag = 0,
                OrFlag = checkFlg,
                OrHidden = textBoxOrHidden.Text.Trim()
            };
        }

        private void RegistrationOrder(T_Order regOrder)
        {
            DialogResult result = messageDsp.DspMsg("");
            if(result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = orderDateAccess.AddorderData(regOrder);
            if(flg == true)
            {
                messageDsp.DspMsg("");
            }
            else
            {
                messageDsp.DspMsg("");
            }
            textBoxOrID.Focus();

            ClearInput();
        }

        
    }
}
