
namespace SalesManagement_SysDev.Management_Chumon
{
    partial class Chumon_Ser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ChHiredate = new System.Windows.Forms.Label();
            this.labelPage = new System.Windows.Forms.Label();
            this.textBoxChID = new System.Windows.Forms.TextBox();
            this.label_SoID = new System.Windows.Forms.Label();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.textBoxPageNo = new System.Windows.Forms.TextBox();
            this.button_Cle = new System.Windows.Forms.Button();
            this.textBoxSoID = new System.Windows.Forms.TextBox();
            this.button_First = new System.Windows.Forms.Button();
            this.button_Ser = new System.Windows.Forms.Button();
            this.textBoxClID = new System.Windows.Forms.TextBox();
            this.label_ClID = new System.Windows.Forms.Label();
            this.label_ChID = new System.Windows.Forms.Label();
            this.dateTimePickerChDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmID = new System.Windows.Forms.TextBox();
            this.label_EmID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxChStateFlag = new System.Windows.Forms.CheckBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.textBoxOrID = new System.Windows.Forms.TextBox();
            this.label_OrID = new System.Windows.Forms.Label();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Con = new System.Windows.Forms.Button();
            this.label_ChHidden = new System.Windows.Forms.Label();
            this.textBoxChHidden = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1358, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 970);
            this.panel1.TabIndex = 120;
            // 
            // label_ChHiredate
            // 
            this.label_ChHiredate.AutoSize = true;
            this.label_ChHiredate.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_ChHiredate.Location = new System.Drawing.Point(269, 80);
            this.label_ChHiredate.Name = "label_ChHiredate";
            this.label_ChHiredate.Size = new System.Drawing.Size(107, 25);
            this.label_ChHiredate.TabIndex = 109;
            this.label_ChHiredate.Text = "注文年月日";
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPage.Location = new System.Drawing.Point(55, 9);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(39, 17);
            this.labelPage.TabIndex = 46;
            this.labelPage.Text = "ページ";
            // 
            // textBoxChID
            // 
            this.textBoxChID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxChID.Location = new System.Drawing.Point(121, 15);
            this.textBoxChID.Name = "textBoxChID";
            this.textBoxChID.Size = new System.Drawing.Size(100, 32);
            this.textBoxChID.TabIndex = 94;
            // 
            // label_SoID
            // 
            this.label_SoID.AutoSize = true;
            this.label_SoID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_SoID.Location = new System.Drawing.Point(26, 80);
            this.label_SoID.Name = "label_SoID";
            this.label_SoID.Size = new System.Drawing.Size(89, 25);
            this.label_SoID.TabIndex = 92;
            this.label_SoID.Text = "営業所ID";
            // 
            // button_Last
            // 
            this.button_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Last.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Last.Location = new System.Drawing.Point(235, 0);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(35, 35);
            this.button_Last.TabIndex = 47;
            this.button_Last.Text = "▶|";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // button_Next
            // 
            this.button_Next.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Next.Location = new System.Drawing.Point(194, 0);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(35, 35);
            this.button_Next.TabIndex = 50;
            this.button_Next.Text = "▶";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Prev
            // 
            this.button_Prev.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Prev.Location = new System.Drawing.Point(153, 0);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(35, 35);
            this.button_Prev.TabIndex = 49;
            this.button_Prev.Text = "◀";
            this.button_Prev.UseVisualStyleBackColor = true;
            this.button_Prev.Click += new System.EventHandler(this.button_Prev_Click);
            // 
            // textBoxPageNo
            // 
            this.textBoxPageNo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPageNo.Location = new System.Drawing.Point(16, 6);
            this.textBoxPageNo.Name = "textBoxPageNo";
            this.textBoxPageNo.Size = new System.Drawing.Size(33, 25);
            this.textBoxPageNo.TabIndex = 45;
            this.textBoxPageNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Cle
            // 
            this.button_Cle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Cle.Location = new System.Drawing.Point(1115, 195);
            this.button_Cle.Name = "button_Cle";
            this.button_Cle.Size = new System.Drawing.Size(75, 36);
            this.button_Cle.TabIndex = 98;
            this.button_Cle.Text = "クリア";
            this.button_Cle.UseVisualStyleBackColor = true;
            this.button_Cle.Click += new System.EventHandler(this.button_Cle_Click);
            // 
            // textBoxSoID
            // 
            this.textBoxSoID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxSoID.Location = new System.Drawing.Point(121, 77);
            this.textBoxSoID.Name = "textBoxSoID";
            this.textBoxSoID.Size = new System.Drawing.Size(100, 32);
            this.textBoxSoID.TabIndex = 95;
            // 
            // button_First
            // 
            this.button_First.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_First.Location = new System.Drawing.Point(112, 0);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(35, 35);
            this.button_First.TabIndex = 48;
            this.button_First.Text = "|◀";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // button_Ser
            // 
            this.button_Ser.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Ser.Location = new System.Drawing.Point(872, 195);
            this.button_Ser.Name = "button_Ser";
            this.button_Ser.Size = new System.Drawing.Size(75, 36);
            this.button_Ser.TabIndex = 118;
            this.button_Ser.Text = "検索";
            this.button_Ser.UseVisualStyleBackColor = true;
            this.button_Ser.Click += new System.EventHandler(this.button_Ser_Click);
            // 
            // textBoxClID
            // 
            this.textBoxClID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxClID.Location = new System.Drawing.Point(121, 193);
            this.textBoxClID.Name = "textBoxClID";
            this.textBoxClID.Size = new System.Drawing.Size(100, 32);
            this.textBoxClID.TabIndex = 117;
            // 
            // label_ClID
            // 
            this.label_ClID.AutoSize = true;
            this.label_ClID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_ClID.Location = new System.Drawing.Point(26, 196);
            this.label_ClID.Name = "label_ClID";
            this.label_ClID.Size = new System.Drawing.Size(70, 25);
            this.label_ClID.TabIndex = 116;
            this.label_ClID.Text = "顧客ID";
            // 
            // label_ChID
            // 
            this.label_ChID.AutoSize = true;
            this.label_ChID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_ChID.Location = new System.Drawing.Point(26, 18);
            this.label_ChID.Name = "label_ChID";
            this.label_ChID.Size = new System.Drawing.Size(70, 25);
            this.label_ChID.TabIndex = 91;
            this.label_ChID.Text = "注文ID";
            // 
            // dateTimePickerChDate
            // 
            this.dateTimePickerChDate.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerChDate.Location = new System.Drawing.Point(392, 74);
            this.dateTimePickerChDate.Name = "dateTimePickerChDate";
            this.dateTimePickerChDate.Size = new System.Drawing.Size(237, 32);
            this.dateTimePickerChDate.TabIndex = 110;
            // 
            // textBoxEmID
            // 
            this.textBoxEmID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxEmID.Location = new System.Drawing.Point(121, 140);
            this.textBoxEmID.Name = "textBoxEmID";
            this.textBoxEmID.Size = new System.Drawing.Size(100, 32);
            this.textBoxEmID.TabIndex = 104;
            // 
            // label_EmID
            // 
            this.label_EmID.AutoSize = true;
            this.label_EmID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_EmID.Location = new System.Drawing.Point(26, 143);
            this.label_EmID.Name = "label_EmID";
            this.label_EmID.Size = new System.Drawing.Size(70, 25);
            this.label_EmID.TabIndex = 103;
            this.label_EmID.Text = "社員ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Last);
            this.panel2.Controls.Add(this.button_Next);
            this.panel2.Controls.Add(this.button_Prev);
            this.panel2.Controls.Add(this.textBoxPageNo);
            this.panel2.Controls.Add(this.labelPage);
            this.panel2.Controls.Add(this.button_First);
            this.panel2.Location = new System.Drawing.Point(920, 905);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 35);
            this.panel2.TabIndex = 102;
            // 
            // checkBoxChStateFlag
            // 
            this.checkBoxChStateFlag.AutoSize = true;
            this.checkBoxChStateFlag.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.checkBoxChStateFlag.Location = new System.Drawing.Point(274, 142);
            this.checkBoxChStateFlag.Name = "checkBoxChStateFlag";
            this.checkBoxChStateFlag.Size = new System.Drawing.Size(149, 29);
            this.checkBoxChStateFlag.TabIndex = 100;
            this.checkBoxChStateFlag.Text = "注文状態フラグ";
            this.checkBoxChStateFlag.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(16, 237);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowTemplate.Height = 21;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1174, 662);
            this.dataGridViewDsp.TabIndex = 99;
            this.dataGridViewDsp.SelectionChanged += new System.EventHandler(this.dataGridViewDspOrder_SelectionChanged);
            // 
            // textBoxOrID
            // 
            this.textBoxOrID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxOrID.Location = new System.Drawing.Point(392, 15);
            this.textBoxOrID.Name = "textBoxOrID";
            this.textBoxOrID.Size = new System.Drawing.Size(100, 32);
            this.textBoxOrID.TabIndex = 125;
            // 
            // label_OrID
            // 
            this.label_OrID.AutoSize = true;
            this.label_OrID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_OrID.Location = new System.Drawing.Point(269, 22);
            this.label_OrID.Name = "label_OrID";
            this.label_OrID.Size = new System.Drawing.Size(70, 25);
            this.label_OrID.TabIndex = 124;
            this.label_OrID.Text = "受注ID";
            // 
            // button_Del
            // 
            this.button_Del.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Del.Location = new System.Drawing.Point(1034, 195);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(75, 36);
            this.button_Del.TabIndex = 126;
            this.button_Del.Text = "削除";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Con
            // 
            this.button_Con.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Con.Location = new System.Drawing.Point(953, 195);
            this.button_Con.Name = "button_Con";
            this.button_Con.Size = new System.Drawing.Size(75, 36);
            this.button_Con.TabIndex = 127;
            this.button_Con.Text = "確定";
            this.button_Con.UseVisualStyleBackColor = true;
            this.button_Con.Click += new System.EventHandler(this.button_Con_Click);
            // 
            // label_ChHidden
            // 
            this.label_ChHidden.AutoSize = true;
            this.label_ChHidden.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_ChHidden.Location = new System.Drawing.Point(429, 143);
            this.label_ChHidden.Name = "label_ChHidden";
            this.label_ChHidden.Size = new System.Drawing.Size(88, 25);
            this.label_ChHidden.TabIndex = 129;
            this.label_ChHidden.Text = "削除理由";
            // 
            // textBoxChHidden
            // 
            this.textBoxChHidden.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxChHidden.Location = new System.Drawing.Point(434, 171);
            this.textBoxChHidden.Multiline = true;
            this.textBoxChHidden.Name = "textBoxChHidden";
            this.textBoxChHidden.Size = new System.Drawing.Size(187, 57);
            this.textBoxChHidden.TabIndex = 128;
            // 
            // Chumon_Ser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 970);
            this.Controls.Add(this.label_ChHidden);
            this.Controls.Add(this.textBoxChHidden);
            this.Controls.Add(this.button_Con);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.textBoxOrID);
            this.Controls.Add(this.label_OrID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_ChHiredate);
            this.Controls.Add(this.textBoxChID);
            this.Controls.Add(this.label_SoID);
            this.Controls.Add(this.button_Cle);
            this.Controls.Add(this.textBoxSoID);
            this.Controls.Add(this.button_Ser);
            this.Controls.Add(this.textBoxClID);
            this.Controls.Add(this.label_ClID);
            this.Controls.Add(this.label_ChID);
            this.Controls.Add(this.dateTimePickerChDate);
            this.Controls.Add(this.textBoxEmID);
            this.Controls.Add(this.label_EmID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBoxChStateFlag);
            this.Controls.Add(this.dataGridViewDsp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1658, 970);
            this.MinimumSize = new System.Drawing.Size(1658, 970);
            this.Name = "Chumon_Ser";
            this.Text = "Chumon_Ser";
            this.Load += new System.EventHandler(this.Chumon_Ser_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ChHiredate;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.TextBox textBoxChID;
        private System.Windows.Forms.Label label_SoID;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.TextBox textBoxPageNo;
        private System.Windows.Forms.Button button_Cle;
        private System.Windows.Forms.TextBox textBoxSoID;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Button button_Ser;
        private System.Windows.Forms.TextBox textBoxClID;
        private System.Windows.Forms.Label label_ClID;
        private System.Windows.Forms.Label label_ChID;
        private System.Windows.Forms.DateTimePicker dateTimePickerChDate;
        private System.Windows.Forms.TextBox textBoxEmID;
        private System.Windows.Forms.Label label_EmID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxChStateFlag;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.TextBox textBoxOrID;
        private System.Windows.Forms.Label label_OrID;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Con;
        private System.Windows.Forms.Label label_ChHidden;
        private System.Windows.Forms.TextBox textBoxChHidden;
    }
}