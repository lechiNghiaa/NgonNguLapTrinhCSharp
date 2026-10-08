namespace bai01_BTTL
{
    partial class Form1
    {
        /// <summary>
        /// Biến quản lý các thành phần designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Giải phóng tài nguyên đang sử dụng.
        /// </summary>
        /// <param name="disposing">true nếu giải phóng tài nguyên quản lý; ngược lại false.</param>
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
        /// Phương thức khởi tạo các thành phần giao diện.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpLuaChon = new System.Windows.Forms.GroupBox();
            this.radBacHai = new System.Windows.Forms.RadioButton();
            this.radBacNhat = new System.Windows.Forms.RadioButton();
            this.lblNhapA = new System.Windows.Forms.Label();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.lblNhapB = new System.Windows.Forms.Label();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.lblNhapC = new System.Windows.Forms.Label();
            this.txtNhapC = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.Red;
            this.lblHeader.Location = new System.Drawing.Point(85, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(206, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // grpLuaChon
            // 
            this.grpLuaChon.Controls.Add(this.radBacHai);
            this.grpLuaChon.Controls.Add(this.radBacNhat);
            this.grpLuaChon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpLuaChon.Location = new System.Drawing.Point(30, 60);
            this.grpLuaChon.Name = "grpLuaChon";
            this.grpLuaChon.Size = new System.Drawing.Size(325, 95);
            this.grpLuaChon.TabIndex = 1;
            this.grpLuaChon.TabStop = false;
            this.grpLuaChon.Text = "Bạn vui lòng chọn";
            // 
            // radBacHai
            // 
            this.radBacHai.AutoSize = true;
            this.radBacHai.Location = new System.Drawing.Point(40, 58);
            this.radBacHai.Name = "radBacHai";
            this.radBacHai.Size = new System.Drawing.Size(142, 21);
            this.radBacHai.TabIndex = 1;
            this.radBacHai.Text = "Phương trình bậc hai";
            this.radBacHai.UseVisualStyleBackColor = true;
            this.radBacHai.CheckedChanged += new System.EventHandler(this.radBac_CheckedChanged);
            // 
            // radBacNhat
            // 
            this.radBacNhat.AutoSize = true;
            this.radBacNhat.Checked = true;
            this.radBacNhat.Location = new System.Drawing.Point(40, 26);
            this.radBacNhat.Name = "radBacNhat";
            this.radBacNhat.Size = new System.Drawing.Size(151, 21);
            this.radBacNhat.TabIndex = 0;
            this.radBacNhat.TabStop = true;
            this.radBacNhat.Text = "Phương trình bậc nhất";
            this.radBacNhat.UseVisualStyleBackColor = true;
            this.radBacNhat.CheckedChanged += new System.EventHandler(this.radBac_CheckedChanged);
            // 
            // lblNhapA
            // 
            this.lblNhapA.AutoSize = true;
            this.lblNhapA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNhapA.Location = new System.Drawing.Point(30, 178);
            this.lblNhapA.Name = "lblNhapA";
            this.lblNhapA.Size = new System.Drawing.Size(48, 17);
            this.lblNhapA.TabIndex = 2;
            this.lblNhapA.Text = "Nhập a";
            // 
            // txtNhapA
            // 
            this.txtNhapA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNhapA.Location = new System.Drawing.Point(95, 175);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(140, 25);
            this.txtNhapA.TabIndex = 3;
            this.txtNhapA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNhapA.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // lblNhapB
            // 
            this.lblNhapB.AutoSize = true;
            this.lblNhapB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNhapB.Location = new System.Drawing.Point(30, 218);
            this.lblNhapB.Name = "lblNhapB";
            this.lblNhapB.Size = new System.Drawing.Size(49, 17);
            this.lblNhapB.TabIndex = 4;
            this.lblNhapB.Text = "Nhập b";
            // 
            // txtNhapB
            // 
            this.txtNhapB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNhapB.Location = new System.Drawing.Point(95, 215);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(140, 25);
            this.txtNhapB.TabIndex = 5;
            this.txtNhapB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNhapB.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // lblNhapC
            // 
            this.lblNhapC.AutoSize = true;
            this.lblNhapC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNhapC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblNhapC.Location = new System.Drawing.Point(30, 258);
            this.lblNhapC.Name = "lblNhapC";
            this.lblNhapC.Size = new System.Drawing.Size(48, 17);
            this.lblNhapC.TabIndex = 6;
            this.lblNhapC.Text = "Nhập c";
            // 
            // txtNhapC
            // 
            this.txtNhapC.Enabled = false;
            this.txtNhapC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNhapC.Location = new System.Drawing.Point(95, 255);
            this.txtNhapC.Name = "txtNhapC";
            this.txtNhapC.Size = new System.Drawing.Size(140, 25);
            this.txtNhapC.TabIndex = 7;
            this.txtNhapC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNhapC.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKetQua.Location = new System.Drawing.Point(30, 298);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(52, 17);
            this.lblKetQua.TabIndex = 8;
            this.lblKetQua.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKetQua.Location = new System.Drawing.Point(95, 295);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(260, 55);
            this.txtKetQua.TabIndex = 9;
            // 
            // btnGiai
            // 
            this.btnGiai.Enabled = false;
            this.btnGiai.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGiai.Location = new System.Drawing.Point(260, 175);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(95, 42);
            this.btnGiai.TabIndex = 10;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.Location = new System.Drawing.Point(260, 235);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 42);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 375);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtNhapC);
            this.Controls.Add(this.lblNhapC);
            this.Controls.Add(this.txtNhapB);
            this.Controls.Add(this.lblNhapB);
            this.Controls.Add(this.txtNhapA);
            this.Controls.Add(this.lblNhapA);
            this.Controls.Add(this.grpLuaChon);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải phương trình bậc 1-2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLuaChon.ResumeLayout(false);
            this.grpLuaChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpLuaChon;
        private System.Windows.Forms.RadioButton radBacHai;
        private System.Windows.Forms.RadioButton radBacNhat;
        private System.Windows.Forms.Label lblNhapA;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.Label lblNhapB;
        private System.Windows.Forms.TextBox txtNhapB;
        private System.Windows.Forms.Label lblNhapC;
        private System.Windows.Forms.TextBox txtNhapC;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnThoat;
    }
}