using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Client
{
    public partial class Client_Ser : Form
    {
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        MessageDsp messageDsp = new MessageDsp();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        private static List<M_Client> clients;
        private static List<M_clhistory> history;

        public Client_Ser()
        {
            InitializeComponent();
        }

        private void invcnt()
        {
            label5.Visible = false;
            IDtxt.Visible = false;
            datetime.Visible = false;
            userid.Visible = false;
            username.Visible = false;
            uptime.Visible = false;
            upuserid.Visible = false;
            upusername.Visible = false;
        }
        private void incntok()
        {
            label5.Visible = true;
            IDtxt.Visible = true;
            datetime.Visible = true;
            userid.Visible = true;
            username.Visible = true;
            uptime.Visible = true;
            upuserid.Visible = true;
            upusername.Visible = true;
        }

        private void Client_Ser_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            invcnt();
        }

        private void buttonSer_Click(object sender, EventArgs e)
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
            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001");
                    textBoxClID.Focus();
                    return false;
                }
            }
            //SOID確認
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1005");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            //Clphone確認
            if (!String.IsNullOrEmpty(textBoxClPhone.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckHalfChar(textBoxClPhone.Text.Trim()))
                {
                    messageDsp.DspMsg("M1015");
                    textBoxClPhone.Focus();
                    return false;

                }
            }

            return true;
        }

        private void GenerateDataAtSelect()
        {
            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
                {
                    datedubblwget();
                }
                else
                {
                    dateClget();
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
                {
                    dateSoget();
                }
                else
                {
                    datenolwget();
                }

            }

        }
        private void SetSelectData()
        {

            dataGridViewDsp.DataSource = clients;
        }
        private void dateClget()
        {
            M_Client selectCondition = new M_Client()
            {
                ClID = int.Parse(textBoxClID.Text.Trim()),
                ClName = textBoxClName.Text.Trim(),
                ClPhone = textBoxClPhone.Text.Trim(),
                ClAddress = textBoxClAddress.Text.Trim(),
                ClFAX = textBoxClPostal.Text.Trim(),
                ClPostal = textBoxClFAX.Text.Trim()
            };
            clients = clientDataAccess.GetCldata(selectCondition);
        }
        private void dateSoget()
        {
            M_Client selectCondition = new M_Client()
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                ClName = textBoxClName.Text.Trim(),
                ClPhone = textBoxClPhone.Text.Trim(),
                ClAddress = textBoxClAddress.Text.Trim(),
                ClFAX = textBoxClPostal.Text.Trim(),
                ClPostal = textBoxClFAX.Text.Trim()
            };
            clients = clientDataAccess.GetSodata(selectCondition);

        }
        private void datedubblwget()
        {
            M_Client selectCondition = new M_Client()
            {
                ClID = int.Parse(textBoxClID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                ClName = textBoxClName.Text.Trim(),
                ClPhone = textBoxClPhone.Text.Trim(),
                ClAddress = textBoxClAddress.Text.Trim(),
                ClFAX = textBoxClPostal.Text.Trim(),
                ClPostal = textBoxClFAX.Text.Trim()
            };
            clients = clientDataAccess.Getdubblwdata(selectCondition);
        }
        private void datenolwget()
        {
            M_Client selectCondition = new M_Client()
            {
                ClName = textBoxClName.Text.Trim(),
                ClPhone = textBoxClPhone.Text.Trim(),
                ClAddress = textBoxClAddress.Text.Trim(),
                ClFAX = textBoxClPostal.Text.Trim(),
                ClPostal = textBoxClFAX.Text.Trim()
            };
            clients = clientDataAccess.Getnodata(selectCondition);

        }
        private void SetFormDataGridView()
        {
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDsp.ReadOnly = true;
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "10";
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();
            labelPage.Text = "/" + ((int)Math.Ceiling(clients.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //ここから右側↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }


        private void serchdateset(int number)
        {

            M_clhistory selectCondition = new M_clhistory
            {
                ClID = number.ToString(),

            };
            history = clientDataAccess.getdetail(selectCondition);
        }
        private void setdatedetail()
        {
            var x = history.FirstOrDefault();
            if (x == null)
            {
                invcnt();
                return;
            }

            IDtxt.Text = x.ClID;
            datetime.Text = x.RegisteredDate;
            userid.Text = x.regUserID;
            username.Text = x.regUserName;
            uptime.Text = x.UpDateTime;
            upuserid.Text = x.LastupdatedUserID;
            upusername.Text = x.LastupdatedUserName;
            incntok();


        }

        private void change_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {

        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {

        }

        private void buttonSer_Click_1(object sender, EventArgs e)
        {

        }
    }
}
