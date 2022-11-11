
namespace SalesManagement_SysDev.Management_Arrival
{
    partial class Arrival_View
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
            this.Arr_Ser_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ArID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SoID = new System.Windows.Forms.TextBox();
            this.EmID = new System.Windows.Forms.TextBox();
            this.ClID = new System.Windows.Forms.TextBox();
            this.OrID = new System.Windows.Forms.TextBox();
            this.ArHidden = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Arr_Con_Button = new System.Windows.Forms.Button();
            this.ArDate = new System.Windows.Forms.DateTimePicker();
            this.ArStateFlag = new System.Windows.Forms.CheckBox();
            this.ArFlag = new System.Windows.Forms.CheckBox();
            this.Arr_Del_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Arr_Ser_Button
            // 
            this.Arr_Ser_Button.Location = new System.Drawing.Point(688, 182);
            this.Arr_Ser_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Arr_Ser_Button.Name = "Arr_Ser_Button";
            this.Arr_Ser_Button.Size = new System.Drawing.Size(144, 77);
            this.Arr_Ser_Button.TabIndex = 0;
            this.Arr_Ser_Button.Text = "検索";
            this.Arr_Ser_Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "入荷ID";
            // 
            // ArID
            // 
            this.ArID.Location = new System.Drawing.Point(110, 44);
            this.ArID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArID.Name = "ArID";
            this.ArID.Size = new System.Drawing.Size(81, 22);
            this.ArID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "営業所ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "社員ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "顧客ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "受注ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "入荷年月日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "入荷状態フラグ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "入荷管理フラグ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "非表示理由";
            // 
            // SoID
            // 
            this.SoID.Location = new System.Drawing.Point(110, 109);
            this.SoID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SoID.Name = "SoID";
            this.SoID.Size = new System.Drawing.Size(81, 22);
            this.SoID.TabIndex = 11;
            // 
            // EmID
            // 
            this.EmID.Location = new System.Drawing.Point(110, 184);
            this.EmID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmID.Name = "EmID";
            this.EmID.Size = new System.Drawing.Size(81, 22);
            this.EmID.TabIndex = 12;
            // 
            // ClID
            // 
            this.ClID.Location = new System.Drawing.Point(341, 44);
            this.ClID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClID.Name = "ClID";
            this.ClID.Size = new System.Drawing.Size(81, 22);
            this.ClID.TabIndex = 13;
            // 
            // OrID
            // 
            this.OrID.Location = new System.Drawing.Point(341, 112);
            this.OrID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrID.Name = "OrID";
            this.OrID.Size = new System.Drawing.Size(81, 22);
            this.OrID.TabIndex = 14;
            // 
            // ArHidden
            // 
            this.ArHidden.Location = new System.Drawing.Point(603, 185);
            this.ArHidden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArHidden.Name = "ArHidden";
            this.ArHidden.Size = new System.Drawing.Size(81, 22);
            this.ArHidden.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 272);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(485, 351);
            this.dataGridView1.TabIndex = 19;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(542, 272);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(449, 351);
            this.dataGridView2.TabIndex = 20;
            // 
            // Arr_Con_Button
            // 
            this.Arr_Con_Button.Location = new System.Drawing.Point(846, 182);
            this.Arr_Con_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Arr_Con_Button.Name = "Arr_Con_Button";
            this.Arr_Con_Button.Size = new System.Drawing.Size(144, 77);
            this.Arr_Con_Button.TabIndex = 21;
            this.Arr_Con_Button.Text = "確定";
            this.Arr_Con_Button.UseVisualStyleBackColor = true;
            // 
            // ArDate
            // 
            this.ArDate.Location = new System.Drawing.Point(341, 183);
            this.ArDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArDate.Name = "ArDate";
            this.ArDate.Size = new System.Drawing.Size(161, 22);
            this.ArDate.TabIndex = 22;
            // 
            // ArStateFlag
            // 
            this.ArStateFlag.AutoSize = true;
            this.ArStateFlag.Location = new System.Drawing.Point(621, 44);
            this.ArStateFlag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArStateFlag.Name = "ArStateFlag";
            this.ArStateFlag.Size = new System.Drawing.Size(34, 19);
            this.ArStateFlag.TabIndex = 23;
            this.ArStateFlag.Text = " ";
            this.ArStateFlag.UseVisualStyleBackColor = true;
            // 
            // ArFlag
            // 
            this.ArFlag.AutoSize = true;
            this.ArFlag.Location = new System.Drawing.Point(621, 115);
            this.ArFlag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArFlag.Name = "ArFlag";
            this.ArFlag.Size = new System.Drawing.Size(34, 19);
            this.ArFlag.TabIndex = 24;
            this.ArFlag.Text = " ";
            this.ArFlag.UseVisualStyleBackColor = true;
            // 
            // Arr_Del_Button
            // 
            this.Arr_Del_Button.Location = new System.Drawing.Point(846, 84);
            this.Arr_Del_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Arr_Del_Button.Name = "Arr_Del_Button";
            this.Arr_Del_Button.Size = new System.Drawing.Size(144, 77);
            this.Arr_Del_Button.TabIndex = 25;
            this.Arr_Del_Button.Text = "削除";
            this.Arr_Del_Button.UseVisualStyleBackColor = true;
            // 
            // Arrival_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 642);
            this.Controls.Add(this.Arr_Del_Button);
            this.Controls.Add(this.ArFlag);
            this.Controls.Add(this.ArStateFlag);
            this.Controls.Add(this.ArDate);
            this.Controls.Add(this.Arr_Con_Button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ArHidden);
            this.Controls.Add(this.OrID);
            this.Controls.Add(this.ClID);
            this.Controls.Add(this.EmID);
            this.Controls.Add(this.SoID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Arr_Ser_Button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Arrival_View";
            this.Text = "Arrival_View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Arr_Ser_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SoID;
        private System.Windows.Forms.TextBox EmID;
        private System.Windows.Forms.TextBox ClID;
        private System.Windows.Forms.TextBox OrID;
        private System.Windows.Forms.TextBox ArHidden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Arr_Con_Button;
        private System.Windows.Forms.DateTimePicker ArDate;
        private System.Windows.Forms.CheckBox ArStateFlag;
        private System.Windows.Forms.CheckBox ArFlag;
        private System.Windows.Forms.Button Arr_Del_Button;
    }
}