
namespace SalesManagement_SysDev
{
    partial class テスト2
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
            this.dataGridViewDspProduct = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrName = new System.Windows.Forms.TextBox();
            this.textBoxOrTotalPrice = new System.Windows.Forms.TextBox();
            this.textBoxOrQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPageSize = new System.Windows.Forms.TextBox();
            this.textBoxPageNo = new System.Windows.Forms.TextBox();
            this.labelPage = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBoxOrID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDspProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDspProduct
            // 
            this.dataGridViewDspProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDspProduct.Location = new System.Drawing.Point(12, 328);
            this.dataGridViewDspProduct.Name = "dataGridViewDspProduct";
            this.dataGridViewDspProduct.RowHeadersWidth = 51;
            this.dataGridViewDspProduct.RowTemplate.Height = 24;
            this.dataGridViewDspProduct.Size = new System.Drawing.Size(1480, 520);
            this.dataGridViewDspProduct.TabIndex = 0;
            this.dataGridViewDspProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDspProduct_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "登録";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "商品ID";
            // 
            // textBoxPrID
            // 
            this.textBoxPrID.Location = new System.Drawing.Point(289, 174);
            this.textBoxPrID.Name = "textBoxPrID";
            this.textBoxPrID.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "商品名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(756, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "合計金額";
            // 
            // textBoxPrName
            // 
            this.textBoxPrName.Location = new System.Drawing.Point(439, 176);
            this.textBoxPrName.Name = "textBoxPrName";
            this.textBoxPrName.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrName.TabIndex = 9;
            // 
            // textBoxOrTotalPrice
            // 
            this.textBoxOrTotalPrice.Location = new System.Drawing.Point(749, 174);
            this.textBoxOrTotalPrice.Name = "textBoxOrTotalPrice";
            this.textBoxOrTotalPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrTotalPrice.TabIndex = 10;
            // 
            // textBoxOrQuantity
            // 
            this.textBoxOrQuantity.Location = new System.Drawing.Point(601, 174);
            this.textBoxOrQuantity.Name = "textBoxOrQuantity";
            this.textBoxOrQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrQuantity.TabIndex = 11;
            this.textBoxOrQuantity.TextChanged += new System.EventHandler(this.textBoxQuality_TextChanged);
            // 
            // textBoxPageSize
            // 
            this.textBoxPageSize.Location = new System.Drawing.Point(906, 857);
            this.textBoxPageSize.Name = "textBoxPageSize";
            this.textBoxPageSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxPageSize.TabIndex = 12;
            // 
            // textBoxPageNo
            // 
            this.textBoxPageNo.Location = new System.Drawing.Point(1087, 857);
            this.textBoxPageNo.Name = "textBoxPageNo";
            this.textBoxPageNo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPageNo.TabIndex = 13;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(1012, 860);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(43, 15);
            this.labelPage.TabIndex = 14;
            this.labelPage.Text = "label5";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1194, 860);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 19);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(1311, 860);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 19);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxOrID
            // 
            this.textBoxOrID.Location = new System.Drawing.Point(158, 174);
            this.textBoxOrID.Name = "textBoxOrID";
            this.textBoxOrID.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrID.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "受注ID";
            // 
            // テスト2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 891);
            this.Controls.Add(this.textBoxOrID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.textBoxPageNo);
            this.Controls.Add(this.textBoxPageSize);
            this.Controls.Add(this.textBoxOrQuantity);
            this.Controls.Add(this.textBoxOrTotalPrice);
            this.Controls.Add(this.textBoxPrName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewDspProduct);
            this.Name = "テスト2";
            this.Text = "テスト2";
            this.Load += new System.EventHandler(this.テスト2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDspProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDspProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrName;
        private System.Windows.Forms.TextBox textBoxOrTotalPrice;
        private System.Windows.Forms.TextBox textBoxOrQuantity;
        private System.Windows.Forms.TextBox textBoxPageSize;
        private System.Windows.Forms.TextBox textBoxPageNo;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBoxOrID;
        private System.Windows.Forms.Label label5;
    }
}