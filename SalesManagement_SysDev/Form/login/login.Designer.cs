
namespace SalesManagement_SysDev
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.logina = new System.Windows.Forms.Label();
            this.lodinggif = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lodinggif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_login.AutoSize = true;
            this.button_login.Location = new System.Drawing.Point(96, 412);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(202, 42);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "ログイン";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_id.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_id.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_id.Location = new System.Drawing.Point(67, 265);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(267, 31);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.Text = "担当者ID";
            this.textBox_id.Enter += new System.EventHandler(this.textBox_id_Enter);
            this.textBox_id.Leave += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_pass.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox_pass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_pass.Location = new System.Drawing.Point(67, 346);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(267, 31);
            this.textBox_pass.TabIndex = 1;
            this.textBox_pass.Text = "パスワード";
            this.textBox_pass.TextChanged += new System.EventHandler(this.textBox_pass_TextChanged);
            this.textBox_pass.Enter += new System.EventHandler(this.textBox_pass_Enter);
            this.textBox_pass.Leave += new System.EventHandler(this.textBox_pass_Leave);
            // 
            // logina
            // 
            this.logina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logina.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.logina.Location = new System.Drawing.Point(9, 222);
            this.logina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logina.Name = "logina";
            this.logina.Size = new System.Drawing.Size(364, 22);
            this.logina.TabIndex = 6;
            this.logina.Text = "テキスト";
            this.logina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lodinggif
            // 
            this.lodinggif.Image = global::SalesManagement_SysDev.Properties.Resources.l1oading;
            this.lodinggif.Location = new System.Drawing.Point(130, 398);
            this.lodinggif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lodinggif.Name = "lodinggif";
            this.lodinggif.Size = new System.Drawing.Size(110, 73);
            this.lodinggif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lodinggif.TabIndex = 7;
            this.lodinggif.TabStop = false;
            this.lodinggif.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SalesManagement_SysDev.Properties.Resources._15642961;
            this.pictureBox1.Location = new System.Drawing.Point(67, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 18);
            this.button1.TabIndex = 8;
            this.button1.Text = "追加(いずれ消す)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 322);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 18);
            this.button2.TabIndex = 9;
            this.button2.Text = "F_login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(67, 378);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "パスワードを表示";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 214);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 18);
            this.button4.TabIndex = 12;
            this.button4.Text = "ログインスキップ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(382, 493);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lodinggif);
            this.Controls.Add(this.logina);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_pass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(398, 532);
            this.MinimumSize = new System.Drawing.Size(398, 532);
            this.Name = "login";
            this.Text = "ログイン";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lodinggif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logina;
        private System.Windows.Forms.PictureBox lodinggif;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
    }
}