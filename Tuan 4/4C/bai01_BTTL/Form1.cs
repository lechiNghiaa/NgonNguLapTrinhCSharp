using System;
using System.Windows.Forms;

namespace bai01_BTTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Kiem tra o a
        private void txtA_Leave(object sender, EventArgs e)
        {
            KiemTraSo(txtA);
        }

        // Kiem tra o b
        private void txtB_Leave(object sender, EventArgs e)
        {
            KiemTraSo(txtB);
        }

        // Chan ky tu khong phai so trong o a
        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChoNhapSo(e, txtA);
        }

        // Chan ky tu khong phai so trong o b
        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChoNhapSo(e, txtB);
        }

        // Chi cho phep nhap so
        private void ChoNhapSo(KeyPressEventArgs e, TextBox textBox)
        {
            // Cho phep Backspace, Delete...
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Cho phep nhap 0 - 9
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Cho phep dau am
            if (e.KeyChar == '-' &&
                textBox.SelectionStart == 0 &&
                !textBox.Text.Contains("-"))
            {
                return;
            }

            // Cho phep dau cham
            if (e.KeyChar == '.' &&
                !textBox.Text.Contains("."))
            {
                return;
            }

            // Chan ky tu khac
            e.Handled = true;
        }

        // Kiem tra du lieu co phai la so khong
        private bool KiemTraSo(TextBox textBox)
        {
            double so;

            // Bo trong
            if (textBox.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    textBox,
                    "Vui long nhap so!"
                );

                return false;
            }

            // Khong phai so
            if (!double.TryParse(textBox.Text, out so))
            {
                errorProvider1.SetError(
                    textBox,
                    "Du lieu phai la so!"
                );

                return false;
            }

            // Du lieu hop le
            errorProvider1.SetError(textBox, "");

            return true;
        }

        // Lay hai so a va b
        private bool LayHaiSo(out double a, out double b)
        {
            a = 0;
            b = 0;

            bool hopLeA = KiemTraSo(txtA);
            bool hopLeB = KiemTraSo(txtB);

            if (!hopLeA || !hopLeB)
            {
                MessageBox.Show(
                    "Vui long nhap a va b la so hop le!",
                    "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }

            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);

            return true;
        }

        // =========================
        // PHEP CONG
        // =========================
        private void btnCong_Click(object sender, EventArgs e)
        {
            double a, b;

            if (!LayHaiSo(out a, out b))
            {
                return;
            }

            double ketQua = a + b;

            txtKetQua.Text = ketQua.ToString();
        }

        // =========================
        // PHEP TRU
        // =========================
        private void btnTru_Click(object sender, EventArgs e)
        {
            double a, b;

            if (!LayHaiSo(out a, out b))
            {
                return;
            }

            double ketQua = a - b;

            txtKetQua.Text = ketQua.ToString();
        }

        // =========================
        // PHEP NHAN
        // =========================
        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a, b;

            if (!LayHaiSo(out a, out b))
            {
                return;
            }

            double ketQua = a * b;

            txtKetQua.Text = ketQua.ToString();
        }

        // =========================
        // PHEP CHIA
        // =========================
        private void btnChia_Click(object sender, EventArgs e)
        {
            double a, b;

            if (!LayHaiSo(out a, out b))
            {
                return;
            }

            // Kiem tra chia cho 0
            if (b == 0)
            {
                MessageBox.Show(
                    "Khong the chia cho 0!",
                    "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtKetQua.Clear();

                txtB.Focus();

                return;
            }

            double ketQua = a / b;

            txtKetQua.Text = ketQua.ToString();
        }

        // =========================
        // XAC NHAN THOAT
        // =========================
        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ban co chac muon thoat chuong trinh?",
                "Xac nhan thoat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}