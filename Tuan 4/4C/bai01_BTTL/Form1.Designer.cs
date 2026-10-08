namespace bai01_BTTL
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblKetQua;

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetQua;

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblA = new Label();
            lblB = new Label();
            lblKetQua = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtKetQua = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(45, 55);
            lblA.Name = "lblA";
            lblA.Size = new Size(40, 23);
            lblA.TabIndex = 0;
            lblA.Text = "a =";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(250, 55);
            lblB.Name = "lblB";
            lblB.Size = new Size(41, 23);
            lblB.TabIndex = 2;
            lblB.Text = "b =";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(19, 92);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(75, 23);
            lblKetQua.TabIndex = 4;
            lblKetQua.Text = "Ket qua";
            // 
            // txtA
            // 
            txtA.BorderStyle = BorderStyle.FixedSingle;
            txtA.Location = new Point(100, 50);
            txtA.Name = "txtA";
            txtA.Size = new Size(120, 30);
            txtA.TabIndex = 1;
            txtA.KeyPress += txtA_KeyPress;
            txtA.Leave += txtA_Leave;
            // 
            // txtB
            // 
            txtB.BorderStyle = BorderStyle.FixedSingle;
            txtB.Location = new Point(305, 50);
            txtB.Name = "txtB";
            txtB.Size = new Size(120, 30);
            txtB.TabIndex = 3;
            txtB.KeyPress += txtB_KeyPress;
            txtB.Leave += txtB_Leave;
            // 
            // txtKetQua
            // 
            txtKetQua.BorderStyle = BorderStyle.FixedSingle;
            txtKetQua.Location = new Point(100, 90);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(325, 30);
            txtKetQua.TabIndex = 5;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(45, 135);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(80, 40);
            btnCong.TabIndex = 6;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(145, 135);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(80, 40);
            btnTru.TabIndex = 7;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(245, 135);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(80, 40);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(345, 135);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(80, 40);
            btnChia.TabIndex = 9;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 215);
            Controls.Add(lblA);
            Controls.Add(txtA);
            Controls.Add(lblB);
            Controls.Add(txtB);
            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Font = new Font("Tahoma", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cong tru nhan chia";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}