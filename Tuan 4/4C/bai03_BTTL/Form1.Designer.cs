namespace bai03_BTTL
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
            lblHeader = new Label();
            lblA = new Label();
            txtA = new TextBox();
            lblB = new Label();
            txtB = new TextBox();
            lblUCLN = new Label();
            txtUCLN = new TextBox();
            lblBCNN = new Label();
            txtBCNN = new TextBox();
            btnThucHien = new Button();
            btnTiepTuc = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(50, 24);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(334, 29);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Ước Số Chung - Bội Số Chung";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Click += lblHeader_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Times New Roman", 11.25F);
            lblA.Location = new Point(69, 91);
            lblA.Name = "lblA";
            lblA.Size = new Size(95, 21);
            lblA.TabIndex = 1;
            lblA.Text = "Nhập số a :";
            // 
            // txtA
            // 
            txtA.Font = new Font("Times New Roman", 11.25F);
            txtA.Location = new Point(217, 87);
            txtA.Margin = new Padding(3, 4, 3, 4);
            txtA.Name = "txtA";
            txtA.Size = new Size(148, 29);
            txtA.TabIndex = 2;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Times New Roman", 11.25F);
            lblB.Location = new Point(69, 144);
            lblB.Name = "lblB";
            lblB.Size = new Size(97, 21);
            lblB.TabIndex = 3;
            lblB.Text = "Nhập số b :";
            // 
            // txtB
            // 
            txtB.Font = new Font("Times New Roman", 11.25F);
            txtB.Location = new Point(217, 140);
            txtB.Margin = new Padding(3, 4, 3, 4);
            txtB.Name = "txtB";
            txtB.Size = new Size(148, 29);
            txtB.TabIndex = 4;
            // 
            // lblUCLN
            // 
            lblUCLN.AutoSize = true;
            lblUCLN.Font = new Font("Times New Roman", 11.25F);
            lblUCLN.Location = new Point(66, 196);
            lblUCLN.Name = "lblUCLN";
            lblUCLN.Size = new Size(190, 21);
            lblUCLN.TabIndex = 5;
            lblUCLN.Text = "Ước số chung lớn nhất :";
            lblUCLN.Click += lblUCLN_Click;
            // 
            // txtUCLN
            // 
            txtUCLN.Font = new Font("Times New Roman", 11.25F);
            txtUCLN.Location = new Point(269, 193);
            txtUCLN.Margin = new Padding(3, 4, 3, 4);
            txtUCLN.Name = "txtUCLN";
            txtUCLN.ReadOnly = true;
            txtUCLN.Size = new Size(97, 29);
            txtUCLN.TabIndex = 6;
            // 
            // lblBCNN
            // 
            lblBCNN.AutoSize = true;
            lblBCNN.Font = new Font("Times New Roman", 11.25F);
            lblBCNN.Location = new Point(69, 251);
            lblBCNN.Name = "lblBCNN";
            lblBCNN.Size = new Size(187, 21);
            lblBCNN.TabIndex = 7;
            lblBCNN.Text = "Bội số chung nhỏ nhất :";
            // 
            // txtBCNN
            // 
            txtBCNN.Font = new Font("Times New Roman", 11.25F);
            txtBCNN.Location = new Point(269, 247);
            txtBCNN.Margin = new Padding(3, 4, 3, 4);
            txtBCNN.Name = "txtBCNN";
            txtBCNN.ReadOnly = true;
            txtBCNN.Size = new Size(97, 29);
            txtBCNN.TabIndex = 8;
            // 
            // btnThucHien
            // 
            btnThucHien.Font = new Font("Times New Roman", 11.25F);
            btnThucHien.Location = new Point(34, 313);
            btnThucHien.Margin = new Padding(3, 4, 3, 4);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(114, 43);
            btnThucHien.TabIndex = 9;
            btnThucHien.Text = "Thực Hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.Font = new Font("Times New Roman", 11.25F);
            btnTiepTuc.Location = new Point(166, 313);
            btnTiepTuc.Margin = new Padding(3, 4, 3, 4);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(114, 43);
            btnTiepTuc.TabIndex = 10;
            btnTiepTuc.Text = "Tiếp Tục";
            btnTiepTuc.UseVisualStyleBackColor = true;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 11.25F);
            btnThoat.Location = new Point(297, 313);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 43);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 387);
            Controls.Add(btnThoat);
            Controls.Add(btnTiepTuc);
            Controls.Add(btnThucHien);
            Controls.Add(txtBCNN);
            Controls.Add(lblBCNN);
            Controls.Add(txtUCLN);
            Controls.Add(lblUCLN);
            Controls.Add(txtB);
            Controls.Add(lblB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ước Số - Bội Số";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblUCLN;
        private System.Windows.Forms.TextBox txtUCLN;
        private System.Windows.Forms.Label lblBCNN;
        private System.Windows.Forms.TextBox txtBCNN;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
    }
}