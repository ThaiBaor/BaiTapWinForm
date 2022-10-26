
namespace Baitap_Winform
{
    partial class frmBai6
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSing = new System.Windows.Forms.RadioButton();
            this.rdoThai = new System.Windows.Forms.RadioButton();
            this.rdoUSA = new System.Windows.Forms.RadioButton();
            this.rdoVietNam = new System.Windows.Forms.RadioButton();
            this.pic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country Flag";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSing);
            this.groupBox1.Controls.Add(this.rdoThai);
            this.groupBox1.Controls.Add(this.rdoUSA);
            this.groupBox1.Controls.Add(this.rdoVietNam);
            this.groupBox1.Location = new System.Drawing.Point(50, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // rdoSing
            // 
            this.rdoSing.AutoSize = true;
            this.rdoSing.Location = new System.Drawing.Point(19, 175);
            this.rdoSing.Name = "rdoSing";
            this.rdoSing.Size = new System.Drawing.Size(94, 21);
            this.rdoSing.TabIndex = 0;
            this.rdoSing.TabStop = true;
            this.rdoSing.Text = "Singapore";
            this.rdoSing.UseVisualStyleBackColor = true;
            this.rdoSing.CheckedChanged += new System.EventHandler(this.rdoSing_CheckedChanged);
            // 
            // rdoThai
            // 
            this.rdoThai.AutoSize = true;
            this.rdoThai.Location = new System.Drawing.Point(19, 122);
            this.rdoThai.Name = "rdoThai";
            this.rdoThai.Size = new System.Drawing.Size(89, 21);
            this.rdoThai.TabIndex = 0;
            this.rdoThai.TabStop = true;
            this.rdoThai.Text = "ThaiLand";
            this.rdoThai.UseVisualStyleBackColor = true;
            this.rdoThai.CheckedChanged += new System.EventHandler(this.rdoThai_CheckedChanged);
            // 
            // rdoUSA
            // 
            this.rdoUSA.AutoSize = true;
            this.rdoUSA.Location = new System.Drawing.Point(19, 71);
            this.rdoUSA.Name = "rdoUSA";
            this.rdoUSA.Size = new System.Drawing.Size(57, 21);
            this.rdoUSA.TabIndex = 0;
            this.rdoUSA.TabStop = true;
            this.rdoUSA.Text = "USA";
            this.rdoUSA.UseVisualStyleBackColor = true;
            this.rdoUSA.CheckedChanged += new System.EventHandler(this.rdoUSA_CheckedChanged);
            // 
            // rdoVietNam
            // 
            this.rdoVietNam.AutoSize = true;
            this.rdoVietNam.Location = new System.Drawing.Point(19, 24);
            this.rdoVietNam.Name = "rdoVietNam";
            this.rdoVietNam.Size = new System.Drawing.Size(82, 21);
            this.rdoVietNam.TabIndex = 0;
            this.rdoVietNam.TabStop = true;
            this.rdoVietNam.Text = "VietNam";
            this.rdoVietNam.UseVisualStyleBackColor = true;
            this.rdoVietNam.CheckedChanged += new System.EventHandler(this.rdoVietNam_CheckedChanged);
            // 
            // pic
            // 
            this.pic.Image = global::Baitap_Winform.Properties.Resources.coSing;
            this.pic.InitialImage = null;
            this.pic.Location = new System.Drawing.Point(347, 101);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(350, 309);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // frmBai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBai6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai 6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai6_FormClosing);
            this.Load += new System.EventHandler(this.frmBai6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSing;
        private System.Windows.Forms.RadioButton rdoThai;
        private System.Windows.Forms.RadioButton rdoUSA;
        private System.Windows.Forms.RadioButton rdoVietNam;
    }
}