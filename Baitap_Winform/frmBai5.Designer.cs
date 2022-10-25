
namespace Baitap_Winform
{
    partial class frmBai5
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoTNR = new System.Windows.Forms.RadioButton();
            this.rdoAr = new System.Windows.Forms.RadioButton();
            this.rdoTahoma = new System.Windows.Forms.RadioButton();
            this.rdoCN = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(47, 89);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(234, 224);
            this.txtText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập văn bản:";
            // 
            // rdoTNR
            // 
            this.rdoTNR.AutoSize = true;
            this.rdoTNR.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTNR.Location = new System.Drawing.Point(313, 117);
            this.rdoTNR.Name = "rdoTNR";
            this.rdoTNR.Size = new System.Drawing.Size(158, 23);
            this.rdoTNR.TabIndex = 2;
            this.rdoTNR.TabStop = true;
            this.rdoTNR.Text = "Times New Roman";
            this.rdoTNR.UseVisualStyleBackColor = true;
            this.rdoTNR.CheckedChanged += new System.EventHandler(this.rdoTNR_CheckedChanged);
            // 
            // rdoAr
            // 
            this.rdoAr.AutoSize = true;
            this.rdoAr.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAr.Location = new System.Drawing.Point(313, 167);
            this.rdoAr.Name = "rdoAr";
            this.rdoAr.Size = new System.Drawing.Size(59, 26);
            this.rdoAr.TabIndex = 2;
            this.rdoAr.TabStop = true;
            this.rdoAr.Text = "Arial";
            this.rdoAr.UseVisualStyleBackColor = true;
            this.rdoAr.CheckedChanged += new System.EventHandler(this.rdoAr_CheckedChanged);
            // 
            // rdoTahoma
            // 
            this.rdoTahoma.AutoSize = true;
            this.rdoTahoma.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTahoma.Location = new System.Drawing.Point(313, 214);
            this.rdoTahoma.Name = "rdoTahoma";
            this.rdoTahoma.Size = new System.Drawing.Size(91, 25);
            this.rdoTahoma.TabIndex = 2;
            this.rdoTahoma.TabStop = true;
            this.rdoTahoma.Text = "Tahoma";
            this.rdoTahoma.UseVisualStyleBackColor = true;
            this.rdoTahoma.CheckedChanged += new System.EventHandler(this.rdoTahoma_CheckedChanged);
            // 
            // rdoCN
            // 
            this.rdoCN.AutoSize = true;
            this.rdoCN.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCN.Location = new System.Drawing.Point(313, 260);
            this.rdoCN.Name = "rdoCN";
            this.rdoCN.Size = new System.Drawing.Size(140, 24);
            this.rdoCN.TabIndex = 2;
            this.rdoCN.TabStop = true;
            this.rdoCN.Text = "Courier New";
            this.rdoCN.UseVisualStyleBackColor = true;
            this.rdoCN.CheckedChanged += new System.EventHandler(this.rdoCN_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(417, 326);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 370);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.rdoCN);
            this.Controls.Add(this.rdoTahoma);
            this.Controls.Add(this.rdoAr);
            this.Controls.Add(this.rdoTNR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Name = "frmBai5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai 5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai5_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoTNR;
        private System.Windows.Forms.RadioButton rdoAr;
        private System.Windows.Forms.RadioButton rdoTahoma;
        private System.Windows.Forms.RadioButton rdoCN;
        private System.Windows.Forms.Button btnThoat;
    }
}