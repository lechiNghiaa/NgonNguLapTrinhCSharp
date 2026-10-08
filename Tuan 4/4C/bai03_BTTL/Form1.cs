using System;
using System.Windows.Forms;

namespace bai03_BTTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Các hàm thuật toán tính UCLN & BCNN

        // Thuật toán Euclid tìm UCLN của 2 số nguyên dương
        private long TimUCLN(long a, long b)
        {
            while (b != 0)
            {
                long temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        // BCNN(a, b) = (|a * b|) / UCLN(a, b)
        private long TimBCNN(long a, long b, long ucln)
        {
            return (a * b) / ucln;
        }

        #endregion

        // Nút Thực Hiện
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị cho số a!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị cho số b!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                return;
            }

            // 2. Kiểm tra định dạng số nguyên
            if (!long.TryParse(txtA.Text.Trim(), out long a))
            {
                MessageBox.Show("Giá trị a phải là một số nguyên hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
                txtA.SelectAll();
                return;
            }

            if (!long.TryParse(txtB.Text.Trim(), out long b))
            {
                MessageBox.Show("Giá trị b phải là một số nguyên hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus();
                txtB.SelectAll();
                return;
            }

            // 3. Kiểm tra số nguyên dương (> 0)
            if (a <= 0)
            {
                MessageBox.Show("Số a phải là số nguyên dương (> 0)!", "Lỗi giá trị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                txtA.SelectAll();
                return;
            }

            if (b <= 0)
            {
                MessageBox.Show("Số b phải là số nguyên dương (> 0)!", "Lỗi giá trị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                txtB.SelectAll();
                return;
            }

            // 4. Tính toán và hiển thị kết quả
            long ucln = TimUCLN(a, b);
            long bcnn = TimBCNN(a, b, ucln);

            txtUCLN.Text = ucln.ToString();
            txtBCNN.Text = bcnn.ToString();
        }

        // Nút Tiếp Tục (Xóa trắng dữ liệu để nhập lại từ đầu)
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();
            txtA.Focus();
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xác nhận khi đóng Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void lblUCLN_Click(object sender, EventArgs e)
        {

        }
    }
}