using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai04_BTTL
{
    public partial class Form1 : Form
    {
        // Danh sách lưu trữ các số nguyên đã nhập vào dãy
        private List<int> danhSachSo = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        // Hàm xử lý nhập số vào danh sách
        private void XuLyNhapSo()
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtNhapSo.Text))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Focus();
                return;
            }

            // Kiểm tra định dạng số nguyên
            if (!int.TryParse(txtNhapSo.Text.Trim(), out int so))
            {
                MessageBox.Show("Giá trị nhập vào phải là số nguyên hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapSo.SelectAll();
                txtNhapSo.Focus();
                return;
            }

            // Thêm vào danh sách dãy số
            danhSachSo.Add(so);

            // Xuất ra textbox 'Dãy vừa nhập'
            if (string.IsNullOrEmpty(txtDayVuaNhap.Text))
            {
                txtDayVuaNhap.Text = so.ToString();
            }
            else
            {
                txtDayVuaNhap.Text += " " + so.ToString();
            }

            // Xóa ô nhập số và đưa con trỏ về để nhập số tiếp theo
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        // Yêu cầu 1: Nhấn button Nhập
        private void btnNhap_Click(object sender, EventArgs e)
        {
            XuLyNhapSo();
        }

        // Hỗ trợ nhấn Enter ngay tại ô txtNhapSo
        private void txtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                XuLyNhapSo();
                e.Handled = true;
                e.SuppressKeyPress = true; // Ngăn tiếng bip mặc định
            }
        }

        // Yêu cầu 2 & 3: Bổ sung button Tính tổng, tính tổng các phần tử, tổng chẵn, tổng lẻ
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (danhSachSo.Count == 0)
            {
                MessageBox.Show("Dãy số hiện đang trống! Hãy nhập ít nhất một số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Focus();
                return;
            }

            long tongPhanTu = 0;
            long tongChan = 0;
            long tongLe = 0;

            foreach (int x in danhSachSo)
            {
                tongPhanTu += x;
                if (x % 2 == 0)
                {
                    tongChan += x;
                }
                else
                {
                    tongLe += x;
                }
            }

            txtTongPhanTu.Text = tongPhanTu.ToString();
            txtTongChan.Text = tongChan.ToString();
            txtTongLe.Text = tongLe.ToString();
        }

        // Yêu cầu 4: Button Tiếp tục trả lại trạng thái ban đầu của form
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            danhSachSo.Clear();
            txtNhapSo.Clear();
            txtDayVuaNhap.Clear();
            txtTongPhanTu.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtNhapSo.Focus();
        }

        // Yêu cầu 5: Button Thoát xác nhận và đóng form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                e.Cancel = true; // Hủy thao tác đóng form
            }
        }
    }
}