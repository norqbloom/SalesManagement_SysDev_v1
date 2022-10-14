
namespace SalesManagement_SysDev
{
    partial class template
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
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.client_regbtn = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.client_upbtn = new System.Windows.Forms.Button();
            this.client_serchbtn = new System.Windows.Forms.Button();
            this.sidepanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.AutoScroll = true;
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.sidepanel.Controls.Add(this.panel2);
            this.sidepanel.Controls.Add(this.btn_client);
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(395, 562);
            this.sidepanel.TabIndex = 0;
            this.sidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidepanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.client_serchbtn);
            this.panel2.Controls.Add(this.client_upbtn);
            this.panel2.Controls.Add(this.client_regbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 125);
            this.panel2.TabIndex = 2;
            // 
            // client_regbtn
            // 
            this.client_regbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.client_regbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.client_regbtn.FlatAppearance.BorderSize = 0;
            this.client_regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_regbtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.client_regbtn.ForeColor = System.Drawing.Color.White;
            this.client_regbtn.Location = new System.Drawing.Point(0, 0);
            this.client_regbtn.Name = "client_regbtn";
            this.client_regbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.client_regbtn.Size = new System.Drawing.Size(395, 40);
            this.client_regbtn.TabIndex = 0;
            this.client_regbtn.Text = "登録";
            this.client_regbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.client_regbtn.UseVisualStyleBackColor = false;
            this.client_regbtn.Click += new System.EventHandler(this.client_regbtn_Click);
            // 
            // btn_client
            // 
            this.btn_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btn_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_client.FlatAppearance.BorderSize = 0;
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_client.ForeColor = System.Drawing.Color.White;
            this.btn_client.Location = new System.Drawing.Point(0, 100);
            this.btn_client.Name = "btn_client";
            this.btn_client.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_client.Size = new System.Drawing.Size(395, 67);
            this.btn_client.TabIndex = 1;
            this.btn_client.Text = "顧客管理";
            this.btn_client.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_client.UseVisualStyleBackColor = false;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 100);
            this.panel1.TabIndex = 0;
            // 
            // client_upbtn
            // 
            this.client_upbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.client_upbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.client_upbtn.FlatAppearance.BorderSize = 0;
            this.client_upbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_upbtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.client_upbtn.ForeColor = System.Drawing.Color.White;
            this.client_upbtn.Location = new System.Drawing.Point(0, 40);
            this.client_upbtn.Name = "client_upbtn";
            this.client_upbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.client_upbtn.Size = new System.Drawing.Size(395, 40);
            this.client_upbtn.TabIndex = 1;
            this.client_upbtn.Text = "更新";
            this.client_upbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.client_upbtn.UseVisualStyleBackColor = false;
            this.client_upbtn.Click += new System.EventHandler(this.client_upbtn_Click);
            // 
            // client_serchbtn
            // 
            this.client_serchbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.client_serchbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.client_serchbtn.FlatAppearance.BorderSize = 0;
            this.client_serchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_serchbtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.client_serchbtn.ForeColor = System.Drawing.Color.White;
            this.client_serchbtn.Location = new System.Drawing.Point(0, 80);
            this.client_serchbtn.Name = "client_serchbtn";
            this.client_serchbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.client_serchbtn.Size = new System.Drawing.Size(395, 40);
            this.client_serchbtn.TabIndex = 2;
            this.client_serchbtn.Text = "検索";
            this.client_serchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.client_serchbtn.UseVisualStyleBackColor = false;
            this.client_serchbtn.Click += new System.EventHandler(this.client_serchbtn_Click);
            // 
            // template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.sidepanel);
            this.Name = "template";
            this.Text = "template";
            this.sidepanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button client_regbtn;
        private System.Windows.Forms.Button client_serchbtn;
        private System.Windows.Forms.Button client_upbtn;
    }
}