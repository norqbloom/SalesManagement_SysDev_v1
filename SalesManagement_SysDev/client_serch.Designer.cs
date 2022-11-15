
namespace SalesManagement_SysDev
{
    partial class client_serch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.upusername = new System.Windows.Forms.Label();
            this.upuserid = new System.Windows.Forms.Label();
            this.uptime = new System.Windows.Forms.Label();
            this.userid = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.Label();
            this.serch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClIDtxt = new System.Windows.Forms.TextBox();
            this.SOIDtxt = new System.Windows.Forms.TextBox();
            this.CLNametxt = new System.Windows.Forms.TextBox();
            this.ClPhonetxt = new System.Windows.Forms.TextBox();
            this.textBoxPageSize = new System.Windows.Forms.TextBox();
            this.textBoxPageNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 429);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.upusername);
            this.panel1.Controls.Add(this.upuserid);
            this.panel1.Controls.Add(this.uptime);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.userid);
            this.panel1.Controls.Add(this.datetime);
            this.panel1.Controls.Add(this.IDtxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Location = new System.Drawing.Point(826, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 681);
            this.panel1.TabIndex = 1;
            // 
            // upusername
            // 
            this.upusername.AutoSize = true;
            this.upusername.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.upusername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upusername.Location = new System.Drawing.Point(195, 377);
            this.upusername.Name = "upusername";
            this.upusername.Size = new System.Drawing.Size(74, 20);
            this.upusername.TabIndex = 6;
            this.upusername.Text = "label12";
            // 
            // upuserid
            // 
            this.upuserid.AutoSize = true;
            this.upuserid.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.upuserid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upuserid.Location = new System.Drawing.Point(38, 377);
            this.upuserid.Name = "upuserid";
            this.upuserid.Size = new System.Drawing.Size(74, 20);
            this.upuserid.TabIndex = 5;
            this.upuserid.Text = "label11";
            // 
            // uptime
            // 
            this.uptime.AutoSize = true;
            this.uptime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uptime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uptime.Location = new System.Drawing.Point(38, 268);
            this.uptime.Name = "uptime";
            this.uptime.Size = new System.Drawing.Size(74, 20);
            this.uptime.TabIndex = 4;
            this.uptime.Text = "label10";
            // 
            // userid
            // 
            this.userid.AutoSize = true;
            this.userid.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userid.Location = new System.Drawing.Point(38, 137);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(63, 20);
            this.userid.TabIndex = 2;
            this.userid.Text = "label8";
            // 
            // datetime
            // 
            this.datetime.AutoSize = true;
            this.datetime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.datetime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.datetime.Location = new System.Drawing.Point(195, 59);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(63, 20);
            this.datetime.TabIndex = 1;
            this.datetime.Text = "label7";
            // 
            // IDtxt
            // 
            this.IDtxt.AutoSize = true;
            this.IDtxt.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IDtxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IDtxt.Location = new System.Drawing.Point(38, 59);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(63, 20);
            this.IDtxt.TabIndex = 0;
            this.IDtxt.Text = "label6";
            // 
            // serch
            // 
            this.serch.Location = new System.Drawing.Point(627, 377);
            this.serch.Name = "serch";
            this.serch.Size = new System.Drawing.Size(148, 46);
            this.serch.TabIndex = 2;
            this.serch.Text = "検索";
            this.serch.UseVisualStyleBackColor = true;
            this.serch.Click += new System.EventHandler(this.serch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ClID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "ClPhone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ClName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "SOID";
            // 
            // ClIDtxt
            // 
            this.ClIDtxt.Location = new System.Drawing.Point(62, 122);
            this.ClIDtxt.Name = "ClIDtxt";
            this.ClIDtxt.Size = new System.Drawing.Size(100, 22);
            this.ClIDtxt.TabIndex = 7;
            // 
            // SOIDtxt
            // 
            this.SOIDtxt.Location = new System.Drawing.Point(193, 122);
            this.SOIDtxt.Name = "SOIDtxt";
            this.SOIDtxt.Size = new System.Drawing.Size(100, 22);
            this.SOIDtxt.TabIndex = 8;
            // 
            // CLNametxt
            // 
            this.CLNametxt.Location = new System.Drawing.Point(307, 122);
            this.CLNametxt.Name = "CLNametxt";
            this.CLNametxt.Size = new System.Drawing.Size(100, 22);
            this.CLNametxt.TabIndex = 9;
            // 
            // ClPhonetxt
            // 
            this.ClPhonetxt.Location = new System.Drawing.Point(449, 122);
            this.ClPhonetxt.Name = "ClPhonetxt";
            this.ClPhonetxt.Size = new System.Drawing.Size(100, 22);
            this.ClPhonetxt.TabIndex = 10;
            // 
            // textBoxPageSize
            // 
            this.textBoxPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPageSize.Location = new System.Drawing.Point(32, 647);
            this.textBoxPageSize.Name = "textBoxPageSize";
            this.textBoxPageSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxPageSize.TabIndex = 11;
            // 
            // textBoxPageNo
            // 
            this.textBoxPageNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPageNo.Location = new System.Drawing.Point(158, 647);
            this.textBoxPageNo.Name = "textBoxPageNo";
            this.textBoxPageNo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPageNo.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(700, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Location = new System.Drawing.Point(195, 137);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(63, 20);
            this.username.TabIndex = 3;
            this.username.Text = "label9";
            this.username.Click += new System.EventHandler(this.label9_Click);
            // 
            // client_serch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 681);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPageNo);
            this.Controls.Add(this.textBoxPageSize);
            this.Controls.Add(this.ClPhonetxt);
            this.Controls.Add(this.CLNametxt);
            this.Controls.Add(this.SOIDtxt);
            this.Controls.Add(this.ClIDtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "client_serch";
            this.Text = "client_serch";
            this.Load += new System.EventHandler(this.client_serch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button serch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClIDtxt;
        private System.Windows.Forms.TextBox SOIDtxt;
        private System.Windows.Forms.TextBox CLNametxt;
        private System.Windows.Forms.TextBox ClPhonetxt;
        private System.Windows.Forms.TextBox textBoxPageSize;
        private System.Windows.Forms.TextBox textBoxPageNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label IDtxt;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Label userid;
        private System.Windows.Forms.Label upusername;
        private System.Windows.Forms.Label upuserid;
        private System.Windows.Forms.Label uptime;
        private System.Windows.Forms.Label username;
    }
}