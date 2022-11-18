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
            label5.Visible=true;
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
            SetFormDataGridView();
            invcnt();
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
        private void dateClget()
        {
            M_Client selectCondition = new M_Client()
            {
                ClID = int.Parse(ClIDtxt.Text.Trim()),
                ClName = CLNametxt.Text.Trim(),
                ClPhone = ClPhonetxt.Text.Trim(),
                ClAddress= addresstxt.Text.Trim(),
                ClFAX= ClPostaltxt.Text.Trim(),
                ClPostal= ClFaxtxt.Text.Trim()
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
                ClAddress = addresstxt.Text.Trim(),
                ClFAX = ClPostaltxt.Text.Trim(),
                ClPostal = ClFaxtxt.Text.Trim()
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
                ClAddress = addresstxt.Text.Trim(),
                ClFAX = ClPostaltxt.Text.Trim(),
                ClPostal = ClFaxtxt.Text.Trim()
            };
            clients = clientDataAccess.Getdubblwdata(selectCondition);
        }
        private void datenolwget()
        {
            M_Client selectCondition = new M_Client()
            {
                ClName = CLNametxt.Text.Trim(),
                ClPhone = ClPhonetxt.Text.Trim(),
                ClAddress = addresstxt.Text.Trim(),
                ClFAX = ClPostaltxt.Text.Trim(),
                ClPostal = ClFaxtxt.Text.Trim()
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

        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridView1.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();
            labelPage.Text = "/" + ((int)Math.Ceiling(clients.Count / (double)pageSize)) + "ページ";

            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            dataGridView1.DataSource = clients.Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        //ここから右側↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int number;
            int ClIDtxt;
            number = (int)dataGridView1.CurrentRow.Cells[1].Value;
            ClIDtxt= (int)dataGridView1.CurrentRow.Cells[0].Value;
            label5.Text = ClIDtxt.ToString();

            serchdateset(number);
            setdatedetail();            
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

        private void change_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridView1.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();
            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";

        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(clients.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridView1.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(clients.Count / (double)pageSize);
            if (pageNo >= lastPage)
                textBoxPageNo.Text = lastPage.ToString();
            else
                textBoxPageNo.Text = (pageNo + 1).ToString();

        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(clients.Count / (double)pageSize) - 1;
            dataGridView1.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }
    }
}
