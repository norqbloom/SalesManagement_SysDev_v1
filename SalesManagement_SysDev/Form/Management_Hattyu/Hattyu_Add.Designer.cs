
namespace SalesManagement_SysDev.Management_Hattyu
{
    partial class Hattyu_Add
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
            this.HaFlag = new System.Windows.Forms.CheckBox();
            this.WaWarehouseFlag = new System.Windows.Forms.CheckBox();
            this.HaDate = new System.Windows.Forms.DateTimePicker();
            this.Hattyu_Del_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HaHidden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hattyu_Add_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HaFlag
            // 
            this.HaFlag.AutoSize = true;
            this.HaFlag.Location = new System.Drawing.Point(252, 72);
            this.HaFlag.Margin = new System.Windows.Forms.Padding(1);
            this.HaFlag.Name = "HaFlag";
            this.HaFlag.Size = new System.Drawing.Size(28, 16);
            this.HaFlag.TabIndex = 36;
            this.HaFlag.Text = " ";
            this.HaFlag.UseVisualStyleBackColor = true;
            // 
            // WaWarehouseFlag
            // 
            this.WaWarehouseFlag.AutoSize = true;
            this.WaWarehouseFlag.Location = new System.Drawing.Point(252, 40);
            this.WaWarehouseFlag.Margin = new System.Windows.Forms.Padding(1);
            this.WaWarehouseFlag.Name = "WaWarehouseFlag";
            this.WaWarehouseFlag.Size = new System.Drawing.Size(28, 16);
            this.WaWarehouseFlag.TabIndex = 35;
            this.WaWarehouseFlag.Text = " ";
            this.WaWarehouseFlag.UseVisualStyleBackColor = true;
            // 
            // HaDate
            // 
            this.HaDate.Location = new System.Drawing.Point(157, 9);
            this.HaDate.Margin = new System.Windows.Forms.Padding(1);
            this.HaDate.Name = "HaDate";
            this.HaDate.Size = new System.Drawing.Size(122, 19);
            this.HaDate.TabIndex = 34;
            // 
            // Hattyu_Del_Button
            // 
            this.Hattyu_Del_Button.Font = new System.Drawing.Font("BIZ UDPゴシック", 15.75F);
            this.Hattyu_Del_Button.Location = new System.Drawing.Point(551, 228);
            this.Hattyu_Del_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Hattyu_Del_Button.Name = "Hattyu_Del_Button";
            this.Hattyu_Del_Button.Size = new System.Drawing.Size(98, 41);
            this.Hattyu_Del_Button.TabIndex = 33;
            this.Hattyu_Del_Button.Text = "削除";
            this.Hattyu_Del_Button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 291);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(710, 213);
            this.dataGridView1.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("BIZ UDPゴシック", 15.75F);
            this.label7.Location = new System.Drawing.Point(620, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "非表示理由";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("BIZ UDPゴシック", 15.75F);
            this.label6.Location = new System.Drawing.Point(8, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "発注管理フラグ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BIZ UDPゴシック", 15.75F);
            this.label5.Location = new System.Drawing.Point(8, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "入庫済フラグ（倉庫）";
            // 
            // HaHidden
            // 
            this.HaHidden.Location = new System.Drawing.Point(670, 106);
            this.HaHidden.Margin = new System.Windows.Forms.Padding(1);
            this.HaHidden.Name = "HaHidden";
            this.HaHidden.Size = new System.Drawing.Size(62, 19);
            this.HaHidden.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BIZ UDPゴシック", 15.75F);
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "発注年月日";
            // 
            // EmID
            // 
            this.EmID.Location = new System.Drawing.Point(142, 94);
            this.EmID.Margin = new System.Windows.Forms.Padding(1);
            this.EmID.Name = "EmID";
            this.EmID.Size = new System.Drawing.Size(62, 19);
            this.EmID.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BIZ UDPゴシック", 15.75F);
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "発注社員ID";
            // 
            // MaID
            // 
            this.MaID.Location = new System.Drawing.Point(142, 55);
            this.MaID.Margin = new System.Windows.Forms.Padding(1);
            this.MaID.Name = "MaID";
            this.MaID.Size = new System.Drawing.Size(62, 19);
            this.MaID.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BIZ UDPゴシック", 15.75F);
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "メーカID";
            // 
            // HaID
            // 
            this.HaID.Location = new System.Drawing.Point(142, 16);
            this.HaID.Margin = new System.Windows.Forms.Padding(1);
            this.HaID.Name = "HaID";
            this.HaID.Size = new System.Drawing.Size(62, 19);
            this.HaID.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDPゴシック", 15.75F);
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "発注ID";
            // 
            // Hattyu_Add_Button
            // 
            this.Hattyu_Add_Button.Font = new System.Drawing.Font("BIZ UDPゴシック", 15.75F);
            this.Hattyu_Add_Button.Location = new System.Drawing.Point(674, 228);
            this.Hattyu_Add_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Hattyu_Add_Button.Name = "Hattyu_Add_Button";
            this.Hattyu_Add_Button.Size = new System.Drawing.Size(101, 41);
            this.Hattyu_Add_Button.TabIndex = 20;
            this.Hattyu_Add_Button.Text = "登録";
            this.Hattyu_Add_Button.UseVisualStyleBackColor = true;
            this.Hattyu_Add_Button.Click += new System.EventHandler(this.Hattyu_Add_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.HaID);
            this.panel1.Controls.Add(this.MaID);
            this.panel1.Controls.Add(this.EmID);
            this.panel1.Location = new System.Drawing.Point(65, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 129);
            this.panel1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.HaFlag);
            this.panel2.Controls.Add(this.HaDate);
            this.panel2.Controls.Add(this.WaWarehouseFlag);
            this.panel2.Location = new System.Drawing.Point(297, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 98);
            this.panel2.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.button1.Location = new System.Drawing.Point(226, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 238);
            this.button1.TabIndex = 39;
            this.button1.Text = "未実装";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Hattyu_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Hattyu_Del_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HaHidden);
            this.Controls.Add(this.Hattyu_Add_Button);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Hattyu_Add";
            this.Text = "Hattyu_Add";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox HaFlag;
        private System.Windows.Forms.CheckBox WaWarehouseFlag;
        private System.Windows.Forms.DateTimePicker HaDate;
        private System.Windows.Forms.Button Hattyu_Del_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HaHidden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Hattyu_Add_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}