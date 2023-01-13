
namespace SalesManagement_SysDev.Management_Stock
{
    partial class Stock_Upd
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
            this.StFlag = new System.Windows.Forms.CheckBox();
            this.StQuantity = new System.Windows.Forms.TextBox();
            this.PrID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sto_Upd_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StFlag
            // 
            this.StFlag.AutoSize = true;
            this.StFlag.Location = new System.Drawing.Point(240, 177);
            this.StFlag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StFlag.Name = "StFlag";
            this.StFlag.Size = new System.Drawing.Size(18, 17);
            this.StFlag.TabIndex = 19;
            this.StFlag.UseVisualStyleBackColor = true;
            // 
            // StQuantity
            // 
            this.StQuantity.Location = new System.Drawing.Point(240, 131);
            this.StQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StQuantity.Name = "StQuantity";
            this.StQuantity.Size = new System.Drawing.Size(81, 22);
            this.StQuantity.TabIndex = 18;
            // 
            // PrID
            // 
            this.PrID.Location = new System.Drawing.Point(240, 96);
            this.PrID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrID.Name = "PrID";
            this.PrID.Size = new System.Drawing.Size(81, 22);
            this.PrID.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "在庫管理フラグ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "在庫数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "商品ID";
            // 
            // StID
            // 
            this.StID.Location = new System.Drawing.Point(240, 53);
            this.StID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StID.Name = "StID";
            this.StID.Size = new System.Drawing.Size(81, 22);
            this.StID.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "在庫ID";
            // 
            // Sto_Upd_Button
            // 
            this.Sto_Upd_Button.Location = new System.Drawing.Point(865, 236);
            this.Sto_Upd_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sto_Upd_Button.Name = "Sto_Upd_Button";
            this.Sto_Upd_Button.Size = new System.Drawing.Size(147, 75);
            this.Sto_Upd_Button.TabIndex = 11;
            this.Sto_Upd_Button.Text = "更新";
            this.Sto_Upd_Button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(125, 341);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(898, 308);
            this.dataGridView1.TabIndex = 10;
            // 
            // Stock_Upd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 702);
            this.Controls.Add(this.StFlag);
            this.Controls.Add(this.StQuantity);
            this.Controls.Add(this.PrID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sto_Upd_Button);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Stock_Upd";
            this.Text = "Stock_Upd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox StFlag;
        private System.Windows.Forms.TextBox StQuantity;
        private System.Windows.Forms.TextBox PrID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sto_Upd_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}