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
    public partial class Order_Ser : Form
    {
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        MessageDsp messageDsp = new MessageDsp();
        OrderDateAccess orderdateAccess = new OrderDateAccess();
        private static List<T_Order> orders;
        public Order_Ser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!GetClientDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }
        private bool GetClientDataAtSelect()
        {
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxOrID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                messageDsp.DspMsg("M1001");
                textBoxClID.Focus();
                return false;
            }
            return true;
        }
        private void GenerateDataAtSelect()
        {
            if (!String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //全て入力されている
                            datefull();
                            return;
                        }
                        else
                        {
                            //or,em,so
                            dateorsoem();
                            return;
                        }
                    }
                    else if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                    {
                        //or,so,cl
                        dateorsocl();
                        return;
                    }
                    else
                    {
                        //or,so
                        dateorso();
                        return;
                    }
                }
                else if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                {
                    //or,em
                    dateorem();
                    return;
                }
                else if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                {
                    //or,cl
                    dateorcl();
                    return;
                }
                else
                {
                    //or
                    dateor();
                    return;
                }
            }
            else
            {
                //何も入力されていない
                dateNo();
                return;
            }
        }
        private void datefull()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
            orders = orderdateAccess.GetMaScget(selectCondition);
        }
        private void dateorsoem()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
            orders= orderdateAccess.GetMaScget(selectCondition);
        }
        private void dateorso()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
            orders = orderdateAccess.GetMaScget(selectCondition);
        }
        private void dateor()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
            orders = orderdateAccess.GetMaScget(selectCondition);
        }
        private void dateNo()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
            orders = orderdateAccess.GetMaScget(selectCondition);
        }
        private void dateorsocl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
            orders = orderdateAccess.GetMaScget(selectCondition);
        }
        private void dateorem()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
            orders = orderdateAccess.GetMaScget(selectCondition);
        }
        private void dateorcl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
            orders = orderdateAccess.GetMaScget(selectCondition);
        }
    }
}
