using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai01_BTTL
{
    // ==========================================
    // YÊU CẦU 1: KHAI BÁO CLASS PhuongTrinhBacHai
    // ==========================================
    public class PhuongTrinhBacHai
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public PhuongTrinhBacHai() { }

        public PhuongTrinhBacHai(double a, double b, double c = 0)
        {
            A = a;
            B = b;
            C = c;
        }

        // Phương thức giải phương trình bậc nhất: A * x + B = 0
        public string GiaiBacNhat()
        {
            if (A == 0)
            {
                if (B == 0)
                    return "Phương trình có vô số nghiệm.";
                else
                    return "Phương trình vô nghiệm.";
            }

            double x = -B / A;
            return $"Phương trình có nghiệm x = {x:F2}";
        }

        // Phương thức giải phương trình bậc hai: A * x^2 + B * x + C = 0
        public string GiaiBacHai()
        {
            if (A == 0)
            {
                // Trở về dạng bậc nhất: B * x + C = 0
                if (B == 0)
                {
                    if (C == 0)
                        return "Phương trình có vô số nghiệm.";
                    else
                        return "Phương trình vô nghiệm.";
                }
                double x = -C / B;
                return $"Phương trình có nghiệm x = {x:F2}";
            }

            double delta = B * B - 4 * A * C;
            if (delta < 0)
            {
                return "Phương trình vô nghiệm.";
            }
            else if (delta == 0)
            {
                double x = -B / (2 * A);
                return $"Phương trình có nghiệm kép x1 = x2 = {x:F2}";
            }
            else
            {
                double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
                return $"Phương trình có 2 nghiệm phân biệt:\nx1 = {x1:F2}; x2 = {x2:F2}";
            }
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // YÊU CẦU 2: Khi Form load lên, button "Giải" mờ đi
        private void Form1_Load(object sender, EventArgs e)
        {
            btnGiai.Enabled = false;
        }

        // YÊU CẦU 3 & 4: Chuyển đổi giữa PT Bậc nhất và Bậc hai
        private void radBac_CheckedChanged(object sender, EventArgs e)
        {
            if (radBacNhat.Checked)
            {
                lblNhapC.ForeColor = SystemColors.GrayText;
                txtNhapC.Enabled = false;
                txtNhapC.Clear();
            }
            else if (radBacHai.Checked)
            {
                lblNhapC.ForeColor = SystemColors.ControlText;
                txtNhapC.Enabled = true;
            }

            // Xóa kết quả cũ khi đổi chế độ
            txtKetQua.Clear();
            KiemTraDuLieuNhap();
        }

        // Kiểm tra xem đã điền đủ các ô cần thiết để kích hoạt nút Giải chưa
        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieuNhap();
        }

        private void KiemTraDuLieuNhap()
        {
            if (radBacNhat.Checked)
            {
                btnGiai.Enabled = !string.IsNullOrWhiteSpace(txtNhapA.Text) &&
                                 !string.IsNullOrWhiteSpace(txtNhapB.Text);
            }
            else
            {
                btnGiai.Enabled = !string.IsNullOrWhiteSpace(txtNhapA.Text) &&
                                 !string.IsNullOrWhiteSpace(txtNhapB.Text) &&
                                 !string.IsNullOrWhiteSpace(txtNhapC.Text);
            }
        }

        // Khi nhấn nút GIẢI
        private void btnGiai_Click(object sender, EventArgs e)
        {
            // Kiểm tra định dạng số cho ô A
            if (!double.TryParse(txtNhapA.Text.Trim(), out double a))
            {
                MessageBox.Show("Giá trị a phải là một số thực hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapA.Focus();
                txtNhapA.SelectAll();
                return;
            }

            // Kiểm tra định dạng số cho ô B
            if (!double.TryParse(txtNhapB.Text.Trim(), out double b))
            {
                MessageBox.Show("Giá trị b phải là một số thực hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapB.Focus();
                txtNhapB.SelectAll();
                return;
            }

            double c = 0;
            if (radBacHai.Checked)
            {
                // Kiểm tra định dạng số cho ô C
                if (!double.TryParse(txtNhapC.Text.Trim(), out c))
                {
                    MessageBox.Show("Giá trị c phải là một số thực hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNhapC.Focus();
                    txtNhapC.SelectAll();
                    return;
                }
            }

            // Khởi tạo đối tượng PhuongTrinhBacHai và tính nghiệm
            PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b, c);

            if (radBacNhat.Checked)
            {
                txtKetQua.Text = pt.GiaiBacNhat();
            }
            else
            {
                txtKetQua.Text = pt.GiaiBacHai();
            }

            // Sau khi giải xong, Button Giải mờ đi như trong hình mô tả
            btnGiai.Enabled = false;
        }

        // Nút THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xác nhận khi người dùng đóng form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}