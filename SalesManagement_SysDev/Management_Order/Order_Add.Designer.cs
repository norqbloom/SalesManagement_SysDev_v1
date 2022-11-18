
namespace SalesManagement_SysDev.Management_Order
{
    partial class Order_Add
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
            this.Ord_Con_Button = new System.Windows.Forms.Button();
            this.Ord_Add_Button = new System.Windows.Forms.Button();
            this.OrFlag = new System.Windows.Forms.CheckBox();
            this.OrHidden = new System.Windows.Forms.TextBox();
            this.ClID = new System.Windows.Forms.TextBox();
            this.EmID = new System.Windows.Forms.TextBox();
            this.SoID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrStateFlag = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrDate = new System.Windows.Forms.DateTimePicker();
            this.Ord_Del_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ord_Con_Button
            // 
            this.Ord_Con_Button.Location = new System.Drawing.Point(832, 276);
            this.Ord_Con_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Ord_Con_Button.Name = "Ord_Con_Button";
            this.Ord_Con_Button.Size = new System.Drawing.Size(156, 97);
            this.Ord_Con_Button.TabIndex = 60;
            this.Ord_Con_Button.Text = "確定";
            this.Ord_Con_Button.UseVisualStyleBackColor = true;
            // 
            // Ord_Add_Button
            // 
            this.Ord_Add_Button.Location = new System.Drawing.Point(650, 276);
            this.Ord_Add_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Ord_Add_Button.Name = "Ord_Add_Button";
            this.Ord_Add_Button.Size = new System.Drawing.Size(156, 97);
            this.Ord_Add_Button.TabIndex = 59;
            this.Ord_Add_Button.Text = "登録";
            this.Ord_Add_Button.UseVisualStyleBackColor = true;
            this.Ord_Add_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrFlag
            // 
            this.OrFlag.AutoSize = true;
            this.OrFlag.Location = new System.Drawing.Point(309, 295);
            this.OrFlag.Margin = new System.Windows.Forms.Padding(2);
            this.OrFlag.Name = "OrFlag";
            this.OrFlag.Size = new System.Drawing.Size(34, 19);
            this.OrFlag.TabIndex = 58;
            this.OrFlag.Text = " ";
            this.OrFlag.UseVisualStyleBackColor = true;
            // 
            // OrHidden
            // 
            this.OrHidden.Location = new System.Drawing.Point(309, 329);
            this.OrHidden.Margin = new System.Windows.Forms.Padding(2);
            this.OrHidden.Name = "OrHidden";
            this.OrHidden.Size = new System.Drawing.Size(81, 22);
            this.OrHidden.TabIndex = 56;
            // 
            // ClID
            // 
            this.ClID.Location = new System.Drawing.Point(309, 180);
            this.ClID.Margin = new System.Windows.Forms.Padding(2);
            this.ClID.Name = "ClID";
            this.ClID.Size = new System.Drawing.Size(81, 22);
            this.ClID.TabIndex = 55;
            // 
            // EmID
            // 
            this.EmID.Location = new System.Drawing.Point(309, 138);
            this.EmID.Margin = new System.Windows.Forms.Padding(2);
            this.EmID.Name = "EmID";
            this.EmID.Size = new System.Drawing.Size(81, 22);
            this.EmID.TabIndex = 54;
            // 
            // SoID
            // 
            this.SoID.Location = new System.Drawing.Point(309, 102);
            this.SoID.Margin = new System.Windows.Forms.Padding(2);
            this.SoID.Name = "SoID";
            this.SoID.Size = new System.Drawing.Size(81, 22);
            this.SoID.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 335);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 52;
            this.label9.Text = "非表示理由";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 295);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 51;
            this.label8.Text = "受注管理フラグ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 50;
            this.label7.Text = "受注状態フラグ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "受注年月日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "顧客担当者名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "顧客ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "社員ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "営業所ID";
            // 
            // OrStateFlag
            // 
            this.OrStateFlag.AutoSize = true;
            this.OrStateFlag.Location = new System.Drawing.Point(309, 261);
            this.OrStateFlag.Margin = new System.Windows.Forms.Padding(2);
            this.OrStateFlag.Name = "OrStateFlag";
            this.OrStateFlag.Size = new System.Drawing.Size(34, 19);
            this.OrStateFlag.TabIndex = 44;
            this.OrStateFlag.Text = " ";
            this.OrStateFlag.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "受注ID";
            // 
            // OrID
            // 
            this.OrID.Location = new System.Drawing.Point(309, 67);
            this.OrID.Margin = new System.Windows.Forms.Padding(2);
            this.OrID.Name = "OrID";
            this.OrID.Size = new System.Drawing.Size(81, 22);
            this.OrID.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 399);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(927, 247);
            this.dataGridView1.TabIndex = 41;
            // 
            // OrDate
            // 
            this.OrDate.Location = new System.Drawing.Point(309, 219);
            this.OrDate.Margin = new System.Windows.Forms.Padding(2);
            this.OrDate.Name = "OrDate";
            this.OrDate.Size = new System.Drawing.Size(161, 22);
            this.OrDate.TabIndex = 61;
            // 
            // Ord_Del_Button
            // 
            this.Ord_Del_Button.Location = new System.Drawing.Point(473, 276);
            this.Ord_Del_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Ord_Del_Button.Name = "Ord_Del_Button";
            this.Ord_Del_Button.Size = new System.Drawing.Size(156, 97);
            this.Ord_Del_Button.TabIndex = 62;
            this.Ord_Del_Button.Text = "削除";
            this.Ord_Del_Button.UseVisualStyleBackColor = true;
            this.Ord_Del_Button.Click += new System.EventHandler(this.Ord_Del_Button_Click);
            // 
            // Order_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 712);
            this.Controls.Add(this.Ord_Del_Button);
            this.Controls.Add(this.OrDate);
            this.Controls.Add(this.Ord_Con_Button);
            this.Controls.Add(this.Ord_Add_Button);
            this.Controls.Add(this.OrFlag);
            this.Controls.Add(this.OrHidden);
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
            this.Controls.Add(this.OrStateFlag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrID);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Order_Add";
            this.Text = "Order_Add";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ord_Con_Button;
        private System.Windows.Forms.Button Ord_Add_Button;
        private System.Windows.Forms.CheckBox OrFlag;
        private System.Windows.Forms.TextBox OrHidden;
        private System.Windows.Forms.TextBox ClID;
        private System.Windows.Forms.TextBox EmID;
        private System.Windows.Forms.TextBox SoID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox OrStateFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker OrDate;
        private System.Windows.Forms.Button Ord_Del_Button;
    }
}