﻿
namespace SalesManagement_SysDev.Management_Hattyu
{
    partial class Hattyu_Ser
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
            this.Hattyu_Ser_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HaID = new System.Windows.Forms.TextBox();
            this.MaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HaHidden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hattyu_Del_Button = new System.Windows.Forms.Button();
            this.HaDate = new System.Windows.Forms.DateTimePicker();
            this.WaWarehouseFlag = new System.Windows.Forms.CheckBox();
            this.HaFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hattyu_Ser_Button
            // 
            this.Hattyu_Ser_Button.Location = new System.Drawing.Point(879, 241);
            this.Hattyu_Ser_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hattyu_Ser_Button.Name = "Hattyu_Ser_Button";
            this.Hattyu_Ser_Button.Size = new System.Drawing.Size(134, 110);
            this.Hattyu_Ser_Button.TabIndex = 0;
            this.Hattyu_Ser_Button.Text = "検索";
            this.Hattyu_Ser_Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "発注ID";
            // 
            // HaID
            // 
            this.HaID.Location = new System.Drawing.Point(304, 48);
            this.HaID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HaID.Name = "HaID";
            this.HaID.Size = new System.Drawing.Size(81, 22);
            this.HaID.TabIndex = 2;
            // 
            // MaID
            // 
            this.MaID.Location = new System.Drawing.Point(304, 100);
            this.MaID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaID.Name = "MaID";
            this.MaID.Size = new System.Drawing.Size(81, 22);
            this.MaID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "メーカID";
            // 
            // EmID
            // 
            this.EmID.Location = new System.Drawing.Point(304, 152);
            this.EmID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmID.Name = "EmID";
            this.EmID.Size = new System.Drawing.Size(81, 22);
            this.EmID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "発注社員ID";
            // 
            // HaHidden
            // 
            this.HaHidden.Location = new System.Drawing.Point(858, 48);
            this.HaHidden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HaHidden.Name = "HaHidden";
            this.HaHidden.Size = new System.Drawing.Size(81, 22);
            this.HaHidden.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "発注年月日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "入庫済フラグ（倉庫）";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "発注管理フラグ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(765, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "非表示理由";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 379);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(947, 267);
            this.dataGridView1.TabIndex = 15;
            // 
            // Hattyu_Del_Button
            // 
            this.Hattyu_Del_Button.Location = new System.Drawing.Point(720, 241);
            this.Hattyu_Del_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hattyu_Del_Button.Name = "Hattyu_Del_Button";
            this.Hattyu_Del_Button.Size = new System.Drawing.Size(134, 110);
            this.Hattyu_Del_Button.TabIndex = 16;
            this.Hattyu_Del_Button.Text = "削除";
            this.Hattyu_Del_Button.UseVisualStyleBackColor = true;
            // 
            // HaDate
            // 
            this.HaDate.Location = new System.Drawing.Point(570, 48);
            this.HaDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HaDate.Name = "HaDate";
            this.HaDate.Size = new System.Drawing.Size(161, 22);
            this.HaDate.TabIndex = 17;
            // 
            // WaWarehouseFlag
            // 
            this.WaWarehouseFlag.AutoSize = true;
            this.WaWarehouseFlag.Location = new System.Drawing.Point(570, 90);
            this.WaWarehouseFlag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WaWarehouseFlag.Name = "WaWarehouseFlag";
            this.WaWarehouseFlag.Size = new System.Drawing.Size(34, 19);
            this.WaWarehouseFlag.TabIndex = 18;
            this.WaWarehouseFlag.Text = " ";
            this.WaWarehouseFlag.UseVisualStyleBackColor = true;
            // 
            // HaFlag
            // 
            this.HaFlag.AutoSize = true;
            this.HaFlag.Location = new System.Drawing.Point(570, 133);
            this.HaFlag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HaFlag.Name = "HaFlag";
            this.HaFlag.Size = new System.Drawing.Size(34, 19);
            this.HaFlag.TabIndex = 19;
            this.HaFlag.Text = " ";
            this.HaFlag.UseVisualStyleBackColor = true;
            // 
            // Hattyu_Ser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 673);
            this.Controls.Add(this.HaFlag);
            this.Controls.Add(this.WaWarehouseFlag);
            this.Controls.Add(this.HaDate);
            this.Controls.Add(this.Hattyu_Del_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HaHidden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HaID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hattyu_Ser_Button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hattyu_Ser";
            this.Text = "Hattyu_Ser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hattyu_Ser_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HaID;
        private System.Windows.Forms.TextBox MaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HaHidden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Hattyu_Del_Button;
        private System.Windows.Forms.DateTimePicker HaDate;
        private System.Windows.Forms.CheckBox WaWarehouseFlag;
        private System.Windows.Forms.CheckBox HaFlag;
    }
}