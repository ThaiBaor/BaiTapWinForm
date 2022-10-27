
namespace Baitap_Winform
{
    partial class frmBai8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnSoLe = new System.Windows.Forms.Button();
            this.btnSoChan = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Box";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBinhPhuong);
            this.groupBox1.Controls.Add(this.btnXoaChon);
            this.groupBox1.Controls.Add(this.btnSoLe);
            this.groupBox1.Controls.Add(this.btnSoChan);
            this.groupBox1.Controls.Add(this.btnXoaDauCuoi);
            this.groupBox1.Controls.Add(this.btnTong);
            this.groupBox1.Controls.Add(this.btnTang2);
            this.groupBox1.Location = new System.Drawing.Point(292, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 317);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử lí List box";
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(30, 193);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(227, 34);
            this.btnBinhPhuong.TabIndex = 4;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(30, 114);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(227, 34);
            this.btnXoaChon.TabIndex = 2;
            this.btnXoaChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnSoLe
            // 
            this.btnSoLe.Location = new System.Drawing.Point(30, 271);
            this.btnSoLe.Name = "btnSoLe";
            this.btnSoLe.Size = new System.Drawing.Size(227, 34);
            this.btnSoLe.TabIndex = 6;
            this.btnSoLe.Text = "Chọn số lẻ";
            this.btnSoLe.UseVisualStyleBackColor = true;
            this.btnSoLe.Click += new System.EventHandler(this.btnSoLe_Click);
            // 
            // btnSoChan
            // 
            this.btnSoChan.Location = new System.Drawing.Point(30, 233);
            this.btnSoChan.Name = "btnSoChan";
            this.btnSoChan.Size = new System.Drawing.Size(227, 32);
            this.btnSoChan.TabIndex = 5;
            this.btnSoChan.Text = "Chọn số chẵn";
            this.btnSoChan.UseVisualStyleBackColor = true;
            this.btnSoChan.Click += new System.EventHandler(this.btnSoChan_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(30, 71);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(227, 37);
            this.btnXoaDauCuoi.TabIndex = 1;
            this.btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(30, 27);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(227, 38);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng các phân tử trong list";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(30, 154);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(227, 33);
            this.btnTang2.TabIndex = 3;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.btnNhap);
            this.groupBox2.Controls.Add(this.txt);
            this.groupBox2.Location = new System.Drawing.Point(22, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List box";
            // 
            // lst
            // 
            this.lst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 16;
            this.lst.Location = new System.Drawing.Point(29, 133);
            this.lst.Name = "lst";
            this.lst.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst.Size = new System.Drawing.Size(163, 164);
            this.lst.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(29, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(105, 132);
            this.listBox1.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(29, 77);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(163, 33);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(29, 43);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(163, 22);
            this.txt.TabIndex = 0;
            this.txt.Validated += new System.EventHandler(this.txt_Validated);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(457, 427);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(118, 31);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmBai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBai8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bai8";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai8_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnSoLe;
        private System.Windows.Forms.Button btnSoChan;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.ErrorProvider err;
    }
}