
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
            this.serch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClIDtxt = new System.Windows.Forms.TextBox();
            this.SOIDtxt = new System.Windows.Forms.TextBox();
            this.CLNametxt = new System.Windows.Forms.TextBox();
            this.ClPhonetxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Location = new System.Drawing.Point(826, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 681);
            this.panel1.TabIndex = 1;
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
            // client_serch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 681);
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
            this.Name = "client_serch";
            this.Text = "client_serch";
            this.Load += new System.EventHandler(this.client_serch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}