﻿using System;
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
        public Order_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //登録
            //OrID
            //SoID
            //EmID
            //ClID
            //OrDate(datetimepicker)
            //OrStateFlag(checkbox)
            //OrFlag(checkbox)
            //OrHidden
            if (String.IsNullOrEmpty(textBoxOrID.Text.Trim()))
            {
                if (textBoxOrID.Text.Length >= 6)
                {
                    MessageBox.Show("6文字いない");
                    textBoxOrID.Focus();
                    return;
                }
                if (!dataInputFormCheck.CheckNumeric(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("suutinomi");
                    textBoxOrID.Focus();
                    return;
                }
            }
        }

        private void Ord_Del_Button_Click(object sender, EventArgs e)
        {

        }
    }
}