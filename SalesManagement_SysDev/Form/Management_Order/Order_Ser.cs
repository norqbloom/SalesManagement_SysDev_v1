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

            //SetSelectData();
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
                            //全部
                            datefull();
                            return;
                        }
                        else
                        {
                            //OrID,SoID,EmID
                            dateorsoem();
                            return;
                        }
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //OrID,SoID,ClID
                            dateorsocl();
                            return;
                        }
                        else
                        {
                            //OrID,SoID
                            dateorso();
                            return;
                        }
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //OrID,EmID,ClID
                            dateoremcl();
                            return;
                        }
                        else
                        {
                            //OrID,EmID
                            dateorem();
                            return;
                        }
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //OrID,ClID
                            dateorcl();
                            return;
                        }
                        else
                        {
                            //OrID
                            dateor();
                            return;
                        }

                    }
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //SoID,EmID,ClID
                            datesoemcl();
                            return;
                        }
                        else
                        {
                            //SoID,Emid
                            datesoemcl();
                            return;
                        }
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //SoID.ClID
                            datesocl();
                            return;
                        }
                        else
                        {
                            //SoID
                            datesoemcl();
                            return;
                        }
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //EmID,ClID
                            dateemcl();
                        }
                        else
                        {
                            //EmID
                            dateemcl();
                            return;
                        }

                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
                        {
                            //ClID
                            datecl();
                            return;
                        }
                        else
                        {
                            //何もなし
                            dateNo();
                            return;
                        }
                    }

                }

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
            //orders = orderdateAccess.Getfull(selectCondition);
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
<<<<<<< HEAD
            orders= orderdateAccess.Getorsoem(selectCondition);
=======
            //orders= orderdateAccess.Get(selectCondition);
>>>>>>> 2290c642d3d7be6ec045b0aa19e271a9633c0e5b
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
            orders = orderdateAccess.Getorso(selectCondition);
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
            orders = orderdateAccess.Getor(selectCondition);
        }
        private void dateNo()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
            orders = orderdateAccess.GetNo(selectCondition);
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
            orders = orderdateAccess.Getorsocl(selectCondition);
        }
        private void dateorem()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
            orders = orderdateAccess.Getorem(selectCondition);
        }
        private void dateorcl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
            orders = orderdateAccess.Getorcl(selectCondition);
        }
        private void dateoremcl()
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
<<<<<<< HEAD
            orders = orderdateAccess.Getoremcl(selectCondition);
=======
            //orders = orderdateAccess.Getfull(selectCondition);
>>>>>>> 2290c642d3d7be6ec045b0aa19e271a9633c0e5b
        }
        private void datesoemcl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
<<<<<<< HEAD
            orders = orderdateAccess.Getsoemcl(selectCondition);
=======
            //orders = orderdateAccess.Getfull(selectCondition);
>>>>>>> 2290c642d3d7be6ec045b0aa19e271a9633c0e5b
        }
        private void datesocl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
<<<<<<< HEAD
            orders = orderdateAccess.Getsocl(selectCondition);
=======
            //orders = orderdateAccess.Getfull(selectCondition);
>>>>>>> 2290c642d3d7be6ec045b0aa19e271a9633c0e5b
        }
        private void dateemcl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
<<<<<<< HEAD
            orders = orderdateAccess.Getemcl(selectCondition);
=======
            //orders = orderdateAccess.Getfull(selectCondition);
>>>>>>> 2290c642d3d7be6ec045b0aa19e271a9633c0e5b
        }
        private void datecl()
        {
            //全て入力されている
            T_Order selectCondition = new T_Order()
            {
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClCharge = textBoxClChange.Text.Trim(),
                //OrDate = DateTime.Parse(dateTimePickerOrDate.Text.Trim()),
            };
<<<<<<< HEAD
            orders = orderdateAccess.Getcl(selectCondition);
=======
            //orders = orderdateAccess.Getfull(selectCondition);
>>>>>>> 2290c642d3d7be6ec045b0aa19e271a9633c0e5b
        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        


    }
}
