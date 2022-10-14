
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
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(256, 395);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(269, 52);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "ログイン";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_id.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_id.Location = new System.Drawing.Point(199, 178);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(399, 37);
            this.textBox_id.TabIndex = 3;
            this.textBox_id.Text = "担当者ID";
            this.textBox_id.Enter += new System.EventHandler(this.textBox_id_Enter);
            this.textBox_id.Leave += new System.EventHandler(this.textBox_id_Leave);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox_pass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_pass.Location = new System.Drawing.Point(199, 291);
            this.textBox_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(399, 37);
            this.textBox_pass.TabIndex = 4;
            this.textBox_pass.Text = "パスワード";
            this.textBox_pass.Enter += new System.EventHandler(this.textBox_pass_Enter);
            this.textBox_pass.Leave += new System.EventHandler(this.textBox_pass_Leave);
            // 
            // button_add
            // 
            this.button_add.Image = global::SalesManagement_SysDev.Properties.Resources.person_add_FILL0_wght300_GRAD0_opsz48;
            this.button_add.Location = new System.Drawing.Point(607, 15);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(80, 75);
            this.button_add.TabIndex = 2;
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Image = global::SalesManagement_SysDev.Properties.Resources.logout_FILL0_wght300_GRAD0_opsz48;
            this.button_logout.Location = new System.Drawing.Point(695, 15);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(80, 75);
            this.button_logout.TabIndex = 1;
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 514);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pass;
    }
}