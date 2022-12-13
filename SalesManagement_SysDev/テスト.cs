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
            SetFormDataGridView();
            dateTimePickerOrDate.Value = DateTime.Now;
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
            SetFormDataGridView();
        }
        private void button_Del_Click(object sender, EventArgs e)
        {

        }

        private void button_Cle_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GetDataGridView();
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
                    MessageBox.Show("1");
                    //messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }

                if(textBoxOrID.TextLength > 6)
                {
                    MessageBox.Show("2");
                    //messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }

                if (orderDateAccess.CheckOrIDExistence(textBoxOrID.Text.Trim()))
                {
                    MessageBox.Show("3");
                    //messageDsp.DspMsg("");
                    textBoxOrID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("4");
                //messageDsp.DspMsg("");
                textBoxOrID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxSoID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxSoID.Text.Trim()))
                {
                    MessageBox.Show("5");
                    //messageDsp.DspMsg("");
                    textBoxSoID.Focus();
                    return false;
                }

                if (textBoxSoID.TextLength > 2)
                {
                    MessageBox.Show("6");
                    //messageDsp.DspMsg("");
                    textBoxSoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("7");
                //messageDsp.DspMsg("");
                textBoxSoID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxEmID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxEmID.Text.Trim()))
                {
                    MessageBox.Show("8");
                    //messageDsp.DspMsg("");
                    textBoxEmID.Focus();
                    return false;
                }

                if (textBoxEmID.TextLength > 6)
                {
                    MessageBox.Show("9");
                    //messageDsp.DspMsg("");
                    textBoxEmID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("10");
                //messageDsp.DspMsg("");
                textBoxEmID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxClID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(textBoxClID.Text.Trim()))
                {
                    MessageBox.Show("11");
                    //messageDsp.DspMsg("");
                    textBoxClID.Focus();
                    return false;
                }

                if (textBoxClID.TextLength > 6)
                {
                    MessageBox.Show("12");
                    //messageDsp.DspMsg("");
                    textBoxClID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("13");
                //messageDsp.DspMsg("");
                textBoxClID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(textBoxClChange.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckFullWidth(textBoxClChange.Text.Trim()))
                {
                    MessageBox.Show("14");
                    //messageDsp.DspMsg("");
                    textBoxClChange.Focus();
                    return false;
                }

                if (textBoxClChange.TextLength > 50)
                {
                    MessageBox.Show("15");
                    //messageDsp.DspMsg("");
                    textBoxClChange.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("16");
                //messageDsp.DspMsg("");
                textBoxClChange.Focus();
                return false;
            }

            if(checkBoxOrStateFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("17");
                //messageDsp.DspMsg("");
                checkBoxOrStateFlag.Focus();
                return false;
            }

            if (checkBoxOrFlag.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("18");
                //messageDsp.DspMsg("");
                checkBoxOrFlag.Focus();
                return false;
            }

            if (checkBoxOrFlag.Checked == true)
            {
                if (!String.IsNullOrEmpty(textBoxOrHidden.Text.Trim()))
                {
                    MessageBox.Show("19");
                    //messageDsp.DspMsg("");
                    checkBoxOrFlag.Focus();
                    return false;
                }
            }
            return true;
        }

        private T_Order GenerateDataAtRegistration()
        {
            int checkFlg;
            string hidden;
            if(checkBoxOrFlag.Checked == true)
            {
                checkFlg = 2;
            }
            else
            {
                checkFlg = 0;
            }
            
            if(checkFlg == 0)
            {
                hidden = String.Empty;
            }
            else
            {
                hidden = textBoxOrHidden.Text.Trim();
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
                OrHidden = hidden
            };
        }

        private void RegistrationOrder(T_Order regOrder)
        {
            DialogResult result = MessageBox.Show("20");
            //DialogResult result = messageDsp.DspMsg("");
            if(result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = orderDateAccess.AddorderData(regOrder);
            if(flg == true)
            {
                MessageBox.Show("21");
                //messageDsp.DspMsg("");
            }
            else
            {
                MessageBox.Show("22");
                //messageDsp.DspMsg("");
            }
            textBoxOrID.Focus();

            ClearInput();
        }

        private void SetFormDataGridView()
        {
            //dataGridViewのページサイズ指定
            textBoxPageSize.Text = "20";
            //dataGridViewのページ番号指定
            textBoxPageNo.Text = "1";
            //読み取り専用に指定
            dataGridViewDsp.ReadOnly = true;
            //行内をクリックすることで行を選択
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー位置の指定
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            int radioint = 0;
            if(radioButton1.Checked == true)
            {
                radioint = 2;
            }
            else
            {
                radioint = 0;
            }
            orders = orderDateAccess.GetOrderDataDsp(radioint);
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            int pageSize = int.Parse(textBoxPageSize.Text);
            int pageNo = int.Parse(textBoxPageNo.Text) - 1;
            dataGridViewDsp.DataSource = orders.Skip(pageSize * pageNo).Take(pageSize).ToList();
            dataGridViewDsp.Refresh();
            
            if (pageNo + 1 > 1)
                textBoxPageNo.Text = (pageNo + 1).ToString();
            else
                textBoxPageNo.Text = "1";
            
            dataGridViewDsp.DataSource = orders.Skip(pageSize * pageNo).Take(pageSize).ToList();
            
            foreach (DataGridViewColumn clm in dataGridViewDsp.Columns)
            {
                clm.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //各列幅の指定
            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 100;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 100;
            dataGridViewDsp.Columns[4].Width = 100;
            dataGridViewDsp.Columns[5].Width = 100;
            dataGridViewDsp.Columns[6].Width = 100;
            dataGridViewDsp.Columns[7].Width = 100;
            dataGridViewDsp.Columns[8].Width = 100;

            //各列の文字位置の指定
            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dataGridViewの総ページ数
            labelPage.Text = "/" + ((int)Math.Ceiling(orders.Count / (double)pageSize)) + "ページ";
        }

        
    }
}
