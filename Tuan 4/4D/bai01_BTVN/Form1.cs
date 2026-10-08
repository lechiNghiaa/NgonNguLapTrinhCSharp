using System;
using System.Windows.Forms;

namespace bai01_BTVN
{
    public partial class Form1 : Form
    {
        // Biến lưu trữ tổng kết cuối ngày
        private int tongSoLuotKhach = 0;
        private double tongDoanhThu = 0;

        // Biến lưu tiền của khách vừa thanh toán
        private double tienKhachHienTai = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Yêu cầu: Form_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            txtHoTen.Focus();

            // Các nút TongKet, NhapMoi, ThanhToan ban đầu bị mờ
            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = false;
            btnTongKet.Enabled = false;
        }

        // Ràng buộc ô số ngày ở chỉ cho nhập số
        private void txtSoNgayO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Kiểm tra xem đã điền đầy đủ thông tin để kích hoạt nút Thanh toán chưa
        private void DuLieuNhap_Changed(object sender, EventArgs e)
        {
            bool coTen = !string.IsNullOrWhiteSpace(txtHoTen.Text);
            bool coDiaChi = !string.IsNullOrWhiteSpace(txtDiaChi.Text);
            bool coNgayO = int.TryParse(txtSoNgayO.Text.Trim(), out int ngay) && ngay > 0;
            bool coPhong = radPhongDon.Checked || radPhongDoi.Checked || radPhongBa.Checked;

            btnThanhToan.Enabled = coTen && coDiaChi && coNgayO && coPhong;
        }

        // Yêu cầu: btnThanhToan
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoNgayO.Text.Trim(), out int soNgay) || soNgay <= 0)
            {
                MessageBox.Show("Số ngày ở phải là một số nguyên dương (> 0)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNgayO.Focus();
                return;
            }

            // 1. Tính giá phòng theo ngày
            double giaPhongNgay = 0;
            if (radPhongDon.Checked) giaPhongNgay = 300000;
            else if (radPhongDoi.Checked) giaPhongNgay = 350000;
            else if (radPhongBa.Checked) giaPhongNgay = 400000;

            double tienPhong = giaPhongNgay * soNgay;

            // 2. Tính tiện nghi (10.000đ mỗi loại)
            double tienTienNghi = 0;
            if (chkTivi.Checked) tienTienNghi += 10000;
            if (chkInternet.Checked) tienTienNghi += 10000;
            if (chkMayNuocNong.Checked) tienTienNghi += 10000;

            // 3. Tính dịch vụ (Karaoke: 50.000đ; Ăn sáng: 15.000đ/ngày)
            double tienDichVu = 0;
            if (chkKaraoke.Checked) tienDichVu += 50000;
            if (chkAnSang.Checked) tienDichVu += 15000 * soNgay;

            // Tổng thành tiền
            tienKhachHienTai = tienPhong + tienTienNghi + tienDichVu;
            txtThanhTien.Text = tienKhachHienTai.ToString("0") + " VNĐ";

            // Lưu lại thông tin thống kê
            tongSoLuotKhach++;
            tongDoanhThu += tienKhachHienTai;

            // Bật sáng các nút NhapMoi và TongKet
            btnNhapMoi.Enabled = true;
            btnTongKet.Enabled = true;
            btnThanhToan.Enabled = false;
        }

        // Yêu cầu: btnNhapMoi (khởi tạo lại trạng thái ban đầu để nhập khách mới)
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoNgayO.Clear();
            txtThanhTien.Clear();

            radPhongDon.Checked = false;
            radPhongDoi.Checked = false;
            radPhongBa.Checked = false;

            chkTivi.Checked = false;
            chkInternet.Checked = false;
            chkMayNuocNong.Checked = false;

            chkKaraoke.Checked = false;
            chkAnSang.Checked = false;

            btnNhapMoi.Enabled = false;
            btnThanhToan.Enabled = false;

            txtHoTen.Focus();
        }

        // Yêu cầu: btnTongKet
        private void btnTongKet_Click(object sender, EventArgs e)
        {
            txtSoLuotNguoi.Text = tongSoLuotKhach.ToString();
            txtTongSoTien.Text = tongDoanhThu.ToString("N0") + " VNĐ";

            // Khởi tạo lại giá trị sau khi tổng kết
            tongSoLuotKhach = 0;
            tongDoanhThu = 0;

            // Nút TongKet bị mờ
            btnTongKet.Enabled = false;
        }

        // Yêu cầu: btnThoat_Click và xác nhận đóng Form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình hay không?",
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