
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
            this.EmIDtxt = new System.Windows.Forms.TextBox();
            this.EmNametxt = new System.Windows.Forms.TextBox();
            this.SoIDtxt = new System.Windows.Forms.TextBox();
            this.PoIDtxt = new System.Windows.Forms.TextBox();
            this.EmPassWord = new System.Windows.Forms.TextBox();
            this.Emphonetxt = new System.Windows.Forms.TextBox();
            this.hiddentxt = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Emphone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeHidden = new System.Windows.Forms.DateTimePicker();
            this.EmCheck = new System.Windows.Forms.CheckBox();
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
            // EmIDtxt
            // 
            this.EmIDtxt.Location = new System.Drawing.Point(35, 130);
            this.EmIDtxt.Name = "EmIDtxt";
            this.EmIDtxt.Size = new System.Drawing.Size(100, 22);
            this.EmIDtxt.TabIndex = 1;
            // 
            // EmNametxt
            // 
            this.EmNametxt.Location = new System.Drawing.Point(219, 130);
            this.EmNametxt.Name = "EmNametxt";
            this.EmNametxt.Size = new System.Drawing.Size(100, 22);
            this.EmNametxt.TabIndex = 2;
            // 
            // SoIDtxt
            // 
            this.SoIDtxt.Location = new System.Drawing.Point(393, 130);
            this.SoIDtxt.Name = "SoIDtxt";
            this.SoIDtxt.Size = new System.Drawing.Size(100, 22);
            this.SoIDtxt.TabIndex = 3;
            // 
            // PoIDtxt
            // 
            this.PoIDtxt.Location = new System.Drawing.Point(561, 130);
            this.PoIDtxt.Name = "PoIDtxt";
            this.PoIDtxt.Size = new System.Drawing.Size(100, 22);
            this.PoIDtxt.TabIndex = 4;
            // 
            // EmPassWord
            // 
            this.EmPassWord.Location = new System.Drawing.Point(35, 295);
            this.EmPassWord.Name = "EmPassWord";
            this.EmPassWord.Size = new System.Drawing.Size(100, 22);
            this.EmPassWord.TabIndex = 6;
            // 
            // Emphonetxt
            // 
            this.Emphonetxt.Location = new System.Drawing.Point(219, 295);
            this.Emphonetxt.Name = "Emphonetxt";
            this.Emphonetxt.Size = new System.Drawing.Size(100, 22);
            this.Emphonetxt.TabIndex = 7;
            // 
            // hiddentxt
            // 
            this.hiddentxt.Location = new System.Drawing.Point(561, 295);
            this.hiddentxt.Name = "hiddentxt";
            this.hiddentxt.Size = new System.Drawing.Size(100, 22);
            this.hiddentxt.TabIndex = 8;
            this.hiddentxt.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
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
            // EmCheck
            // 
            this.EmCheck.AutoSize = true;
            this.EmCheck.Location = new System.Drawing.Point(393, 298);
            this.EmCheck.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.EmCheck.Name = "EmCheck";
            this.EmCheck.Size = new System.Drawing.Size(69, 19);
            this.EmCheck.TabIndex = 20;
            this.EmCheck.Text = "チェック";
            this.EmCheck.UseVisualStyleBackColor = true;
            // 
            // empcnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 524);
            this.Controls.Add(this.EmCheck);
            this.Controls.Add(this.dateTimeHidden);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Emphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.hiddentxt);
            this.Controls.Add(this.Emphonetxt);
            this.Controls.Add(this.EmPassWord);
            this.Controls.Add(this.PoIDtxt);
            this.Controls.Add(this.SoIDtxt);
            this.Controls.Add(this.EmNametxt);
            this.Controls.Add(this.EmIDtxt);
            this.Controls.Add(this.add_btn);
            this.Name = "empcnt";
            this.Text = "empcnt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox EmIDtxt;
        private System.Windows.Forms.TextBox EmNametxt;
        private System.Windows.Forms.TextBox SoIDtxt;
        private System.Windows.Forms.TextBox PoIDtxt;
        private System.Windows.Forms.TextBox EmPassWord;
        private System.Windows.Forms.TextBox Emphonetxt;
        private System.Windows.Forms.TextBox hiddentxt;
        private System.Windows.Forms.Label IDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Emphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeHidden;
        private System.Windows.Forms.CheckBox EmCheck;
    }
}