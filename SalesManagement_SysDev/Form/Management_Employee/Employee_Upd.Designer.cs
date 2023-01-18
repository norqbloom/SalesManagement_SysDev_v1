
namespace SalesManagement_SysDev.Management_Employee
{
    partial class Employee_Upd
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
            this.checkBoxEmFlag = new System.Windows.Forms.CheckBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.button_Cle = new System.Windows.Forms.Button();
            this.button_Upd = new System.Windows.Forms.Button();
            this.textBoxEmName = new System.Windows.Forms.TextBox();
            this.textBoxSoID = new System.Windows.Forms.TextBox();
            this.textBoxEmID = new System.Windows.Forms.TextBox();
            this.label_EmName = new System.Windows.Forms.Label();
            this.label_SoID = new System.Windows.Forms.Label();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPageNo = new System.Windows.Forms.TextBox();
            this.button_First = new System.Windows.Forms.Button();
            this.label_EmHiredate = new System.Windows.Forms.Label();
            this.label_PrHidden = new System.Windows.Forms.Label();
            this.textBoxEmHidden = new System.Windows.Forms.TextBox();
            this.textBoxEmPhone = new System.Windows.Forms.TextBox();
            this.label_EmPhone = new System.Windows.Forms.Label();
            this.textBoxPoID = new System.Windows.Forms.TextBox();
            this.label_PoID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPage = new System.Windows.Forms.Label();
            this.label_EmID = new System.Windows.Forms.Label();
            this.dateTimePickerEmHiredate = new System.Windows.Forms.DateTimePicker();
            this.button_Del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxEmFlag
            // 
            this.checkBoxEmFlag.AutoSize = true;
            this.checkBoxEmFlag.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.checkBoxEmFlag.Location = new System.Drawing.Point(990, 50);
            this.checkBoxEmFlag.Name = "checkBoxEmFlag";
            this.checkBoxEmFlag.Size = new System.Drawing.Size(149, 29);
            this.checkBoxEmFlag.TabIndex = 77;
            this.checkBoxEmFlag.Text = "社員管理フラグ";
            this.checkBoxEmFlag.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(31, 246);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowTemplate.Height = 21;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1175, 662);
            this.dataGridViewDsp.TabIndex = 76;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // button_Cle
            // 
            this.button_Cle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Cle.Location = new System.Drawing.Point(1131, 204);
            this.button_Cle.Name = "button_Cle";
            this.button_Cle.Size = new System.Drawing.Size(75, 36);
            this.button_Cle.TabIndex = 75;
            this.button_Cle.Text = "クリア";
            this.button_Cle.UseVisualStyleBackColor = true;
            this.button_Cle.Click += new System.EventHandler(this.button_Cle_Click);
            // 
            // button_Upd
            // 
            this.button_Upd.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Upd.Location = new System.Drawing.Point(969, 204);
            this.button_Upd.Name = "button_Upd";
            this.button_Upd.Size = new System.Drawing.Size(75, 36);
            this.button_Upd.TabIndex = 74;
            this.button_Upd.Text = "更新";
            this.button_Upd.UseVisualStyleBackColor = true;
            this.button_Upd.Click += new System.EventHandler(this.button_Upd_Click);
            // 
            // textBoxEmName
            // 
            this.textBoxEmName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxEmName.Location = new System.Drawing.Point(406, 48);
            this.textBoxEmName.Name = "textBoxEmName";
            this.textBoxEmName.Size = new System.Drawing.Size(237, 32);
            this.textBoxEmName.TabIndex = 73;
            // 
            // textBoxSoID
            // 
            this.textBoxSoID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxSoID.Location = new System.Drawing.Point(133, 110);
            this.textBoxSoID.Name = "textBoxSoID";
            this.textBoxSoID.Size = new System.Drawing.Size(100, 32);
            this.textBoxSoID.TabIndex = 72;
            // 
            // textBoxEmID
            // 
            this.textBoxEmID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxEmID.Location = new System.Drawing.Point(133, 48);
            this.textBoxEmID.Name = "textBoxEmID";
            this.textBoxEmID.Size = new System.Drawing.Size(100, 32);
            this.textBoxEmID.TabIndex = 71;
            // 
            // label_EmName
            // 
            this.label_EmName.AutoSize = true;
            this.label_EmName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_EmName.Location = new System.Drawing.Point(284, 51);
            this.label_EmName.Name = "label_EmName";
            this.label_EmName.Size = new System.Drawing.Size(69, 25);
            this.label_EmName.TabIndex = 70;
            this.label_EmName.Text = "社員名";
            // 
            // label_SoID
            // 
            this.label_SoID.AutoSize = true;
            this.label_SoID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_SoID.Location = new System.Drawing.Point(38, 113);
            this.label_SoID.Name = "label_SoID";
            this.label_SoID.Size = new System.Drawing.Size(89, 25);
            this.label_SoID.TabIndex = 69;
            this.label_SoID.Text = "営業所ID";
            // 
            // button_Last
            // 
            this.button_Last.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Last.Location = new System.Drawing.Point(234, 0);
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
            this.button_Next.Location = new System.Drawing.Point(193, 0);
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
            this.button_Prev.Location = new System.Drawing.Point(152, 0);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(35, 35);
            this.button_Prev.TabIndex = 49;
            this.button_Prev.Text = "◀";
            this.button_Prev.UseVisualStyleBackColor = true;
            this.button_Prev.Click += new System.EventHandler(this.button_Prev_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1358, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 970);
            this.panel1.TabIndex = 78;
            // 
            // textBoxPageNo
            // 
            this.textBoxPageNo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPageNo.Location = new System.Drawing.Point(18, 6);
            this.textBoxPageNo.Name = "textBoxPageNo";
            this.textBoxPageNo.Size = new System.Drawing.Size(33, 25);
            this.textBoxPageNo.TabIndex = 45;
            this.textBoxPageNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_First
            // 
            this.button_First.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_First.Location = new System.Drawing.Point(111, 0);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(35, 35);
            this.button_First.TabIndex = 48;
            this.button_First.Text = "|◀";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // label_EmHiredate
            // 
            this.label_EmHiredate.AutoSize = true;
            this.label_EmHiredate.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_EmHiredate.Location = new System.Drawing.Point(284, 176);
            this.label_EmHiredate.Name = "label_EmHiredate";
            this.label_EmHiredate.Size = new System.Drawing.Size(107, 25);
            this.label_EmHiredate.TabIndex = 86;
            this.label_EmHiredate.Text = "入社年月日";
            // 
            // label_PrHidden
            // 
            this.label_PrHidden.AutoSize = true;
            this.label_PrHidden.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_PrHidden.Location = new System.Drawing.Point(985, 82);
            this.label_PrHidden.Name = "label_PrHidden";
            this.label_PrHidden.Size = new System.Drawing.Size(183, 25);
            this.label_PrHidden.TabIndex = 85;
            this.label_PrHidden.Text = "削除理由（非表示）";
            // 
            // textBoxEmHidden
            // 
            this.textBoxEmHidden.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxEmHidden.Location = new System.Drawing.Point(990, 110);
            this.textBoxEmHidden.Multiline = true;
            this.textBoxEmHidden.Name = "textBoxEmHidden";
            this.textBoxEmHidden.Size = new System.Drawing.Size(187, 57);
            this.textBoxEmHidden.TabIndex = 84;
            // 
            // textBoxEmPhone
            // 
            this.textBoxEmPhone.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxEmPhone.Location = new System.Drawing.Point(406, 110);
            this.textBoxEmPhone.Name = "textBoxEmPhone";
            this.textBoxEmPhone.Size = new System.Drawing.Size(237, 32);
            this.textBoxEmPhone.TabIndex = 83;
            // 
            // label_EmPhone
            // 
            this.label_EmPhone.AutoSize = true;
            this.label_EmPhone.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_EmPhone.Location = new System.Drawing.Point(284, 113);
            this.label_EmPhone.Name = "label_EmPhone";
            this.label_EmPhone.Size = new System.Drawing.Size(88, 25);
            this.label_EmPhone.TabIndex = 82;
            this.label_EmPhone.Text = "電話番号";
            // 
            // textBoxPoID
            // 
            this.textBoxPoID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPoID.Location = new System.Drawing.Point(133, 173);
            this.textBoxPoID.Name = "textBoxPoID";
            this.textBoxPoID.Size = new System.Drawing.Size(100, 32);
            this.textBoxPoID.TabIndex = 81;
            // 
            // label_PoID
            // 
            this.label_PoID.AutoSize = true;
            this.label_PoID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_PoID.Location = new System.Drawing.Point(38, 176);
            this.label_PoID.Name = "label_PoID";
            this.label_PoID.Size = new System.Drawing.Size(70, 25);
            this.label_PoID.TabIndex = 80;
            this.label_PoID.Text = "役職ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Last);
            this.panel2.Controls.Add(this.button_First);
            this.panel2.Controls.Add(this.button_Next);
            this.panel2.Controls.Add(this.labelPage);
            this.panel2.Controls.Add(this.textBoxPageNo);
            this.panel2.Controls.Add(this.button_Prev);
            this.panel2.Location = new System.Drawing.Point(936, 914);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 35);
            this.panel2.TabIndex = 79;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPage.Location = new System.Drawing.Point(57, 9);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(39, 17);
            this.labelPage.TabIndex = 46;
            this.labelPage.Text = "ページ";
            // 
            // label_EmID
            // 
            this.label_EmID.AutoSize = true;
            this.label_EmID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_EmID.Location = new System.Drawing.Point(38, 51);
            this.label_EmID.Name = "label_EmID";
            this.label_EmID.Size = new System.Drawing.Size(70, 25);
            this.label_EmID.TabIndex = 68;
            this.label_EmID.Text = "社員ID";
            // 
            // dateTimePickerEmHiredate
            // 
            this.dateTimePickerEmHiredate.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerEmHiredate.Location = new System.Drawing.Point(406, 170);
            this.dateTimePickerEmHiredate.Name = "dateTimePickerEmHiredate";
            this.dateTimePickerEmHiredate.Size = new System.Drawing.Size(237, 32);
            this.dateTimePickerEmHiredate.TabIndex = 87;
            // 
            // button_Del
            // 
            this.button_Del.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Del.Location = new System.Drawing.Point(1050, 204);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(75, 36);
            this.button_Del.TabIndex = 140;
            this.button_Del.Text = "削除";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // Employee_Upd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 970);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.checkBoxEmFlag);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.button_Cle);
            this.Controls.Add(this.button_Upd);
            this.Controls.Add(this.textBoxEmName);
            this.Controls.Add(this.textBoxSoID);
            this.Controls.Add(this.textBoxEmID);
            this.Controls.Add(this.label_EmName);
            this.Controls.Add(this.label_SoID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_EmHiredate);
            this.Controls.Add(this.label_PrHidden);
            this.Controls.Add(this.textBoxEmHidden);
            this.Controls.Add(this.textBoxEmPhone);
            this.Controls.Add(this.label_EmPhone);
            this.Controls.Add(this.textBoxPoID);
            this.Controls.Add(this.label_PoID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_EmID);
            this.Controls.Add(this.dateTimePickerEmHiredate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1658, 970);
            this.MinimumSize = new System.Drawing.Size(1658, 970);
            this.Name = "Employee_Upd";
            this.Text = "Employee_Upd";
            this.Load += new System.EventHandler(this.Employee_Upd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEmFlag;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Button button_Cle;
        private System.Windows.Forms.Button button_Upd;
        private System.Windows.Forms.TextBox textBoxEmName;
        private System.Windows.Forms.TextBox textBoxSoID;
        private System.Windows.Forms.TextBox textBoxEmID;
        private System.Windows.Forms.Label label_EmName;
        private System.Windows.Forms.Label label_SoID;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPageNo;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Label label_EmHiredate;
        private System.Windows.Forms.Label label_PrHidden;
        private System.Windows.Forms.TextBox textBoxEmHidden;
        private System.Windows.Forms.TextBox textBoxEmPhone;
        private System.Windows.Forms.Label label_EmPhone;
        private System.Windows.Forms.TextBox textBoxPoID;
        private System.Windows.Forms.Label label_PoID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Label label_EmID;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmHiredate;
        private System.Windows.Forms.Button button_Del;
    }
}