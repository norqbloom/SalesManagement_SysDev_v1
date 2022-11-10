
namespace SalesManagement_SysDev.Management_Employee
{
    partial class Employee_Add
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmFlag = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EmName = new System.Windows.Forms.TextBox();
            this.SoID = new System.Windows.Forms.TextBox();
            this.PoID = new System.Windows.Forms.TextBox();
            this.EmPassword = new System.Windows.Forms.TextBox();
            this.EmPhone = new System.Windows.Forms.TextBox();
            this.EmHidden = new System.Windows.Forms.TextBox();
            this.Emp_Add_Button = new System.Windows.Forms.Button();
            this.EmHiredate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 407);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // EmFlag
            // 
            this.EmFlag.AutoSize = true;
            this.EmFlag.Location = new System.Drawing.Point(215, 362);
            this.EmFlag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmFlag.Name = "EmFlag";
            this.EmFlag.Size = new System.Drawing.Size(34, 19);
            this.EmFlag.TabIndex = 1;
            this.EmFlag.Text = " ";
            this.EmFlag.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "社員ID";
            // 
            // EmID
            // 
            this.EmID.Location = new System.Drawing.Point(196, 66);
            this.EmID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmID.Name = "EmID";
            this.EmID.Size = new System.Drawing.Size(81, 22);
            this.EmID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "社員名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "営業所ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "役職ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "入社年月日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "パスワード";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 307);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "電話番号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 362);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "社員管理フラグ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "非表示理由";
            // 
            // EmName
            // 
            this.EmName.Location = new System.Drawing.Point(196, 102);
            this.EmName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmName.Name = "EmName";
            this.EmName.Size = new System.Drawing.Size(81, 22);
            this.EmName.TabIndex = 12;
            // 
            // SoID
            // 
            this.SoID.Location = new System.Drawing.Point(196, 128);
            this.SoID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SoID.Name = "SoID";
            this.SoID.Size = new System.Drawing.Size(81, 22);
            this.SoID.TabIndex = 13;
            // 
            // PoID
            // 
            this.PoID.Location = new System.Drawing.Point(196, 169);
            this.PoID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PoID.Name = "PoID";
            this.PoID.Size = new System.Drawing.Size(81, 22);
            this.PoID.TabIndex = 14;
            // 
            // EmPassword
            // 
            this.EmPassword.Location = new System.Drawing.Point(196, 252);
            this.EmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmPassword.Name = "EmPassword";
            this.EmPassword.Size = new System.Drawing.Size(81, 22);
            this.EmPassword.TabIndex = 15;
            // 
            // EmPhone
            // 
            this.EmPhone.Location = new System.Drawing.Point(196, 307);
            this.EmPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmPhone.Name = "EmPhone";
            this.EmPhone.Size = new System.Drawing.Size(81, 22);
            this.EmPhone.TabIndex = 16;
            // 
            // EmHidden
            // 
            this.EmHidden.Location = new System.Drawing.Point(475, 75);
            this.EmHidden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmHidden.Name = "EmHidden";
            this.EmHidden.Size = new System.Drawing.Size(81, 22);
            this.EmHidden.TabIndex = 17;
            // 
            // Emp_Add_Button
            // 
            this.Emp_Add_Button.Location = new System.Drawing.Point(876, 281);
            this.Emp_Add_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Emp_Add_Button.Name = "Emp_Add_Button";
            this.Emp_Add_Button.Size = new System.Drawing.Size(135, 73);
            this.Emp_Add_Button.TabIndex = 19;
            this.Emp_Add_Button.Text = "追加";
            this.Emp_Add_Button.UseVisualStyleBackColor = true;
            // 
            // EmHiredate
            // 
            this.EmHiredate.Location = new System.Drawing.Point(196, 204);
            this.EmHiredate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmHiredate.Name = "EmHiredate";
            this.EmHiredate.Size = new System.Drawing.Size(161, 22);
            this.EmHiredate.TabIndex = 20;
            // 
            // Employee_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 666);
            this.Controls.Add(this.EmHiredate);
            this.Controls.Add(this.Emp_Add_Button);
            this.Controls.Add(this.EmHidden);
            this.Controls.Add(this.EmPhone);
            this.Controls.Add(this.EmPassword);
            this.Controls.Add(this.PoID);
            this.Controls.Add(this.SoID);
            this.Controls.Add(this.EmName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmFlag);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Employee_Add";
            this.Text = "Employee_Add";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox EmFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmName;
        private System.Windows.Forms.TextBox SoID;
        private System.Windows.Forms.TextBox PoID;
        private System.Windows.Forms.TextBox EmPassword;
        private System.Windows.Forms.TextBox EmPhone;
        private System.Windows.Forms.TextBox EmHidden;
        private System.Windows.Forms.Button Emp_Add_Button;
        private System.Windows.Forms.DateTimePicker EmHiredate;
    }
}