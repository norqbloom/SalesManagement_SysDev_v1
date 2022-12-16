using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Management_Chumon
{
    public partial class Chumon_Ser : Form
    {
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        MessageDsp messageDsp = new MessageDsp();
        ChumonDataAccess chumonDataAccess = new ChumonDataAccess();
        private static List<T_Chumon> chumons;
        private static List<T_Chhistory> history;

        public Chumon_Ser()
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

        private void Chumon_Ser_Load(object sender,EventArgs e)
        {
            SetFormDataGridView();
            invcnt();
        }

        private void buttonSer_Click(object sender, EventArgs e)
        {
            //入力データ確認
            if (!GetChumonDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }

        private bool GetChumonDataAtSelect()
        {
            //注文データの確認
            if (!String.IsNullOrEmpty(textBoxChID.Text.Trim()))
            {
                //文字種チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxChID.Text.Trim()))
                {
                    messageDsp.DspMsg("注文IDは6文字");
                    textBoxChID.Focus();
                    return false;
                }
            }

            //営業所IDの確認
            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                //文字種チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    messageDsp.DspMsg("営業所IDは6文字");
                    textBoxSoID.Focus();
                    return false;
                }
            }

            //社員IDの確認
            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                //文字種チェック
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    messageDsp.DspMsg("社員IDは6もじょ");
                    textBoxEmID.Focus();
                    return false;
                }
            }

            return true;
        }

        private void GenerateDataAtSelect()
        {
            if (!String.IsNullOrEmpty(textBoxChID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                    {
                        //全て入力されている
                        datedubblwget();
                        return;
                    }
                    else
                    {
                        //注文・営業所のみ
                        dateChSoget();
                        return;
                    }
                }
                else
                {
                    //注文・社員のみ
                    dateChEmget();
                    return;
                }
            }
            else if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
                {
                    //営業所・社員のみ
                    dateSoEmget();
                    return;
                }
                else
                {
                    //営業所のみ
                    dateSoget();
                    return;
                }
            }
            else if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                //社員のみ
                dateEmget();
                return;
            }
            else
            {
                //何も入力されていない
                datenolwget();
                return;
            }
        }

        private void SetSelectData()
        {
            dataGridView1.DataSource = chumons;
        }

        private void datedubblwget()
        {
            T_Chumon selectCondition = new T_Chumon()
            {
                ChID = int.Parse(textBoxChID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ChDate = DateTime.Parse(dateTimePickerChDate.Text.Trim())
            };
            chumons = chumonDataAccess.Getdubblwdata(selectCondition);
        }

        private void dateChSoget()
        {
            T_Chumon selectCondition = new T_Chumon()
            {
                ChID = int.Parse(textBoxChID.Text.Trim()),
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ChDate = DateTime.Parse(dateTimePickerChDate.Text.Trim())
            };
            chumons = chumonDataAccess.Getdubblwdata(selectCondition);
        }

        private void dateChEmget()
        {
            T_Chumon selectCondition = new T_Chumon()
            {
                ChID = int.Parse(textBoxChID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ChDate = DateTime.Parse(dateTimePickerChDate.Text.Trim())
            };
            chumons = chumonDataAccess.Getdubblwdata(selectCondition);
        }

        private void dateSoEmget()
        {
            T_Chumon selectCondition = new T_Chumon()
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ChDate = DateTime.Parse(dateTimePickerChDate.Text.Trim())
            };
            chumons = chumonDataAccess.Getdubblwdata(selectCondition);
        }

        private void dateSoget()
        {
            T_Chumon selectCondition = new T_Chumon()
            {
                SoID = int.Parse(textBoxSoID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ChDate = DateTime.Parse(dateTimePickerChDate.Text.Trim())
            };
            chumons = chumonDataAccess.Getdubblwdata(selectCondition);
        }
        private void dateEmget()
        {
            T_Chumon selectCondition = new T_Chumon()
            {
                EmID = int.Parse(textBoxEmID.Text.Trim()),
                ClID = int.Parse(textBoxClID.Text.Trim()),
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ChDate = DateTime.Parse(dateTimePickerChDate.Text.Trim())
            };
            chumons = chumonDataAccess.Getdubblwdata(selectCondition);
        }
        private void datenolwget()
        {
            T_Chumon selectCondition = new T_Chumon()
            {
                ClID = int.Parse(textBoxClID.Text.Trim()),
                OrID = int.Parse(textBoxOrID.Text.Trim()),
                ChDate = DateTime.Parse(dateTimePickerChDate.Text.Trim())
            };
            chumons = chumonDataAccess.Getdubblwdata(selectCondition);
        }

        private void SetFormDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "10";
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridView1.DataSource = chumons.Skip(pageSize * pageNo).Take(pageSize).ToList();
            labelPage.Text = "/" + ((int)Math.Ceiling(chumons.Count / (double)pageSize)) + "ページ";

            dataGridView1.Refresh();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCon_Click(object sender, EventArgs e)
        {
            var conCh = GenerateDataAtConfirm();
            ConfirmChumon(conCh);
        }

         private T_Chumon GenerateDataAtConfirm()
        {

            
            int checkflg;
            if (checkBoxChStateFlag.Checked == true)
            {
                checkflg = 1;
            }
            else
            {
                checkflg = 0;
            }
            return new T_Chumon
            {
                ChStateFlag = 1
            };
        }

        private T_Chumon GenerateDataAtConfirm()

        {
            int checkflg;
            if (checkBoxChStateFlag.Checked == true)
            {
                checkflg = 1;
            }
            else
            {
                checkflg = 0;
            }
            return new T_Chumon
            {
                ChID = int.Parse(textBoxChID.Text),
                SoID = int.Parse(textBoxSoID.Text),
                EmID = int.Parse(textBoxEmID.Text),
                ClID = int.Parse(textBoxClID.Text),
                OrID = int.Parse(textBoxOrID.Text),
                ChDate = DateTime.Parse(dateTimePickerChDate.Text),
                ChStateFlag = checkflg
            };
        }
        //private void ConfirmChumon(T_Chumon conChumon)
        //{

       

        //T_ChumonのChStateFlag
>>>>>>> 30559a188b110d73035309cb806a768d3c6e894c

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int number;
            int ClIDtxt;
            number = (int)dataGridView1.CurrentRow.Cells[1].Value;
            ClIDtxt = (int)dataGridView1.CurrentRow.Cells[0].Value;
            label5.Text = ClIDtxt.ToString();

            serchdateset(number);
            setdatedetail();
        }

        private void serchdateset(int number)
        {
            T_Chhistory selectCondition = new T_Chhistory
            {
                ChID = number.ToString(),
            };
            history = chumonDataAccess.getdetail(selectCondition);
        }

        private void setdatedetail()
        {
            var x = history.FirstOrDefault();
            if (x == null)
            {
                invcnt();
                return;
            }

            IDtxt.Text = x.ChID;
            datetime.Text = x.RegisteredDate;
            userid.Text = x.regUserID;
            username.Text = x.regUserName;
            uptime.Text = x.UpdateTime;
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

        private void change_Click_1(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void buttonFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            dataGridView1.DataSource = chumons.Take(pageSize).ToList();
            //DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = "1";
        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 2;
            dataGridView1.DataSource = chumons.Skip(pageSize * pageNo).Take(pageSize).ToList();
            //DataGridViewを更新
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
            int lastNo = (int)Math.Ceiling(chumons.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridView1.DataSource = chumons.Skip(pageSize * pageNo).Take(pageSize).ToList();

            //DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(chumons.Count / (double)pageSize);
            if (pageNo >= lastPage)
                textBoxPageNo.Text = lastPage.ToString();
            else
                textBoxPageNo.Text = (pageNo + 1).ToString();
        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(chumons.Count / (double)pageSize) - 1;
            dataGridView1.DataSource = chumons.Skip(pageSize * pageNo).Take(pageSize).ToList();

            //DataGridViewを更新
            dataGridView1.Refresh();
            //ページ番号の設定
            textBoxPageNo.Text = (pageNo + 1).ToString();
        }
    }
}
   