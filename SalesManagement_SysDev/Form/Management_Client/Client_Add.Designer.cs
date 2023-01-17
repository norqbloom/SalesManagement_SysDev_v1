
namespace SalesManagement_SysDev.Management_Client
{
    partial class Client_Add
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.textBoxPageNo = new System.Windows.Forms.TextBox();
            this.labelPage = new System.Windows.Forms.Label();
            this.button_First = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxClFlag = new System.Windows.Forms.CheckBox();
            this.textBoxClPostal = new System.Windows.Forms.TextBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.button_Cle = new System.Windows.Forms.Button();
            this.textBoxClFAX = new System.Windows.Forms.TextBox();
            this.textBoxClAddress = new System.Windows.Forms.TextBox();
            this.textBoxClPhone = new System.Windows.Forms.TextBox();
            this.textBoxClName = new System.Windows.Forms.TextBox();
            this.textBoxSoID = new System.Windows.Forms.TextBox();
            this.textBoxClID = new System.Windows.Forms.TextBox();
            this.label_ClFAX = new System.Windows.Forms.Label();
            this.label_ClAddress = new System.Windows.Forms.Label();
            this.label_ClPostal = new System.Windows.Forms.Label();
            this.label_ClPhone = new System.Windows.Forms.Label();
            this.label_ClName = new System.Windows.Forms.Label();
            this.label_SoID = new System.Windows.Forms.Label();
            this.label_ClID = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Last);
            this.panel2.Controls.Add(this.button_Next);
            this.panel2.Controls.Add(this.button_Prev);
            this.panel2.Controls.Add(this.textBoxPageNo);
            this.panel2.Controls.Add(this.labelPage);
            this.panel2.Controls.Add(this.button_First);
            this.panel2.Location = new System.Drawing.Point(995, 914);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 35);
            this.panel2.TabIndex = 53;
            // 
            // button_Last
            // 
            this.button_Last.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Last.Location = new System.Drawing.Point(207, 0);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(35, 35);
            this.button_Last.TabIndex = 47;
            this.button_Last.Text = "▶|";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // button_Next
            // 
            this.button_Next.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Next.Location = new System.Drawing.Point(166, 0);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(35, 35);
            this.button_Next.TabIndex = 50;
            this.button_Next.Text = "▶";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Prev
            // 
            this.button_Prev.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Prev.Location = new System.Drawing.Point(125, 0);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(35, 35);
            this.button_Prev.TabIndex = 49;
            this.button_Prev.Text = "◀";
            this.button_Prev.UseVisualStyleBackColor = true;
            this.button_Prev.Click += new System.EventHandler(this.button_Prev_Click);
            // 
            // textBoxPageNo
            // 
            this.textBoxPageNo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPageNo.Location = new System.Drawing.Point(0, 6);
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
            this.labelPage.Location = new System.Drawing.Point(39, 9);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(39, 17);
            this.labelPage.TabIndex = 46;
            this.labelPage.Text = "ページ";
            // 
            // button_First
            // 
            this.button_First.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_First.Location = new System.Drawing.Point(84, 0);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(35, 35);
            this.button_First.TabIndex = 48;
            this.button_First.Text = "|◀";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
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
            // checkBoxClFlag
            // 
            this.checkBoxClFlag.AutoSize = true;
            this.checkBoxClFlag.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.checkBoxClFlag.Location = new System.Drawing.Point(972, 169);
            this.checkBoxClFlag.Name = "checkBoxClFlag";
            this.checkBoxClFlag.Size = new System.Drawing.Size(149, 29);
            this.checkBoxClFlag.TabIndex = 51;
            this.checkBoxClFlag.Text = "顧客管理フラグ";
            this.checkBoxClFlag.UseVisualStyleBackColor = true;
            // 
            // textBoxClPostal
            // 
            this.textBoxClPostal.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxClPostal.Location = new System.Drawing.Point(452, 110);
            this.textBoxClPostal.Name = "textBoxClPostal";
            this.textBoxClPostal.Size = new System.Drawing.Size(157, 32);
            this.textBoxClPostal.TabIndex = 38;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(62, 246);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowTemplate.Height = 21;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1175, 662);
            this.dataGridViewDsp.TabIndex = 44;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // button_Cle
            // 
            this.button_Cle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Cle.Location = new System.Drawing.Point(1161, 204);
            this.button_Cle.Name = "button_Cle";
            this.button_Cle.Size = new System.Drawing.Size(75, 36);
            this.button_Cle.TabIndex = 43;
            this.button_Cle.Text = "クリア";
            this.button_Cle.UseVisualStyleBackColor = true;
            this.button_Cle.Click += new System.EventHandler(this.button_Cle_Click);
            // 
            // textBoxClFAX
            // 
            this.textBoxClFAX.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxClFAX.Location = new System.Drawing.Point(1061, 110);
            this.textBoxClFAX.Name = "textBoxClFAX";
            this.textBoxClFAX.Size = new System.Drawing.Size(91, 32);
            this.textBoxClFAX.TabIndex = 40;
            this.textBoxClFAX.Text = "6666666";
            // 
            // textBoxClAddress
            // 
            this.textBoxClAddress.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxClAddress.Location = new System.Drawing.Point(452, 167);
            this.textBoxClAddress.Name = "textBoxClAddress";
            this.textBoxClAddress.Size = new System.Drawing.Size(417, 32);
            this.textBoxClAddress.TabIndex = 39;
            this.textBoxClAddress.Text = "奈良県橿原市五条野町392-2ハイツあすか路3-202";
            // 
            // textBoxClPhone
            // 
            this.textBoxClPhone.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxClPhone.Location = new System.Drawing.Point(1061, 51);
            this.textBoxClPhone.Name = "textBoxClPhone";
            this.textBoxClPhone.Size = new System.Drawing.Size(157, 32);
            this.textBoxClPhone.TabIndex = 37;
            this.textBoxClPhone.Text = "0000000000000";
            // 
            // textBoxClName
            // 
            this.textBoxClName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxClName.Location = new System.Drawing.Point(452, 48);
            this.textBoxClName.Name = "textBoxClName";
            this.textBoxClName.Size = new System.Drawing.Size(237, 32);
            this.textBoxClName.TabIndex = 36;
            this.textBoxClName.Text = "ああああああああああああああ";
            // 
            // textBoxSoID
            // 
            this.textBoxSoID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxSoID.Location = new System.Drawing.Point(164, 110);
            this.textBoxSoID.Name = "textBoxSoID";
            this.textBoxSoID.Size = new System.Drawing.Size(100, 32);
            this.textBoxSoID.TabIndex = 35;
            this.textBoxSoID.Text = "1";
            // 
            // textBoxClID
            // 
            this.textBoxClID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxClID.Location = new System.Drawing.Point(164, 48);
            this.textBoxClID.Name = "textBoxClID";
            this.textBoxClID.Size = new System.Drawing.Size(100, 32);
            this.textBoxClID.TabIndex = 34;
            this.textBoxClID.Text = "1";
            // 
            // label_ClFAX
            // 
            this.label_ClFAX.AutoSize = true;
            this.label_ClFAX.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_ClFAX.Location = new System.Drawing.Point(967, 113);
            this.label_ClFAX.Name = "label_ClFAX";
            this.label_ClFAX.Size = new System.Drawing.Size(46, 25);
            this.label_ClFAX.TabIndex = 32;
            this.label_ClFAX.Text = "FAX";
            // 
            // label_ClAddress
            // 
            this.label_ClAddress.AutoSize = true;
            this.label_ClAddress.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_ClAddress.Location = new System.Drawing.Point(358, 170);
            this.label_ClAddress.Name = "label_ClAddress";
            this.label_ClAddress.Size = new System.Drawing.Size(50, 25);
            this.label_ClAddress.TabIndex = 31;
            this.label_ClAddress.Text = "住所";
            // 
            // label_ClPostal
            // 
            this.label_ClPostal.AutoSize = true;
            this.label_ClPostal.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_ClPostal.Location = new System.Drawing.Point(358, 113);
            this.label_ClPostal.Name = "label_ClPostal";
            this.label_ClPostal.Size = new System.Drawing.Size(88, 25);
            this.label_ClPostal.TabIndex = 30;
            this.label_ClPostal.Text = "郵便番号";
            // 
            // label_ClPhone
            // 
            this.label_ClPhone.AutoSize = true;
            this.label_ClPhone.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_ClPhone.Location = new System.Drawing.Point(967, 51);
            this.label_ClPhone.Name = "label_ClPhone";
            this.label_ClPhone.Size = new System.Drawing.Size(88, 25);
            this.label_ClPhone.TabIndex = 29;
            this.label_ClPhone.Text = "電話番号";
            // 
            // label_ClName
            // 
            this.label_ClName.AutoSize = true;
            this.label_ClName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_ClName.Location = new System.Drawing.Point(358, 51);
            this.label_ClName.Name = "label_ClName";
            this.label_ClName.Size = new System.Drawing.Size(69, 25);
            this.label_ClName.TabIndex = 28;
            this.label_ClName.Text = "顧客名";
            // 
            // label_SoID
            // 
            this.label_SoID.AutoSize = true;
            this.label_SoID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_SoID.Location = new System.Drawing.Point(69, 113);
            this.label_SoID.Name = "label_SoID";
            this.label_SoID.Size = new System.Drawing.Size(89, 25);
            this.label_SoID.TabIndex = 27;
            this.label_SoID.Text = "営業所ID";
            // 
            // label_ClID
            // 
            this.label_ClID.AutoSize = true;
            this.label_ClID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_ClID.Location = new System.Drawing.Point(69, 51);
            this.label_ClID.Name = "label_ClID";
            this.label_ClID.Size = new System.Drawing.Size(70, 25);
            this.label_ClID.TabIndex = 26;
            this.label_ClID.Text = "顧客ID";
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Add.Location = new System.Drawing.Point(1080, 204);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 36);
            this.button_Add.TabIndex = 55;
            this.button_Add.Text = "登録";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Client_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 970);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxClFlag);
            this.Controls.Add(this.textBoxClPostal);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.button_Cle);
            this.Controls.Add(this.textBoxClFAX);
            this.Controls.Add(this.textBoxClAddress);
            this.Controls.Add(this.textBoxClPhone);
            this.Controls.Add(this.textBoxClName);
            this.Controls.Add(this.textBoxSoID);
            this.Controls.Add(this.textBoxClID);
            this.Controls.Add(this.label_ClFAX);
            this.Controls.Add(this.label_ClAddress);
            this.Controls.Add(this.label_ClPostal);
            this.Controls.Add(this.label_ClPhone);
            this.Controls.Add(this.label_ClName);
            this.Controls.Add(this.label_SoID);
            this.Controls.Add(this.label_ClID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1658, 970);
            this.MinimumSize = new System.Drawing.Size(1658, 970);
            this.Name = "Client_Add";
            this.Text = "Client_Add";
            this.Load += new System.EventHandler(this.Client_Add_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.TextBox textBoxPageNo;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxClFlag;
        private System.Windows.Forms.TextBox textBoxClPostal;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Button button_Cle;
        private System.Windows.Forms.TextBox textBoxClFAX;
        private System.Windows.Forms.TextBox textBoxClAddress;
        private System.Windows.Forms.TextBox textBoxClPhone;
        private System.Windows.Forms.TextBox textBoxClName;
        private System.Windows.Forms.TextBox textBoxSoID;
        private System.Windows.Forms.TextBox textBoxClID;
        private System.Windows.Forms.Label label_ClFAX;
        private System.Windows.Forms.Label label_ClAddress;
        private System.Windows.Forms.Label label_ClPostal;
        private System.Windows.Forms.Label label_ClPhone;
        private System.Windows.Forms.Label label_ClName;
        private System.Windows.Forms.Label label_SoID;
        private System.Windows.Forms.Label label_ClID;
        private System.Windows.Forms.Button button_Add;
    }
}