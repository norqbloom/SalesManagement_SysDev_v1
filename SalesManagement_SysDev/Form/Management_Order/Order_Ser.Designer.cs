﻿
namespace SalesManagement_SysDev.Management_Order
{
    partial class Order_Ser
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
            this.button_Ser = new System.Windows.Forms.Button();
            this.textBoxClID = new System.Windows.Forms.TextBox();
            this.label_ClID = new System.Windows.Forms.Label();
            this.label_OrID = new System.Windows.Forms.Label();
            this.dateTimePickerOrDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmID = new System.Windows.Forms.TextBox();
            this.label_EmID = new System.Windows.Forms.Label();
            this.checkBoxOrStateFlag = new System.Windows.Forms.CheckBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.button_Cle = new System.Windows.Forms.Button();
            this.textBoxClChange = new System.Windows.Forms.TextBox();
            this.textBoxSoID = new System.Windows.Forms.TextBox();
            this.textBoxOrID = new System.Windows.Forms.TextBox();
            this.label_ClChange = new System.Windows.Forms.Label();
            this.label_SoID = new System.Windows.Forms.Label();
            this.label_EmHiredate = new System.Windows.Forms.Label();
            this.checkBoxOrFlag = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerOrDate2 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.textBoxPageNo = new System.Windows.Forms.TextBox();
            this.labelPage = new System.Windows.Forms.Label();
            this.button_First = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Ser
            // 
            this.button_Ser.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Ser.Location = new System.Drawing.Point(1034, 195);
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
            // label_OrID
            // 
            this.label_OrID.AutoSize = true;
            this.label_OrID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_OrID.Location = new System.Drawing.Point(26, 18);
            this.label_OrID.Name = "label_OrID";
            this.label_OrID.Size = new System.Drawing.Size(70, 25);
            this.label_OrID.TabIndex = 91;
            this.label_OrID.Text = "受注ID";
            // 
            // dateTimePickerOrDate
            // 
            this.dateTimePickerOrDate.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerOrDate.Location = new System.Drawing.Point(401, 74);
            this.dateTimePickerOrDate.Name = "dateTimePickerOrDate";
            this.dateTimePickerOrDate.Size = new System.Drawing.Size(237, 32);
            this.dateTimePickerOrDate.TabIndex = 110;
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
            // checkBoxOrStateFlag
            // 
            this.checkBoxOrStateFlag.AutoSize = true;
            this.checkBoxOrStateFlag.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.checkBoxOrStateFlag.Location = new System.Drawing.Point(274, 142);
            this.checkBoxOrStateFlag.Name = "checkBoxOrStateFlag";
            this.checkBoxOrStateFlag.Size = new System.Drawing.Size(149, 29);
            this.checkBoxOrStateFlag.TabIndex = 100;
            this.checkBoxOrStateFlag.Text = "受注状態フラグ";
            this.checkBoxOrStateFlag.UseVisualStyleBackColor = true;
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
            // textBoxClChange
            // 
            this.textBoxClChange.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxClChange.Location = new System.Drawing.Point(401, 15);
            this.textBoxClChange.Name = "textBoxClChange";
            this.textBoxClChange.Size = new System.Drawing.Size(237, 32);
            this.textBoxClChange.TabIndex = 96;
            // 
            // textBoxSoID
            // 
            this.textBoxSoID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxSoID.Location = new System.Drawing.Point(121, 77);
            this.textBoxSoID.Name = "textBoxSoID";
            this.textBoxSoID.Size = new System.Drawing.Size(100, 32);
            this.textBoxSoID.TabIndex = 95;
            // 
            // textBoxOrID
            // 
            this.textBoxOrID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxOrID.Location = new System.Drawing.Point(121, 15);
            this.textBoxOrID.Name = "textBoxOrID";
            this.textBoxOrID.Size = new System.Drawing.Size(100, 32);
            this.textBoxOrID.TabIndex = 94;
            // 
            // label_ClChange
            // 
            this.label_ClChange.AutoSize = true;
            this.label_ClChange.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_ClChange.Location = new System.Drawing.Point(269, 18);
            this.label_ClChange.Name = "label_ClChange";
            this.label_ClChange.Size = new System.Drawing.Size(126, 25);
            this.label_ClChange.TabIndex = 93;
            this.label_ClChange.Text = "受注担当者名";
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
            // label_EmHiredate
            // 
            this.label_EmHiredate.AutoSize = true;
            this.label_EmHiredate.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_EmHiredate.Location = new System.Drawing.Point(269, 80);
            this.label_EmHiredate.Name = "label_EmHiredate";
            this.label_EmHiredate.Size = new System.Drawing.Size(107, 25);
            this.label_EmHiredate.TabIndex = 109;
            this.label_EmHiredate.Text = "受注年月日";
            // 
            // checkBoxOrFlag
            // 
            this.checkBoxOrFlag.AutoSize = true;
            this.checkBoxOrFlag.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.checkBoxOrFlag.Location = new System.Drawing.Point(274, 195);
            this.checkBoxOrFlag.Name = "checkBoxOrFlag";
            this.checkBoxOrFlag.Size = new System.Drawing.Size(149, 29);
            this.checkBoxOrFlag.TabIndex = 119;
            this.checkBoxOrFlag.Text = "受注管理フラグ";
            this.checkBoxOrFlag.UseVisualStyleBackColor = true;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox1.Location = new System.Drawing.Point(678, 112);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 19);
            this.checkBox1.TabIndex = 123;
            this.checkBox1.Text = "日付検索";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(644, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 122;
            this.label1.Text = "から";
            // 
            // dateTimePickerOrDate2
            // 
            this.dateTimePickerOrDate2.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerOrDate2.Location = new System.Drawing.Point(678, 74);
            this.dateTimePickerOrDate2.Name = "dateTimePickerOrDate2";
            this.dateTimePickerOrDate2.Size = new System.Drawing.Size(237, 32);
            this.dateTimePickerOrDate2.TabIndex = 121;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Last);
            this.panel2.Controls.Add(this.button_Next);
            this.panel2.Controls.Add(this.button_Prev);
            this.panel2.Controls.Add(this.textBoxPageNo);
            this.panel2.Controls.Add(this.labelPage);
            this.panel2.Controls.Add(this.button_First);
            this.panel2.Location = new System.Drawing.Point(919, 905);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 35);
            this.panel2.TabIndex = 124;
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
            // Order_Ser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 970);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerOrDate2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxOrFlag);
            this.Controls.Add(this.button_Ser);
            this.Controls.Add(this.textBoxClID);
            this.Controls.Add(this.label_ClID);
            this.Controls.Add(this.label_OrID);
            this.Controls.Add(this.dateTimePickerOrDate);
            this.Controls.Add(this.textBoxEmID);
            this.Controls.Add(this.label_EmID);
            this.Controls.Add(this.checkBoxOrStateFlag);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.button_Cle);
            this.Controls.Add(this.textBoxClChange);
            this.Controls.Add(this.textBoxSoID);
            this.Controls.Add(this.textBoxOrID);
            this.Controls.Add(this.label_ClChange);
            this.Controls.Add(this.label_SoID);
            this.Controls.Add(this.label_EmHiredate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1658, 970);
            this.MinimumSize = new System.Drawing.Size(1658, 970);
            this.Name = "Order_Ser";
            this.Text = "Order_Ser";
            this.Load += new System.EventHandler(this.Order_Ser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Ser;
        private System.Windows.Forms.TextBox textBoxClID;
        private System.Windows.Forms.Label label_ClID;
        private System.Windows.Forms.Label label_OrID;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrDate;
        private System.Windows.Forms.TextBox textBoxEmID;
        private System.Windows.Forms.Label label_EmID;
        private System.Windows.Forms.CheckBox checkBoxOrStateFlag;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Button button_Cle;
        private System.Windows.Forms.TextBox textBoxClChange;
        private System.Windows.Forms.TextBox textBoxSoID;
        private System.Windows.Forms.TextBox textBoxOrID;
        private System.Windows.Forms.Label label_ClChange;
        private System.Windows.Forms.Label label_SoID;
        private System.Windows.Forms.Label label_EmHiredate;
        private System.Windows.Forms.CheckBox checkBoxOrFlag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrDate2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.TextBox textBoxPageNo;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button button_First;
    }
}