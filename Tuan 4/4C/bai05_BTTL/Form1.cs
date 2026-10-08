using System;
using System.Windows.Forms;

namespace bai05_BTTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Hàm giải thuật đọc số từ 1 đến 999

        private string DocSo(int n)
        {
            string[] chuSo = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

            // Trường hợp số có 1 chữ số (1 - 9)
            if (n < 10)
            {
                return chuSo[n];
            }

            // Trường hợp số có 2 chữ số (10 - 99)
            if (n < 100)
            {
                int chuc = n / 10;
                int donVi = n % 10;
                string kq = "";

                if (chuc == 1)
                {
                    kq = "Mười";
                }
                else
                {
                    kq = chuSo[chuc] + " Mươi";
                }

                if (donVi == 1)
                {
                    kq += (chuc == 1) ? " Một" : " Mốt";
                }
                else if (donVi == 5)
                {
                    kq += " Lăm";
                }
                else if (donVi > 0)
                {
                    kq += " " + chuSo[donVi];
                }

                return kq;
            }

            // Trường hợp số có 3 chữ số (100 - 999)
            int tram = n / 100;
            int chucVaDv = n % 100;
            int hangChuc = chucVaDv / 10;
            int hangDonVi = chucVaDv % 10;

            string ketQua = chuSo[tram] + " Trăm";

            if (hangChuc == 0 && hangDonVi > 0)
            {
                ketQua += " Lẻ " + chuSo[hangDonVi];
            }
            else if (hangChuc > 0)
            {
                if (hangChuc == 1)
                {
                    ketQua += " Mười";
                }
                else
                {
                    ketQua += " " + chuSo[hangChuc] + " Mươi";
                }

                if (hangDonVi == 1)
                {
                    ketQua += (hangChuc == 1) ? " Một" : " Mốt";
                }
                else if (hangDonVi == 5)
                {
                    ketQua += " Lăm";
                }
                else if (hangDonVi > 0)
                {
                    ketQua += " " + chuSo[hangDonVi];
                }
            }

            return ketQua;
        }

        #endregion

        // Xử lý đọc số
        private void XuLyDocSo()
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
                MessageBox.Show("Dữ liệu nhập vào phải là một số nguyên!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapSo.SelectAll();
                txtNhapSo.Focus();
                return;
            }

            // Kiểm tra miền giá trị từ 1 đến 999
            if (so < 1 || so > 999)
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên trong khoảng từ 1 đến 999!", "Ngoài phạm vi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.SelectAll();
                txtNhapSo.Focus();
                return;
            }

            // Đọc số và hiển thị kết quả
            txtKetQua.Text = DocSo(so);
        }

        // Yêu cầu 1 & 2: Button Thực hiện
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            XuLyDocSo();
        }

        // Hỗ trợ nhấn phím Enter tại ô nhập số
        private void txtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                XuLyDocSo();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Yêu cầu 3: Button Xóa trả form lại trạng thái ban đầu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapSo.Clear();
            txtKetQua.Clear();
            txtNhapSo.Focus();
        }

        // Yêu cầu 4: Button Thoát xác nhận và đóng form
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
                e.Cancel = true;
            }
        }
    }
}