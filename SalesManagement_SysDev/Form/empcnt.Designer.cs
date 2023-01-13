
namespace SalesManagement_SysDev
{
    partial class empcnt
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
            this.add_btn = new System.Windows.Forms.Button();
            this.textBoxEmID = new System.Windows.Forms.TextBox();
            this.textBoxEmName = new System.Windows.Forms.TextBox();
            this.textBoxSoID = new System.Windows.Forms.TextBox();
            this.textBoxPoID = new System.Windows.Forms.TextBox();
            this.textBoxEmPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmHidden = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Emphone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeHidden = new System.Windows.Forms.DateTimePicker();
            this.checkBoxEmFlag = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(370, 429);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(162, 41);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "追加";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // textBoxEmID
            // 
            this.textBoxEmID.Location = new System.Drawing.Point(35, 130);
            this.textBoxEmID.Name = "textBoxEmID";
            this.textBoxEmID.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmID.TabIndex = 1;
            this.textBoxEmID.TextChanged += new System.EventHandler(this.EmIDtxt_TextChanged);
            // 
            // textBoxEmName
            // 
            this.textBoxEmName.Location = new System.Drawing.Point(219, 130);
            this.textBoxEmName.Name = "textBoxEmName";
            this.textBoxEmName.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmName.TabIndex = 2;
            // 
            // textBoxSoID
            // 
            this.textBoxSoID.Location = new System.Drawing.Point(393, 130);
            this.textBoxSoID.Name = "textBoxSoID";
            this.textBoxSoID.Size = new System.Drawing.Size(100, 22);
            this.textBoxSoID.TabIndex = 3;
            // 
            // textBoxPoID
            // 
            this.textBoxPoID.Location = new System.Drawing.Point(561, 130);
            this.textBoxPoID.Name = "textBoxPoID";
            this.textBoxPoID.Size = new System.Drawing.Size(100, 22);
            this.textBoxPoID.TabIndex = 4;
            // 
            // textBoxEmPassword
            // 
            this.textBoxEmPassword.Location = new System.Drawing.Point(35, 295);
            this.textBoxEmPassword.Name = "textBoxEmPassword";
            this.textBoxEmPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmPassword.TabIndex = 6;
            // 
            // textBoxEmPhone
            // 
            this.textBoxEmPhone.Location = new System.Drawing.Point(219, 295);
            this.textBoxEmPhone.Name = "textBoxEmPhone";
            this.textBoxEmPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmPhone.TabIndex = 7;
            // 
            // textBoxEmHidden
            // 
            this.textBoxEmHidden.Location = new System.Drawing.Point(561, 295);
            this.textBoxEmHidden.Name = "textBoxEmHidden";
            this.textBoxEmHidden.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmHidden.TabIndex = 8;
            this.textBoxEmHidden.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // IDtxt
            // 
            this.IDtxt.AutoSize = true;
            this.IDtxt.Location = new System.Drawing.Point(46, 112);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(40, 15);
            this.IDtxt.TabIndex = 10;
            this.IDtxt.Text = "EmID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "EmName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "SoID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "PoID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(738, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "EmHiredata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pass";
            // 
            // Emphone
            // 
            this.Emphone.AutoSize = true;
            this.Emphone.Location = new System.Drawing.Point(216, 277);
            this.Emphone.Name = "Emphone";
            this.Emphone.Size = new System.Drawing.Size(46, 15);
            this.Emphone.TabIndex = 16;
            this.Emphone.Text = "phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hidden";
            // 
            // dateTimeHidden
            // 
            this.dateTimeHidden.Location = new System.Drawing.Point(719, 130);
            this.dateTimeHidden.Name = "dateTimeHidden";
            this.dateTimeHidden.Size = new System.Drawing.Size(200, 22);
            this.dateTimeHidden.TabIndex = 19;
            // 
            // checkBoxEmFlag
            // 
            this.checkBoxEmFlag.AutoSize = true;
            this.checkBoxEmFlag.Location = new System.Drawing.Point(393, 298);
            this.checkBoxEmFlag.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.checkBoxEmFlag.Name = "checkBoxEmFlag";
            this.checkBoxEmFlag.Size = new System.Drawing.Size(69, 19);
            this.checkBoxEmFlag.TabIndex = 20;
            this.checkBoxEmFlag.Text = "チェック";
            this.checkBoxEmFlag.UseVisualStyleBackColor = true;
            // 
            // empcnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 681);
            this.Controls.Add(this.checkBoxEmFlag);
            this.Controls.Add(this.dateTimeHidden);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Emphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.textBoxEmHidden);
            this.Controls.Add(this.textBoxEmPhone);
            this.Controls.Add(this.textBoxEmPassword);
            this.Controls.Add(this.textBoxPoID);
            this.Controls.Add(this.textBoxSoID);
            this.Controls.Add(this.textBoxEmName);
            this.Controls.Add(this.textBoxEmID);
            this.Controls.Add(this.add_btn);
            this.Name = "empcnt";
            this.Text = "empcnt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox textBoxEmID;
        private System.Windows.Forms.TextBox textBoxEmName;
        private System.Windows.Forms.TextBox textBoxSoID;
        private System.Windows.Forms.TextBox textBoxPoID;
        private System.Windows.Forms.TextBox textBoxEmPassword;
        private System.Windows.Forms.TextBox textBoxEmPhone;
        private System.Windows.Forms.TextBox textBoxEmHidden;
        private System.Windows.Forms.Label IDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Emphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeHidden;
        private System.Windows.Forms.CheckBox checkBoxEmFlag;
    }
}