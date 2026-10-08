namespace bai04_BTTL
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
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lblDayVuaNhap = new System.Windows.Forms.Label();
            this.txtDayVuaNhap = new System.Windows.Forms.TextBox();
            this.lblTongPhanTu = new System.Windows.Forms.Label();
            this.txtTongPhanTu = new System.Windows.Forms.TextBox();
            this.lblTongChan = new System.Windows.Forms.Label();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.lblTongLe = new System.Windows.Forms.Label();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.Red;
            this.lblHeader.Location = new System.Drawing.Point(50, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(268, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Nhập Dãy Số và Tính Tổng";
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNhapSo.Location = new System.Drawing.Point(30, 68);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(65, 17);
            this.lblNhapSo.TabIndex = 1;
            this.lblNhapSo.Text = "Nhập số :";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNhapSo.Location = new System.Drawing.Point(175, 65);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(90, 25);
            this.txtNhapSo.TabIndex = 2;
            this.txtNhapSo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhapSo_KeyDown);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNhap.Location = new System.Drawing.Point(275, 62);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 29);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lblDayVuaNhap
            // 
            this.lblDayVuaNhap.AutoSize = true;
            this.lblDayVuaNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDayVuaNhap.Location = new System.Drawing.Point(30, 108);
            this.lblDayVuaNhap.Name = "lblDayVuaNhap";
            this.lblDayVuaNhap.Size = new System.Drawing.Size(98, 17);
            this.lblDayVuaNhap.TabIndex = 4;
            this.lblDayVuaNhap.Text = "Dãy vừa nhập :";
            // 
            // txtDayVuaNhap
            // 
            this.txtDayVuaNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDayVuaNhap.Location = new System.Drawing.Point(175, 105);
            this.txtDayVuaNhap.Name = "txtDayVuaNhap";
            this.txtDayVuaNhap.ReadOnly = true;
            this.txtDayVuaNhap.Size = new System.Drawing.Size(175, 25);
            this.txtDayVuaNhap.TabIndex = 5;
            // 
            // lblTongPhanTu
            // 
            this.lblTongPhanTu.AutoSize = true;
            this.lblTongPhanTu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTongPhanTu.Location = new System.Drawing.Point(30, 148);
            this.lblTongPhanTu.Name = "lblTongPhanTu";
            this.lblTongPhanTu.Size = new System.Drawing.Size(139, 17);
            this.lblTongPhanTu.TabIndex = 6;
            this.lblTongPhanTu.Text = "Tổng phần tử trong dãy:";
            // 
            // txtTongPhanTu
            // 
            this.txtTongPhanTu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongPhanTu.Location = new System.Drawing.Point(175, 145);
            this.txtTongPhanTu.Name = "txtTongPhanTu";
            this.txtTongPhanTu.ReadOnly = true;
            this.txtTongPhanTu.Size = new System.Drawing.Size(65, 25);
            this.txtTongPhanTu.TabIndex = 7;
            // 
            // lblTongChan
            // 
            this.lblTongChan.AutoSize = true;
            this.lblTongChan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTongChan.Location = new System.Drawing.Point(30, 188);
            this.lblTongChan.Name = "lblTongChan";
            this.lblTongChan.Size = new System.Drawing.Size(78, 17);
            this.lblTongChan.TabIndex = 8;
            this.lblTongChan.Text = "Tổng Chẵn :";
            // 
            // txtTongChan
            // 
            this.txtTongChan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongChan.Location = new System.Drawing.Point(115, 185);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.ReadOnly = true;
            this.txtTongChan.Size = new System.Drawing.Size(60, 25);
            this.txtTongChan.TabIndex = 9;
            // 
            // lblTongLe
            // 
            this.lblTongLe.AutoSize = true;
            this.lblTongLe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTongLe.Location = new System.Drawing.Point(195, 188);
            this.lblTongLe.Name = "lblTongLe";
            this.lblTongLe.Size = new System.Drawing.Size(64, 17);
            this.lblTongLe.TabIndex = 10;
            this.lblTongLe.Text = "Tổng Lẻ :";
            // 
            // txtTongLe
            // 
            this.txtTongLe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongLe.Location = new System.Drawing.Point(265, 185);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.ReadOnly = true;
            this.txtTongLe.Size = new System.Drawing.Size(60, 25);
            this.txtTongLe.TabIndex = 11;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTinhTong.Location = new System.Drawing.Point(25, 235);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(95, 30);
            this.btnTinhTong.TabIndex = 12;
            this.btnTinhTong.Text = "Tính Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTiepTuc.Location = new System.Drawing.Point(135, 235);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(95, 30);
            this.btnTiepTuc.TabIndex = 13;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.Location = new System.Drawing.Point(245, 235);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 30);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 285);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.txtTongLe);
            this.Controls.Add(this.lblTongLe);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.lblTongChan);
            this.Controls.Add(this.txtTongPhanTu);
            this.Controls.Add(this.lblTongPhanTu);
            this.Controls.Add(this.txtDayVuaNhap);
            this.Controls.Add(this.lblDayVuaNhap);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dãy số và Tính Tổng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lblDayVuaNhap;
        private System.Windows.Forms.TextBox txtDayVuaNhap;
        private System.Windows.Forms.Label lblTongPhanTu;
        private System.Windows.Forms.TextBox txtTongPhanTu;
        private System.Windows.Forms.Label lblTongChan;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.Label lblTongLe;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
    }
}