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
    public partial class client_serch : Form
    {
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        MessageDsp messageDsp = new MessageDsp();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        private static List<M_Client> clients;
        private static List<M_clhistory> history;


        public client_serch()
        {
            InitializeComponent();
        }
        private void invcnt()
        {
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
            IDtxt.Visible = true;
            datetime.Visible = true;
            userid.Visible = true;
            username.Visible = true;
            uptime.Visible = true;
            upuserid.Visible = true;
            upusername.Visible = true;
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
                if (!dataInputFormCheck.CheckHalfChar(ClPhonetxt.Text.Trim()))
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
            if (!String.IsNullOrEmpty(ClIDtxt.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(SOIDtxt.Text.Trim()))
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
                if (!String.IsNullOrEmpty(SOIDtxt.Text.Trim()))
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
            dataGridView1.DataSource = clients;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dateClget()
        {
            M_Client selectCondition = new M_Client()
            {
                ClID = int.Parse(ClIDtxt.Text.Trim()),
                ClName = CLNametxt.Text.Trim(),
                ClPhone = ClPhonetxt.Text.Trim(),
            };
            clients = clientDataAccess.GetCldata(selectCondition);

        }
        private void dateSoget()
        {
            M_Client selectCondition = new M_Client()
            {
                SoID = int.Parse(SOIDtxt.Text.Trim()),
                ClName = CLNametxt.Text.Trim(),
                ClPhone = ClPhonetxt.Text.Trim(),
            };
            clients = clientDataAccess.GetSodata(selectCondition);

        }
        private void datedubblwget()
        {
            M_Client selectCondition = new M_Client()
            {
                ClID = int.Parse(ClIDtxt.Text.Trim()),
                SoID = int.Parse(SOIDtxt.Text.Trim()),
                ClName = CLNametxt.Text.Trim(),
                ClPhone = ClPhonetxt.Text.Trim(),
            };
            clients = clientDataAccess.Getdubblwdata(selectCondition);

        }
        private void datenolwget()
        {
            M_Client selectCondition = new M_Client()
            {
                ClName = CLNametxt.Text.Trim(),
                ClPhone = ClPhonetxt.Text.Trim(),
            };
            clients = clientDataAccess.Getnodata(selectCondition);

        }
        private void SetFormDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "10";
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SetDataGridView();

        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridView1.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int number;
            number = (int)dataGridView1.CurrentRow.Cells[0].Value;
            label5.Text = number.ToString();

            serchdateset(number);
            setdatedetail();            
        }

        private void serchdateset(int number)
        {

            M_clhistory selectCondition = new M_clhistory
            {
                ClID = number.ToString()                
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
        private void label9_Click(object sender, EventArgs e)
        {
            /*
            ClIDtxt.Visible = false;
            datetime.Visible = false;
            userid.Visible = false;
            username.Visible = false;
            uptime.Visible = false;
            upuserid.Visible = false;
            upusername.Visible = false;
             */
        }

    }
}
