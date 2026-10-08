using System;
using System.Windows.Forms;

namespace bai01_BTVN
{
    public partial class Form1 : Form
    {
        private double soThuNhat = 0;
        private string phepTinh = "";
        private bool dangNhapSoMoi = true;

        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện click cho các nút số từ 0 đến 9
        private void btnSo_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (dangNhapSoMoi || txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
                dangNhapSoMoi = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        // Sự kiện click cho các phép toán: +, -, *, /
        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (double.TryParse(txtDisplay.Text, out double giaTri))
            {
                soThuNhat = giaTri;
                phepTinh = btn.Text;
                dangNhapSoMoi = true;
            }
        }

        // Sự kiện click nút bằng (=)
        private void btnBang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phepTinh)) return;

            if (double.TryParse(txtDisplay.Text, out double soThuHai))
            {
                double ketQua = 0;

                switch (phepTinh)
                {
                    case "+":
                        ketQua = soThuNhat + soThuHai;
                        break;
                    case "-":
                        ketQua = soThuNhat - soThuHai;
                        break;
                    case "*":
                        ketQua = soThuNhat * soThuHai;
                        break;
                    case "/":
                        if (soThuHai == 0)
                        {
                            MessageBox.Show("Không thể chia cho số 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnC_Click(null, null);
                            return;
                        }
                        ketQua = soThuNhat / soThuHai;
                        break;
                }

                txtDisplay.Text = ketQua.ToString();
                soThuNhat = ketQua;
                phepTinh = "";
                dangNhapSoMoi = true;
            }
        }

        // Nút C (Clear): Xóa và khởi tạo lại trạng thái ban đầu
        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            soThuNhat = 0;
            phepTinh = "";
            dangNhapSoMoi = true;
        }
    }
}