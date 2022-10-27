
namespace Baitap_Winform
{
    partial class frmBai9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSoMoi = new System.Windows.Forms.TextBox();
            this.txtDinhMuc = new System.Windows.Forms.TextBox();
            this.txtTieuThu = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSoCu = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO TIÊU THỤ ĐIỆN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "HỌ TÊN KH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "KHU VỰC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐỊNH MỨC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "SỐ CŨ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "SỐ MỚI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "TIÊU THỤ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "THÀNH TIỀN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "TỔNG TIỀN:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(137, 83);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(184, 22);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtSoMoi
            // 
            this.txtSoMoi.Location = new System.Drawing.Point(137, 249);
            this.txtSoMoi.Name = "txtSoMoi";
            this.txtSoMoi.Size = new System.Drawing.Size(184, 22);
            this.txtSoMoi.TabIndex = 1;
            this.txtSoMoi.TextChanged += new System.EventHandler(this.txtSoMoi_TextChanged);
            // 
            // txtDinhMuc
            // 
            this.txtDinhMuc.Location = new System.Drawing.Point(137, 164);
            this.txtDinhMuc.Name = "txtDinhMuc";
            this.txtDinhMuc.ReadOnly = true;
            this.txtDinhMuc.Size = new System.Drawing.Size(184, 22);
            this.txtDinhMuc.TabIndex = 1;
            // 
            // txtTieuThu
            // 
            this.txtTieuThu.Location = new System.Drawing.Point(137, 297);
            this.txtTieuThu.Name = "txtTieuThu";
            this.txtTieuThu.ReadOnly = true;
            this.txtTieuThu.Size = new System.Drawing.Size(184, 22);
            this.txtTieuThu.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(137, 337);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(184, 22);
            this.txtThanhTien.TabIndex = 1;
            // 
            // txtSoCu
            // 
            this.txtSoCu.Location = new System.Drawing.Point(137, 203);
            this.txtSoCu.Name = "txtSoCu";
            this.txtSoCu.Size = new System.Drawing.Size(184, 22);
            this.txtSoCu.TabIndex = 1;
            this.txtSoCu.Validated += new System.EventHandler(this.txtSoCu_Validated);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(506, 397);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(186, 22);
            this.txtTong.TabIndex = 1;
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboKhuVuc.Location = new System.Drawing.Point(137, 118);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(184, 24);
            this.cboKhuVuc.TabIndex = 2;
            this.cboKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cboKhuVuc_SelectedIndexChanged);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(12, 394);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(98, 32);
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.Text = "TÍNH TIỀN";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Location = new System.Drawing.Point(126, 392);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(106, 34);
            this.btnNhapMoi.TabIndex = 3;
            this.btnNhapMoi.Text = "NHẬP MỚI";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(249, 391);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 34);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(899, 393);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lstv
            // 
            this.lstv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstv.FullRowSelect = true;
            this.lstv.GridLines = true;
            this.lstv.HideSelection = false;
            this.lstv.Location = new System.Drawing.Point(371, 23);
            this.lstv.Name = "lstv";
            this.lstv.Size = new System.Drawing.Size(619, 336);
            this.lstv.TabIndex = 4;
            this.lstv.UseCompatibleStateImageBehavior = false;
            this.lstv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Khu vực";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Định mức";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tiêu thụ";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành tiền";
            this.columnHeader5.Width = 132;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmBai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.lstv);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhapMoi);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.cboKhuVuc);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtSoCu);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtTieuThu);
            this.Controls.Add(this.txtDinhMuc);
            this.Controls.Add(this.txtSoMoi);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBai9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai 9";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSoMoi;
        private System.Windows.Forms.TextBox txtDinhMuc;
        private System.Windows.Forms.TextBox txtTieuThu;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSoCu;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView lstv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ErrorProvider err;
    }
}