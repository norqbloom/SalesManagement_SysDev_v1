
namespace SalesManagement_SysDev.Management_Product
{
    partial class Product_Upd
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
            this.button_Hide = new System.Windows.Forms.Button();
            this.dateTimePickerPrReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.labelPrReleaseDate = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrHidden = new System.Windows.Forms.Label();
            this.textBoxPrHidden = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrSafetyStock = new System.Windows.Forms.TextBox();
            this.labelPrSafetyStock = new System.Windows.Forms.Label();
            this.textBoxPrModelNumber = new System.Windows.Forms.TextBox();
            this.labelPrModelNumber = new System.Windows.Forms.Label();
            this.textBoxPrColor = new System.Windows.Forms.TextBox();
            this.labelPrColor = new System.Windows.Forms.Label();
            this.textBoxScID = new System.Windows.Forms.TextBox();
            this.labelScID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxPrFlag = new System.Windows.Forms.CheckBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.button_Cle = new System.Windows.Forms.Button();
            this.button_Upd = new System.Windows.Forms.Button();
            this.textBoxPrName = new System.Windows.Forms.TextBox();
            this.textBoxMaID = new System.Windows.Forms.TextBox();
            this.textBoxPrID = new System.Windows.Forms.TextBox();
            this.labelPrName = new System.Windows.Forms.Label();
            this.labelPrID = new System.Windows.Forms.Label();
            this.labelMaID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.textBoxPageNo = new System.Windows.Forms.TextBox();
            this.labelPage = new System.Windows.Forms.Label();
            this.button_First = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Hide
            // 
            this.button_Hide.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Hide.Location = new System.Drawing.Point(1162, 204);
            this.button_Hide.Name = "button_Hide";
            this.button_Hide.Size = new System.Drawing.Size(75, 36);
            this.button_Hide.TabIndex = 68;
            this.button_Hide.Text = "非表示";
            this.button_Hide.UseVisualStyleBackColor = true;
            this.button_Hide.Click += new System.EventHandler(this.button_Hide_Click);
            // 
            // dateTimePickerPrReleaseDate
            // 
            this.dateTimePickerPrReleaseDate.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerPrReleaseDate.Location = new System.Drawing.Point(791, 45);
            this.dateTimePickerPrReleaseDate.Name = "dateTimePickerPrReleaseDate";
            this.dateTimePickerPrReleaseDate.Size = new System.Drawing.Size(200, 32);
            this.dateTimePickerPrReleaseDate.TabIndex = 67;
            // 
            // labelPrReleaseDate
            // 
            this.labelPrReleaseDate.AutoSize = true;
            this.labelPrReleaseDate.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelPrReleaseDate.Location = new System.Drawing.Point(682, 51);
            this.labelPrReleaseDate.Name = "labelPrReleaseDate";
            this.labelPrReleaseDate.Size = new System.Drawing.Size(69, 25);
            this.labelPrReleaseDate.TabIndex = 66;
            this.labelPrReleaseDate.Text = "発売日";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPrice.Location = new System.Drawing.Point(409, 173);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(139, 32);
            this.textBoxPrice.TabIndex = 65;
            this.textBoxPrice.Text = "1";
            // 
            // labelPrHidden
            // 
            this.labelPrHidden.AutoSize = true;
            this.labelPrHidden.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelPrHidden.Location = new System.Drawing.Point(1042, 82);
            this.labelPrHidden.Name = "labelPrHidden";
            this.labelPrHidden.Size = new System.Drawing.Size(107, 25);
            this.labelPrHidden.TabIndex = 64;
            this.labelPrHidden.Text = "非表示理由";
            // 
            // textBoxPrHidden
            // 
            this.textBoxPrHidden.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPrHidden.Location = new System.Drawing.Point(1049, 110);
            this.textBoxPrHidden.Multiline = true;
            this.textBoxPrHidden.Name = "textBoxPrHidden";
            this.textBoxPrHidden.Size = new System.Drawing.Size(187, 57);
            this.textBoxPrHidden.TabIndex = 63;
            this.textBoxPrHidden.Text = "1";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelPrice.Location = new System.Drawing.Point(315, 176);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 25);
            this.labelPrice.TabIndex = 62;
            this.labelPrice.Text = "価格";
            // 
            // textBoxPrSafetyStock
            // 
            this.textBoxPrSafetyStock.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPrSafetyStock.Location = new System.Drawing.Point(795, 173);
            this.textBoxPrSafetyStock.Name = "textBoxPrSafetyStock";
            this.textBoxPrSafetyStock.Size = new System.Drawing.Size(124, 32);
            this.textBoxPrSafetyStock.TabIndex = 61;
            this.textBoxPrSafetyStock.Text = "1";
            // 
            // labelPrSafetyStock
            // 
            this.labelPrSafetyStock.AutoSize = true;
            this.labelPrSafetyStock.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelPrSafetyStock.Location = new System.Drawing.Point(682, 176);
            this.labelPrSafetyStock.Name = "labelPrSafetyStock";
            this.labelPrSafetyStock.Size = new System.Drawing.Size(107, 25);
            this.labelPrSafetyStock.TabIndex = 60;
            this.labelPrSafetyStock.Text = "安全在庫数";
            // 
            // textBoxPrModelNumber
            // 
            this.textBoxPrModelNumber.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPrModelNumber.Location = new System.Drawing.Point(409, 110);
            this.textBoxPrModelNumber.Name = "textBoxPrModelNumber";
            this.textBoxPrModelNumber.Size = new System.Drawing.Size(237, 32);
            this.textBoxPrModelNumber.TabIndex = 59;
            this.textBoxPrModelNumber.Text = "1";
            // 
            // labelPrModelNumber
            // 
            this.labelPrModelNumber.AutoSize = true;
            this.labelPrModelNumber.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelPrModelNumber.Location = new System.Drawing.Point(315, 113);
            this.labelPrModelNumber.Name = "labelPrModelNumber";
            this.labelPrModelNumber.Size = new System.Drawing.Size(50, 25);
            this.labelPrModelNumber.TabIndex = 58;
            this.labelPrModelNumber.Text = "型番";
            // 
            // textBoxPrColor
            // 
            this.textBoxPrColor.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPrColor.Location = new System.Drawing.Point(795, 110);
            this.textBoxPrColor.Name = "textBoxPrColor";
            this.textBoxPrColor.Size = new System.Drawing.Size(196, 32);
            this.textBoxPrColor.TabIndex = 57;
            this.textBoxPrColor.Text = "1";
            // 
            // labelPrColor
            // 
            this.labelPrColor.AutoSize = true;
            this.labelPrColor.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelPrColor.Location = new System.Drawing.Point(682, 113);
            this.labelPrColor.Name = "labelPrColor";
            this.labelPrColor.Size = new System.Drawing.Size(31, 25);
            this.labelPrColor.TabIndex = 56;
            this.labelPrColor.Text = "色";
            // 
            // textBoxScID
            // 
            this.textBoxScID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxScID.Location = new System.Drawing.Point(164, 173);
            this.textBoxScID.Name = "textBoxScID";
            this.textBoxScID.Size = new System.Drawing.Size(100, 32);
            this.textBoxScID.TabIndex = 55;
            this.textBoxScID.Text = "1";
            // 
            // labelScID
            // 
            this.labelScID.AutoSize = true;
            this.labelScID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelScID.Location = new System.Drawing.Point(69, 176);
            this.labelScID.Name = "labelScID";
            this.labelScID.Size = new System.Drawing.Size(89, 25);
            this.labelScID.TabIndex = 54;
            this.labelScID.Text = "小分類ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1358, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 970);
            this.panel1.TabIndex = 52;
            // 
            // checkBoxPrFlag
            // 
            this.checkBoxPrFlag.AutoSize = true;
            this.checkBoxPrFlag.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.checkBoxPrFlag.Location = new System.Drawing.Point(1047, 50);
            this.checkBoxPrFlag.Name = "checkBoxPrFlag";
            this.checkBoxPrFlag.Size = new System.Drawing.Size(149, 29);
            this.checkBoxPrFlag.TabIndex = 51;
            this.checkBoxPrFlag.Text = "商品管理フラグ";
            this.checkBoxPrFlag.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(62, 246);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowTemplate.Height = 21;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1175, 662);
            this.dataGridViewDsp.TabIndex = 44;
            // 
            // button_Cle
            // 
            this.button_Cle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Cle.Location = new System.Drawing.Point(1080, 204);
            this.button_Cle.Name = "button_Cle";
            this.button_Cle.Size = new System.Drawing.Size(75, 36);
            this.button_Cle.TabIndex = 43;
            this.button_Cle.Text = "クリア";
            this.button_Cle.UseVisualStyleBackColor = true;
            this.button_Cle.Click += new System.EventHandler(this.button_Cle_Click);
            // 
            // button_Upd
            // 
            this.button_Upd.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Upd.Location = new System.Drawing.Point(999, 204);
            this.button_Upd.Name = "button_Upd";
            this.button_Upd.Size = new System.Drawing.Size(75, 36);
            this.button_Upd.TabIndex = 42;
            this.button_Upd.Text = "更新";
            this.button_Upd.UseVisualStyleBackColor = true;
            this.button_Upd.Click += new System.EventHandler(this.button_Upd_Click);
            // 
            // textBoxPrName
            // 
            this.textBoxPrName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPrName.Location = new System.Drawing.Point(409, 48);
            this.textBoxPrName.Name = "textBoxPrName";
            this.textBoxPrName.Size = new System.Drawing.Size(237, 32);
            this.textBoxPrName.TabIndex = 36;
            this.textBoxPrName.Text = "ああああああああああああああ";
            // 
            // textBoxMaID
            // 
            this.textBoxMaID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxMaID.Location = new System.Drawing.Point(164, 110);
            this.textBoxMaID.Name = "textBoxMaID";
            this.textBoxMaID.Size = new System.Drawing.Size(100, 32);
            this.textBoxMaID.TabIndex = 35;
            this.textBoxMaID.Text = "1";
            // 
            // textBoxPrID
            // 
            this.textBoxPrID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPrID.Location = new System.Drawing.Point(164, 48);
            this.textBoxPrID.Name = "textBoxPrID";
            this.textBoxPrID.Size = new System.Drawing.Size(100, 32);
            this.textBoxPrID.TabIndex = 34;
            this.textBoxPrID.Text = "1";
            // 
            // labelPrName
            // 
            this.labelPrName.AutoSize = true;
            this.labelPrName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelPrName.Location = new System.Drawing.Point(315, 51);
            this.labelPrName.Name = "labelPrName";
            this.labelPrName.Size = new System.Drawing.Size(69, 25);
            this.labelPrName.TabIndex = 28;
            this.labelPrName.Text = "商品名";
            // 
            // labelPrID
            // 
            this.labelPrID.AutoSize = true;
            this.labelPrID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelPrID.Location = new System.Drawing.Point(69, 51);
            this.labelPrID.Name = "labelPrID";
            this.labelPrID.Size = new System.Drawing.Size(70, 25);
            this.labelPrID.TabIndex = 26;
            this.labelPrID.Text = "商品ID";
            // 
            // labelMaID
            // 
            this.labelMaID.AutoSize = true;
            this.labelMaID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelMaID.Location = new System.Drawing.Point(69, 113);
            this.labelMaID.Name = "labelMaID";
            this.labelMaID.Size = new System.Drawing.Size(73, 25);
            this.labelMaID.TabIndex = 27;
            this.labelMaID.Text = "メーカID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Last);
            this.panel2.Controls.Add(this.button_Next);
            this.panel2.Controls.Add(this.button_Prev);
            this.panel2.Controls.Add(this.textBoxPageNo);
            this.panel2.Controls.Add(this.labelPage);
            this.panel2.Controls.Add(this.button_First);
            this.panel2.Location = new System.Drawing.Point(966, 914);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 35);
            this.panel2.TabIndex = 138;
            // 
            // button_Last
            // 
            this.button_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Last.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Last.Location = new System.Drawing.Point(235, 0);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(35, 35);
            this.button_Last.TabIndex = 47;
            this.button_Last.Text = "▶|";
            this.button_Last.UseVisualStyleBackColor = true;
            // 
            // button_Next
            // 
            this.button_Next.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Next.Location = new System.Drawing.Point(194, 0);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(35, 35);
            this.button_Next.TabIndex = 50;
            this.button_Next.Text = "▶";
            this.button_Next.UseVisualStyleBackColor = true;
            // 
            // button_Prev
            // 
            this.button_Prev.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Prev.Location = new System.Drawing.Point(153, 0);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(35, 35);
            this.button_Prev.TabIndex = 49;
            this.button_Prev.Text = "◀";
            this.button_Prev.UseVisualStyleBackColor = true;
            // 
            // textBoxPageNo
            // 
            this.textBoxPageNo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPageNo.Location = new System.Drawing.Point(16, 6);
            this.textBoxPageNo.Name = "textBoxPageNo";
            this.textBoxPageNo.Size = new System.Drawing.Size(33, 25);
            this.textBoxPageNo.TabIndex = 45;
            this.textBoxPageNo.Text = "100";
            this.textBoxPageNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPage.Location = new System.Drawing.Point(55, 9);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(39, 17);
            this.labelPage.TabIndex = 46;
            this.labelPage.Text = "ページ";
            // 
            // button_First
            // 
            this.button_First.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_First.Location = new System.Drawing.Point(112, 0);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(35, 35);
            this.button_First.TabIndex = 48;
            this.button_First.Text = "|◀";
            this.button_First.UseVisualStyleBackColor = true;
            // 
            // Product_Upd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 970);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_Hide);
            this.Controls.Add(this.dateTimePickerPrReleaseDate);
            this.Controls.Add(this.labelPrReleaseDate);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrHidden);
            this.Controls.Add(this.textBoxPrHidden);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrSafetyStock);
            this.Controls.Add(this.labelPrSafetyStock);
            this.Controls.Add(this.textBoxPrModelNumber);
            this.Controls.Add(this.labelPrModelNumber);
            this.Controls.Add(this.textBoxPrColor);
            this.Controls.Add(this.labelPrColor);
            this.Controls.Add(this.textBoxScID);
            this.Controls.Add(this.labelScID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxPrFlag);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.button_Cle);
            this.Controls.Add(this.button_Upd);
            this.Controls.Add(this.textBoxPrName);
            this.Controls.Add(this.textBoxMaID);
            this.Controls.Add(this.textBoxPrID);
            this.Controls.Add(this.labelPrName);
            this.Controls.Add(this.labelPrID);
            this.Controls.Add(this.labelMaID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1658, 970);
            this.MinimumSize = new System.Drawing.Size(1658, 970);
            this.Name = "Product_Upd";
            this.Text = "Product_Upd";
            this.Load += new System.EventHandler(this.Product_Upd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Hide;
        private System.Windows.Forms.DateTimePicker dateTimePickerPrReleaseDate;
        private System.Windows.Forms.Label labelPrReleaseDate;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrHidden;
        private System.Windows.Forms.TextBox textBoxPrHidden;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrSafetyStock;
        private System.Windows.Forms.Label labelPrSafetyStock;
        private System.Windows.Forms.TextBox textBoxPrModelNumber;
        private System.Windows.Forms.Label labelPrModelNumber;
        private System.Windows.Forms.TextBox textBoxPrColor;
        private System.Windows.Forms.Label labelPrColor;
        private System.Windows.Forms.TextBox textBoxScID;
        private System.Windows.Forms.Label labelScID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxPrFlag;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Button button_Cle;
        private System.Windows.Forms.Button button_Upd;
        private System.Windows.Forms.TextBox textBoxPrName;
        private System.Windows.Forms.TextBox textBoxMaID;
        private System.Windows.Forms.TextBox textBoxPrID;
        private System.Windows.Forms.Label labelPrName;
        private System.Windows.Forms.Label labelPrID;
        private System.Windows.Forms.Label labelMaID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.TextBox textBoxPageNo;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button button_First;
    }
}