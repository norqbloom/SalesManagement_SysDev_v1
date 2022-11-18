
namespace SalesManagement_SysDev.Management_Stock
{
    partial class Stock_Ser
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
            this.Sto_Ser_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrID = new System.Windows.Forms.TextBox();
            this.StQuantity = new System.Windows.Forms.TextBox();
            this.StFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 381);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(898, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // Sto_Ser_Button
            // 
            this.Sto_Ser_Button.Location = new System.Drawing.Point(834, 276);
            this.Sto_Ser_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sto_Ser_Button.Name = "Sto_Ser_Button";
            this.Sto_Ser_Button.Size = new System.Drawing.Size(147, 75);
            this.Sto_Ser_Button.TabIndex = 1;
            this.Sto_Ser_Button.Text = "検索";
            this.Sto_Ser_Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "在庫ID";
            // 
            // StID
            // 
            this.StID.Location = new System.Drawing.Point(209, 93);
            this.StID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StID.Name = "StID";
            this.StID.Size = new System.Drawing.Size(81, 22);
            this.StID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "商品ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "在庫数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "在庫管理フラグ";
            // 
            // PrID
            // 
            this.PrID.Location = new System.Drawing.Point(209, 136);
            this.PrID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrID.Name = "PrID";
            this.PrID.Size = new System.Drawing.Size(81, 22);
            this.PrID.TabIndex = 7;
            // 
            // StQuantity
            // 
            this.StQuantity.Location = new System.Drawing.Point(209, 171);
            this.StQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StQuantity.Name = "StQuantity";
            this.StQuantity.Size = new System.Drawing.Size(81, 22);
            this.StQuantity.TabIndex = 8;
            // 
            // StFlag
            // 
            this.StFlag.AutoSize = true;
            this.StFlag.Location = new System.Drawing.Point(209, 217);
            this.StFlag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StFlag.Name = "StFlag";
            this.StFlag.Size = new System.Drawing.Size(34, 19);
            this.StFlag.TabIndex = 9;
            this.StFlag.Text = " ";
            this.StFlag.UseVisualStyleBackColor = true;
            // 
            // Stock_Ser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 707);
            this.Controls.Add(this.StFlag);
            this.Controls.Add(this.StQuantity);
            this.Controls.Add(this.PrID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sto_Ser_Button);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Stock_Ser";
            this.Text = "Stock_Ser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Sto_Ser_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrID;
        private System.Windows.Forms.TextBox StQuantity;
        private System.Windows.Forms.CheckBox StFlag;
    }
}