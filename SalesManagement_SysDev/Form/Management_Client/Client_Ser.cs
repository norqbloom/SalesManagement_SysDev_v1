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
        private static int grid = 9;

        private void invcnt()
        {
            //label5.Visible = false;
            //IDtxt.Visible = false;
            //datetime.Visible = false;
            //userid.Visible = false;
            //username.Visible = false;
            //uptime.Visible = false;
            //upuserid.Visible = false;
            //upusername.Visible = false;
        }

        private void incntok()
        {
            //label5.Visible = true;
            //IDtxt.Visible = true;
            //datetime.Visible = true;
            //userid.Visible = true;
            //username.Visible = true;
            //uptime.Visible = true;
            //upuserid.Visible = true;
            //upusername.Visible = true;
        }

        public Client_Ser()
        {
            InitializeComponent();
        }

        private void Client_Ser_Load(object sender, EventArgs e)
        {
            //radioButton1.Checked = true;
            setdata();
            SetFormDataGridView();
            invcnt();
        }

        private void button_Ser_Click(object sender, EventArgs e)
        {
            //入力データ確認
            if (!GetClientDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }

        private void button_Cle_Click(object sender, EventArgs e)
        {
            textBoxClID.Text = "";
            textBoxClName.Text = "";
            textBoxSoID.Text = "";
            textBoxClPhone.Text = "";
            textBoxClAddress.Text = "";
            textBoxClPostal.Text = "";
            textBoxClFAX.Text = "";
            checkBoxClFlag.Checked = false;
        }

        private void button_First_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Prev_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Next_Click_1(object sender, EventArgs e)
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(clients.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(clients.Count / (double)pageSize);
            if (pageNo >= lastPage)
                textBoxPageNo.Text = lastPage.ToString();
            else
                textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void button_Last_Click_1(object sender, EventArgs e)
        {
            int pageSize = grid;
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(clients.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void setdata()
        {
            clients = clientDataAccess.GetClientDspData();
            dataGridViewDsp.DataSource = clients;
        }

        private bool GetClientDataAtSelect()
        {
            //CoID確認
            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                //数字チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    messageDsp.DspMsg("M1001"); //顧客IDは半角数字入力です
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
                    messageDsp.DspMsg("M1005"); //営業所IDは半角数字入力です
                    textBoxSoID.Focus();
                    return false;
                }
            }
            //Clphone確認
            if (!String.IsNullOrEmpty(textBoxClPhone.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckHalfChar(textBoxClPhone.Text.Trim()))
                {
                    messageDsp.DspMsg("M1015"); //電話番号は半角数値入力です
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
                ClFAX = textBoxClFAX.Text.Trim(),
                ClPostal = textBoxClPostal.Text.Trim()
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
                ClFAX = textBoxClFAX.Text.Trim(),
                ClPostal = textBoxClPostal.Text.Trim()
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
                ClFAX = textBoxClFAX.Text.Trim(),
                ClPostal = textBoxClPostal.Text.Trim()
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
                ClFAX = textBoxClFAX.Text.Trim(),
                ClPostal = textBoxClPostal.Text.Trim()
            };
            clients = clientDataAccess.Getnodata(selectCondition);

        }
        private void SetFormDataGridView()
        {
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDsp.ReadOnly = true;
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GetDataGridView();

        }
        private void SetDataGridView()
        {
            int pageSize = grid;
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = clients.Skip(pageSize * pageNo).Take(pageSize).ToList();
            labelPage.Text = "/" + ((int)Math.Ceiling(clients.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        //ここから右側↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int number;
            int ClIDtxt;
            number = (int)dataGridViewDsp.CurrentRow.Cells[1].Value;
            ClIDtxt = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            //label5.Text = ClIDtxt.ToString();
            MessageBox.Show(ClIDtxt.ToString());
            //label5.Text = ClIDtxt.ToString();

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

        private void GetDataGridView()
        {

            int radioint = 0;
            // 商品データの取得
            clients = clientDataAccess.GetProductDataDsp(radioint);
            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }

        private void dataGridViewDsp_SelectionChanged(object sender, EventArgs e)
        {
            int number;
            int ClIDtxt;
            number = (int)dataGridViewDsp.CurrentRow.Cells[1].Value;
            ClIDtxt = (int)dataGridViewDsp.CurrentRow.Cells[0].Value;
            //label5.Text = ClIDtxt.ToString();

            serchdateset(number);
            setdatedetail();
        }


    }
}
