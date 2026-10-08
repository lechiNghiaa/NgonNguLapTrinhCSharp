using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai01_BTNC
{
    public partial class Form1 : Form
    {
        // Mảng chứa 15 nút ghế
        private Button[] danhSachGhe;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Gom 15 nút ghế vào mảng để quản lý
            danhSachGhe = new Button[]
            {
                btn1, btn2, btn3, btn4, btn5,
                btn6, btn7, btn8, btn9, btn10,
                btn11, btn12, btn13, btn14, btn15
            };

            // Gán sự kiện Click chung và màu khởi tạo cho từng ghế
            foreach (Button btn in danhSachGhe)
            {
                btn.BackColor = Color.White;
                btn.Click += Ghe_Click;
            }

            txtThanhTien.Text = "0";
        }

        // Xử lý khi click vào từng ghế
        private void Ghe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // 1. Nếu ghế đã bán (màu vàng) -> cảnh báo MessageBox
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show($"Vé ở vị trí số {btn.Text} đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Nếu ghế đang chọn (màu xanh) -> bỏ chọn, chuyển lại màu trắng
            if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
            // 3. Nếu ghế chưa bán (màu trắng) -> chọn ghế, chuyển sang màu xanh
            else if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White;
            }
        }

        // Tính giá tiền của ghế dựa vào số thứ tự
        private int LayGiaVe(int soGhe)
        {
            // Hàng 1 (Lô A: 1 - 5) : 1000/vé
            if (soGhe >= 1 && soGhe <= 5) return 1000;

            // Hàng 2 (Lô B: 6 - 10): 1500/vé
            if (soGhe >= 6 && soGhe <= 10) return 1500;

            // Hàng 3 (Lô C: 11 - 15): 2000/vé
            if (soGhe >= 11 && soGhe <= 15) return 2000;

            return 0;
        }

        // Nút CHỌN: Thanh toán vé đang chọn
        private void btnChon_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            int soVeDaChon = 0;

            foreach (Button btn in danhSachGhe)
            {
                // Kiểm tra các ghế đang được chọn (màu xanh)
                if (btn.BackColor == Color.Blue)
                {
                    int soGhe = int.Parse(btn.Text);
                    tongTien += LayGiaVe(soGhe);

                    // Chuyển sang trạng thái đã bán (màu vàng)
                    btn.BackColor = Color.Yellow;
                    btn.ForeColor = Color.Black;
                    soVeDaChon++;
                }
            }

            if (soVeDaChon == 0)
            {
                MessageBox.Show("Bạn chưa chọn vé nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xuất tổng số tiền ra ô Thành Tiền
            txtThanhTien.Text = tongTien.ToString("N0") + " VND";
        }

        // Nút HỦY BỎ: Hủy các ghế đang chọn (màu xanh -> màu trắng)
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            foreach (Button btn in danhSachGhe)
            {
                if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }

            // Trả giá trị thành tiền về 0
            txtThanhTien.Text = "0";
        }

        // Nút KẾT THÚC: Xác nhận và đóng form
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Bạn có chắc chắn muốn kết thúc chương trình không?",
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