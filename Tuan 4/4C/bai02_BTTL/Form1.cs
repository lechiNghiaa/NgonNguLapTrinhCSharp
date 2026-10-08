using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bai02_BTTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Yêu cầu 1: Kiểm tra định dạng email sau khi rời khỏi ô txtEmail
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (!string.IsNullOrEmpty(email))
            {
                // Biểu thức chính quy kiểm tra dạng chuoi@chuoi.chuoi
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(email, pattern))
                {
                    MessageBox.Show("Địa chỉ email không đúng định dạng!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                }
            }
        }

        // Hàm xử lý chung cho nút Đăng ký và phím Enter
        private void ThucHienDangKy()
        {
            string tenDN = txtTenDangNhap.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string xacNhanMK = txtXacNhanMatKhau.Text;

            // Yêu cầu 2: Bắt buộc nhập dữ liệu trên những textbox có (*)
            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin có dấu (*)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra khớp mật khẩu xác nhận
            if (!string.IsNullOrEmpty(xacNhanMK) && matKhau != xacNhanMK)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhanMatKhau.Focus();
                return;
            }

            // Yêu cầu 3: Hiển thị thông tin tất cả các textbox lên MessageBox
            string thongTin = $"Tên đăng nhập: {tenDN}\n" +
                              $"Email: {email}\n" +
                              $"Mật khẩu: {matKhau}\n" +
                              $"Xác nhận mật khẩu: {xacNhanMK}";

            MessageBox.Show(thongTin, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Yêu cầu 3a: Khi click vào button Đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            ThucHienDangKy();
        }

        // Yêu cầu 3b: Khi nhấn Enter sau khi nhập xong tại ô Xác nhận mật khẩu
        private void txtXacNhanMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThucHienDangKy();
                e.Handled = true;
                e.SuppressKeyPress = true; // Chặn âm báo chuông mặc định
            }
        }

        // Yêu cầu 4: Hỏi xác nhận trước khi đóng Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đóng form không?",
                "Xác nhận đóng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy đóng Form
            }
        }
    }
}