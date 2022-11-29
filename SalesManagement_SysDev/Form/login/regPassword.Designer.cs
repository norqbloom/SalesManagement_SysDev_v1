
namespace SalesManagement_SysDev
{
    partial class regPassword
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
            this.regbtn = new System.Windows.Forms.Button();
            this.EmpIDtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passcontxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // regbtn
            // 
            this.regbtn.Location = new System.Drawing.Point(234, 306);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(119, 54);
            this.regbtn.TabIndex = 0;
            this.regbtn.Text = "更新";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // EmpIDtxt
            // 
            this.EmpIDtxt.Location = new System.Drawing.Point(159, 86);
            this.EmpIDtxt.Name = "EmpIDtxt";
            this.EmpIDtxt.Size = new System.Drawing.Size(209, 19);
            this.EmpIDtxt.TabIndex = 1;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(159, 152);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(209, 19);
            this.passtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "社員ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "パスワード";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "パスワード確認";
            // 
            // passcontxt
            // 
            this.passcontxt.Location = new System.Drawing.Point(159, 224);
            this.passcontxt.Name = "passcontxt";
            this.passcontxt.Size = new System.Drawing.Size(209, 19);
            this.passcontxt.TabIndex = 5;
            // 
            // regPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passcontxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.EmpIDtxt);
            this.Controls.Add(this.regbtn);
            this.Name = "regPassword";
            this.Text = "パスワード変更";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.TextBox EmpIDtxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passcontxt;
    }
}