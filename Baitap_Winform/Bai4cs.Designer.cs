
namespace Baitap_Winform
{
    partial class frmBai4
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
            System.Windows.Forms.GroupBox groupBox1;
            this.lblTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rdoDo = new System.Windows.Forms.RadioButton();
            this.rdoXanhDuong = new System.Windows.Forms.RadioButton();
            this.rdoXanhLa = new System.Windows.Forms.RadioButton();
            this.rdoTim = new System.Windows.Forms.RadioButton();
            this.chkInDam = new System.Windows.Forms.CheckBox();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.chkNghieng = new System.Windows.Forms.CheckBox();
            this.btnMacDinh = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(164, 329);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(0, 20);
            this.lblTen.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lập Trình Bởi:";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(146, 52);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(207, 27);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.Control;
            groupBox1.Controls.Add(this.rdoTim);
            groupBox1.Controls.Add(this.rdoXanhLa);
            groupBox1.Controls.Add(this.rdoDo);
            groupBox1.Controls.Add(this.rdoXanhDuong);
            groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            groupBox1.Location = new System.Drawing.Point(37, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(143, 156);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Màu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkNghieng);
            this.groupBox2.Controls.Add(this.chkGachChan);
            this.groupBox2.Controls.Add(this.chkInDam);
            this.groupBox2.Location = new System.Drawing.Point(253, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 156);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(355, 370);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rdoDo
            // 
            this.rdoDo.AutoSize = true;
            this.rdoDo.ForeColor = System.Drawing.Color.Red;
            this.rdoDo.Location = new System.Drawing.Point(12, 34);
            this.rdoDo.Name = "rdoDo";
            this.rdoDo.Size = new System.Drawing.Size(47, 21);
            this.rdoDo.TabIndex = 0;
            this.rdoDo.Text = "Đỏ";
            this.rdoDo.UseVisualStyleBackColor = true;
            this.rdoDo.CheckedChanged += new System.EventHandler(this.rdoDo_CheckedChanged);
            // 
            // rdoXanhDuong
            // 
            this.rdoXanhDuong.AutoSize = true;
            this.rdoXanhDuong.ForeColor = System.Drawing.Color.Blue;
            this.rdoXanhDuong.Location = new System.Drawing.Point(12, 61);
            this.rdoXanhDuong.Name = "rdoXanhDuong";
            this.rdoXanhDuong.Size = new System.Drawing.Size(108, 21);
            this.rdoXanhDuong.TabIndex = 0;
            this.rdoXanhDuong.TabStop = true;
            this.rdoXanhDuong.Text = "Xanh Dương";
            this.rdoXanhDuong.UseVisualStyleBackColor = true;
            this.rdoXanhDuong.CheckedChanged += new System.EventHandler(this.rdoXanhDuong_CheckedChanged);
            // 
            // rdoXanhLa
            // 
            this.rdoXanhLa.AutoSize = true;
            this.rdoXanhLa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdoXanhLa.Location = new System.Drawing.Point(12, 88);
            this.rdoXanhLa.Name = "rdoXanhLa";
            this.rdoXanhLa.Size = new System.Drawing.Size(82, 21);
            this.rdoXanhLa.TabIndex = 0;
            this.rdoXanhLa.TabStop = true;
            this.rdoXanhLa.Text = "Xanh Lá";
            this.rdoXanhLa.UseVisualStyleBackColor = true;
            this.rdoXanhLa.CheckedChanged += new System.EventHandler(this.rdoXanhLa_CheckedChanged);
            // 
            // rdoTim
            // 
            this.rdoTim.AutoSize = true;
            this.rdoTim.BackColor = System.Drawing.SystemColors.Control;
            this.rdoTim.ForeColor = System.Drawing.Color.BlueViolet;
            this.rdoTim.Location = new System.Drawing.Point(12, 115);
            this.rdoTim.Name = "rdoTim";
            this.rdoTim.Size = new System.Drawing.Size(52, 21);
            this.rdoTim.TabIndex = 0;
            this.rdoTim.TabStop = true;
            this.rdoTim.Text = "Tím";
            this.rdoTim.UseVisualStyleBackColor = false;
            this.rdoTim.CheckedChanged += new System.EventHandler(this.rdoDen_CheckedChanged);
            // 
            // chkInDam
            // 
            this.chkInDam.AutoSize = true;
            this.chkInDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInDam.Location = new System.Drawing.Point(25, 46);
            this.chkInDam.Name = "chkInDam";
            this.chkInDam.Size = new System.Drawing.Size(80, 21);
            this.chkInDam.TabIndex = 0;
            this.chkInDam.Text = "In Đậm";
            this.chkInDam.UseVisualStyleBackColor = true;
            this.chkInDam.CheckedChanged += new System.EventHandler(this.chkInDam_CheckedChanged);
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachChan.Location = new System.Drawing.Point(25, 73);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(101, 21);
            this.chkGachChan.TabIndex = 0;
            this.chkGachChan.Text = "Gạch Chân";
            this.chkGachChan.UseVisualStyleBackColor = true;
            this.chkGachChan.CheckedChanged += new System.EventHandler(this.chkGachChan_CheckedChanged);
            // 
            // chkNghieng
            // 
            this.chkNghieng.AutoSize = true;
            this.chkNghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNghieng.Location = new System.Drawing.Point(25, 100);
            this.chkNghieng.Name = "chkNghieng";
            this.chkNghieng.Size = new System.Drawing.Size(83, 21);
            this.chkNghieng.TabIndex = 0;
            this.chkNghieng.Text = "Nghiêng";
            this.chkNghieng.UseVisualStyleBackColor = true;
            this.chkNghieng.CheckedChanged += new System.EventHandler(this.chkNghieng_CheckedChanged);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(322, 296);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(88, 25);
            this.btnMacDinh.TabIndex = 4;
            this.btnMacDinh.Text = "Mặc Định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 415);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBai4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai 4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai4_FormClosing);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdoTim;
        private System.Windows.Forms.RadioButton rdoXanhLa;
        private System.Windows.Forms.RadioButton rdoDo;
        private System.Windows.Forms.RadioButton rdoXanhDuong;
        private System.Windows.Forms.CheckBox chkNghieng;
        private System.Windows.Forms.CheckBox chkGachChan;
        private System.Windows.Forms.CheckBox chkInDam;
        private System.Windows.Forms.Button btnMacDinh;
    }
}