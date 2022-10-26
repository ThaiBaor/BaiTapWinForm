
namespace Baitap_Winform
{
    partial class frmBai7
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboText = new System.Windows.Forms.ComboBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnNguyenTo = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboText);
            this.groupBox1.Controls.Add(this.txtText);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Location = new System.Drawing.Point(57, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // cboText
            // 
            this.cboText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboText.FormattingEnabled = true;
            this.cboText.Location = new System.Drawing.Point(24, 84);
            this.cboText.Name = "cboText";
            this.cboText.Size = new System.Drawing.Size(229, 24);
            this.cboText.TabIndex = 2;
            this.cboText.SelectedIndexChanged += new System.EventHandler(this.cboText_SelectedIndexChanged);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(24, 36);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 22);
            this.txtText.TabIndex = 0;
            this.txtText.Validated += new System.EventHandler(this.txtText_Validated);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(149, 28);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(104, 39);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst);
            this.groupBox2.Location = new System.Drawing.Point(344, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 16;
            this.lst.Location = new System.Drawing.Point(6, 24);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(230, 148);
            this.lst.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(57, 338);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(344, 301);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(242, 40);
            this.btnChan.TabIndex = 2;
            this.btnChan.Text = "Số lượng các ước số chẵn";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(344, 254);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(242, 41);
            this.btnTong.TabIndex = 1;
            this.btnTong.Text = "Tổng các ước số";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnNguyenTo
            // 
            this.btnNguyenTo.Location = new System.Drawing.Point(344, 347);
            this.btnNguyenTo.Name = "btnNguyenTo";
            this.btnNguyenTo.Size = new System.Drawing.Size(242, 34);
            this.btnNguyenTo.TabIndex = 3;
            this.btnNguyenTo.Text = "Số lượng các ước số nguyên tố";
            this.btnNguyenTo.UseVisualStyleBackColor = true;
            this.btnNguyenTo.Click += new System.EventHandler(this.btnNguyenTo_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmBai7
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 418);
            this.Controls.Add(this.btnNguyenTo);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnChan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBai7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai 7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai7_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnNguyenTo;
        private System.Windows.Forms.ErrorProvider err;
    }
}