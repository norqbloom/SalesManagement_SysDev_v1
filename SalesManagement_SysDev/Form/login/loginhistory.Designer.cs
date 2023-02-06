
namespace SalesManagement_SysDev
{
    partial class loginhistory
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
            this.dataGridViewhistory = new System.Windows.Forms.DataGridView();
            this.serchlogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.change = new System.Windows.Forms.Button();
            this.buttonLastPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxPageSize = new System.Windows.Forms.TextBox();
            this.textBoxPageNo = new System.Windows.Forms.TextBox();
            this.labelPage = new System.Windows.Forms.Label();
            this.buttonFirstPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpIDtxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewhistory)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewhistory
            // 
            this.dataGridViewhistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewhistory.Location = new System.Drawing.Point(12, 210);
            this.dataGridViewhistory.Name = "dataGridViewhistory";
            this.dataGridViewhistory.RowHeadersWidth = 51;
            this.dataGridViewhistory.RowTemplate.Height = 21;
            this.dataGridViewhistory.Size = new System.Drawing.Size(843, 248);
            this.dataGridViewhistory.TabIndex = 0;
            // 
            // serchlogin
            // 
            this.serchlogin.Location = new System.Drawing.Point(729, 155);
            this.serchlogin.Name = "serchlogin";
            this.serchlogin.Size = new System.Drawing.Size(105, 49);
            this.serchlogin.TabIndex = 1;
            this.serchlogin.Text = "検索";
            this.serchlogin.UseVisualStyleBackColor = true;
            this.serchlogin.Click += new System.EventHandler(this.serchlogin_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.change);
            this.panel2.Controls.Add(this.buttonLastPage);
            this.panel2.Controls.Add(this.buttonNextPage);
            this.panel2.Controls.Add(this.buttonPreviousPage);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textBoxPageSize);
            this.panel2.Controls.Add(this.textBoxPageNo);
            this.panel2.Controls.Add(this.labelPage);
            this.panel2.Controls.Add(this.buttonFirstPage);
            this.panel2.Location = new System.Drawing.Point(134, 463);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 29);
            this.panel2.TabIndex = 28;
            // 
            // change
            // 
            this.change.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change.Location = new System.Drawing.Point(170, 5);
            this.change.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(56, 22);
            this.change.TabIndex = 21;
            this.change.Text = "行数変更";
            this.change.UseVisualStyleBackColor = true;
            // 
            // buttonLastPage
            // 
            this.buttonLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLastPage.Location = new System.Drawing.Point(581, 7);
            this.buttonLastPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLastPage.Name = "buttonLastPage";
            this.buttonLastPage.Size = new System.Drawing.Size(21, 18);
            this.buttonLastPage.TabIndex = 24;
            this.buttonLastPage.Text = "▶|";
            this.buttonLastPage.UseVisualStyleBackColor = true;
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextPage.Location = new System.Drawing.Point(559, 7);
            this.buttonNextPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(21, 18);
            this.buttonNextPage.TabIndex = 25;
            this.buttonNextPage.Text = "▶";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreviousPage.Location = new System.Drawing.Point(533, 7);
            this.buttonPreviousPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(21, 18);
            this.buttonPreviousPage.TabIndex = 26;
            this.buttonPreviousPage.Text = "◀";
            this.buttonPreviousPage.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(2, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 20;
            this.label17.Text = "1ページ行数";
            // 
            // textBoxPageSize
            // 
            this.textBoxPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPageSize.Location = new System.Drawing.Point(76, 7);
            this.textBoxPageSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPageSize.Name = "textBoxPageSize";
            this.textBoxPageSize.Size = new System.Drawing.Size(76, 19);
            this.textBoxPageSize.TabIndex = 11;
            // 
            // textBoxPageNo
            // 
            this.textBoxPageNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxPageNo.Location = new System.Drawing.Point(399, 6);
            this.textBoxPageNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPageNo.Name = "textBoxPageNo";
            this.textBoxPageNo.Size = new System.Drawing.Size(41, 19);
            this.textBoxPageNo.TabIndex = 22;
            // 
            // labelPage
            // 
            this.labelPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(443, 8);
            this.labelPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(35, 12);
            this.labelPage.TabIndex = 23;
            this.labelPage.Text = "ページ";
            // 
            // buttonFirstPage
            // 
            this.buttonFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFirstPage.Location = new System.Drawing.Point(508, 7);
            this.buttonFirstPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFirstPage.Name = "buttonFirstPage";
            this.buttonFirstPage.Size = new System.Drawing.Size(21, 18);
            this.buttonFirstPage.TabIndex = 13;
            this.buttonFirstPage.Text = "|◀";
            this.buttonFirstPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "社員ID";
            // 
            // EmpIDtxt
            // 
            this.EmpIDtxt.Location = new System.Drawing.Point(119, 36);
            this.EmpIDtxt.Name = "EmpIDtxt";
            this.EmpIDtxt.Size = new System.Drawing.Size(100, 19);
            this.EmpIDtxt.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 19);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(193, 115);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 19);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "から";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(337, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "日付検索";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // loginhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 503);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.EmpIDtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.serchlogin);
            this.Controls.Add(this.dataGridViewhistory);
            this.Name = "loginhistory";
            this.Text = "ログイン履歴";
            this.Load += new System.EventHandler(this.loginhistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewhistory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewhistory;
        private System.Windows.Forms.Button serchlogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button buttonLastPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxPageSize;
        private System.Windows.Forms.TextBox textBoxPageNo;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button buttonFirstPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpIDtxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}