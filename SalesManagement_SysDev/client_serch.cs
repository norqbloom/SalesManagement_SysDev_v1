﻿using System;
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
    public partial class client_serch : Form
    {
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        MessageDsp messageDsp = new MessageDsp();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        private static List<M_Client> clients;

        public client_serch()
        {
            InitializeComponent();
        }

        private void client_serch_Load(object sender, EventArgs e)
        {

        }

        private void serch_Click(object sender, EventArgs e)
        {
            //入力データ確認
            if (!GetClientDataAtSelect())
                return;

            GenerateDataAtSelect();
            SetSelectData();
        }
        private bool GetClientDataAtSelect()
        {
            //CoID確認
            if (!String.IsNullOrEmpty(ClIDtxt.Text.Trim())){
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(ClIDtxt.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    ClIDtxt.Focus();
                    return false;
                }
            }
            //SOID確認
            if (!String.IsNullOrEmpty(SOIDtxt.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(SOIDtxt.Text.Trim()))
                {
                    messageDsp.DspMsg("M1005");
                    SOIDtxt.Focus();
                    return false;
                }
            }
            //Clphone確認
            if (!String.IsNullOrEmpty(ClPhonetxt.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(ClPhonetxt.Text.Trim()))
                {
                    messageDsp.DspMsg("M1015");
                    ClPhonetxt.Focus();
                    return false;

                }

            }
            return true;
        }

        private void GenerateDataAtSelect()
        {
            M_Client selectCondition = new M_Client()
            {
                ClID=int.Parse(ClIDtxt.Text.Trim()),
                SoID=int.Parse(SOIDtxt.Text.Trim()),
                ClName=CLNametxt.Text.Trim(),
                ClPhone=ClPhonetxt.Text.Trim()
                
            };

            clients = clientDataAccess.GetClientdata(selectCondition);
        }
        private void SetSelectData()
        {
            dataGridView1.DataSource = clients;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}