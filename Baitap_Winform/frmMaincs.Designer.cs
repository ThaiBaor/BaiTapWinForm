
namespace Baitap_Winform
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMain
            // 
            this.mnuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBai1,
            this.mnuBai2,
            this.mnuBai3,
            this.mnuBai4,
            this.mnuBai5});
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(67, 24);
            this.mnuMain.Text = "Phần 1";
            // 
            // mnuBai1
            // 
            this.mnuBai1.Name = "mnuBai1";
            this.mnuBai1.Size = new System.Drawing.Size(224, 26);
            this.mnuBai1.Text = "Bài 1";
            this.mnuBai1.Click += new System.EventHandler(this.mnuBai1_Click);
            // 
            // mnuBai2
            // 
            this.mnuBai2.Name = "mnuBai2";
            this.mnuBai2.Size = new System.Drawing.Size(224, 26);
            this.mnuBai2.Text = "Bài 2";
            this.mnuBai2.Click += new System.EventHandler(this.mnuBai2_Click);
            // 
            // mnuBai3
            // 
            this.mnuBai3.Name = "mnuBai3";
            this.mnuBai3.Size = new System.Drawing.Size(224, 26);
            this.mnuBai3.Text = "Bài 3";
            this.mnuBai3.Click += new System.EventHandler(this.mnuBai3_Click);
            // 
            // mnuBai4
            // 
            this.mnuBai4.Name = "mnuBai4";
            this.mnuBai4.Size = new System.Drawing.Size(224, 26);
            this.mnuBai4.Text = "Bài 4";
            this.mnuBai4.Click += new System.EventHandler(this.mnuBai4_Click);
            // 
            // mnuBai5
            // 
            this.mnuBai5.Name = "mnuBai5";
            this.mnuBai5.Size = new System.Drawing.Size(224, 26);
            this.mnuBai5.Text = "Bài 5";
            this.mnuBai5.Click += new System.EventHandler(this.mnuBai5_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng Hợp Bài Tập";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuBai1;
        private System.Windows.Forms.ToolStripMenuItem mnuBai2;
        private System.Windows.Forms.ToolStripMenuItem mnuBai3;
        private System.Windows.Forms.ToolStripMenuItem mnuBai4;
        private System.Windows.Forms.ToolStripMenuItem mnuBai5;
    }
}