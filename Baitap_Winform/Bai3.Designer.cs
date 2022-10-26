
namespace Baitap_Winform
{
    partial class frmBai3
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMultiple = new System.Windows.Forms.RadioButton();
            this.rbtnDivide = new System.Windows.Forms.RadioButton();
            this.rbtnMinus = new System.Windows.Forms.RadioButton();
            this.rbtnPlus = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Result:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(111, 38);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(220, 22);
            this.txtA.TabIndex = 1;
            this.txtA.Validated += new System.EventHandler(this.txtA_Validated);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(111, 84);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(220, 22);
            this.txtB.TabIndex = 1;
            this.txtB.Validated += new System.EventHandler(this.txtB_Validated);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(111, 130);
            this.txtR.Name = "txtR";
            this.txtR.ReadOnly = true;
            this.txtR.Size = new System.Drawing.Size(220, 22);
            this.txtR.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMultiple);
            this.groupBox1.Controls.Add(this.rbtnDivide);
            this.groupBox1.Controls.Add(this.rbtnMinus);
            this.groupBox1.Controls.Add(this.rbtnPlus);
            this.groupBox1.Location = new System.Drawing.Point(370, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operator";
            // 
            // rbtnMultiple
            // 
            this.rbtnMultiple.AutoSize = true;
            this.rbtnMultiple.Location = new System.Drawing.Point(135, 46);
            this.rbtnMultiple.Name = "rbtnMultiple";
            this.rbtnMultiple.Size = new System.Drawing.Size(77, 21);
            this.rbtnMultiple.TabIndex = 0;
            this.rbtnMultiple.TabStop = true;
            this.rbtnMultiple.Text = "Multiple";
            this.rbtnMultiple.UseVisualStyleBackColor = true;
            this.rbtnMultiple.CheckedChanged += new System.EventHandler(this.rbtnMultiple_CheckedChanged);
            // 
            // rbtnDivide
            // 
            this.rbtnDivide.AutoSize = true;
            this.rbtnDivide.Location = new System.Drawing.Point(135, 98);
            this.rbtnDivide.Name = "rbtnDivide";
            this.rbtnDivide.Size = new System.Drawing.Size(68, 21);
            this.rbtnDivide.TabIndex = 0;
            this.rbtnDivide.TabStop = true;
            this.rbtnDivide.Text = "Divide";
            this.rbtnDivide.UseVisualStyleBackColor = true;
            this.rbtnDivide.CheckedChanged += new System.EventHandler(this.rbtnDivide_CheckedChanged);
            // 
            // rbtnMinus
            // 
            this.rbtnMinus.AutoSize = true;
            this.rbtnMinus.Location = new System.Drawing.Point(27, 98);
            this.rbtnMinus.Name = "rbtnMinus";
            this.rbtnMinus.Size = new System.Drawing.Size(66, 21);
            this.rbtnMinus.TabIndex = 0;
            this.rbtnMinus.TabStop = true;
            this.rbtnMinus.Text = "Minus";
            this.rbtnMinus.UseVisualStyleBackColor = true;
            this.rbtnMinus.CheckedChanged += new System.EventHandler(this.rbtnMinus_CheckedChanged);
            // 
            // rbtnPlus
            // 
            this.rbtnPlus.AutoSize = true;
            this.rbtnPlus.Location = new System.Drawing.Point(27, 46);
            this.rbtnPlus.Name = "rbtnPlus";
            this.rbtnPlus.Size = new System.Drawing.Size(56, 21);
            this.rbtnPlus.TabIndex = 0;
            this.rbtnPlus.TabStop = true;
            this.rbtnPlus.Text = "Plus";
            this.rbtnPlus.UseVisualStyleBackColor = true;
            this.rbtnPlus.CheckedChanged += new System.EventHandler(this.rbtnPlus_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 197);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBai3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai 3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai3_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMultiple;
        private System.Windows.Forms.RadioButton rbtnDivide;
        private System.Windows.Forms.RadioButton rbtnMinus;
        private System.Windows.Forms.RadioButton rbtnPlus;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}