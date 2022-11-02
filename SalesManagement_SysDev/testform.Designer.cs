
namespace SalesManagement_SysDev
{
    partial class testform
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
            this.userControl11 = new SalesManagement_SysDev.Management_Client.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(139, 69);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1066, 674);
            this.userControl11.TabIndex = 0;
            // 
            // testform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 819);
            this.Controls.Add(this.userControl11);
            this.Name = "testform";
            this.Text = "testform";
            this.Load += new System.EventHandler(this.testform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Management_Client.UserControl1 userControl11;
    }
}