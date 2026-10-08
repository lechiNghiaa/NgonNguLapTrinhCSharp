using System;
using System.Windows.Forms;

namespace bai01_BTNC
{
    public partial class Form1 : Form
    {
        // Biến lưu trữ cộng dồn thống kê
        private int tongSoKhach = 0;
        private double tongTienDoanhThu = 0;

        // Biến lưu trữ tiền của nhóm khách hiện tại đang tính
        private double tienHienTai = 0;
        private int soKhachHienTai = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Yêu cầu: Form_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            txtTenKhachHang.Focus();

            // Các button ban đầu bị mờ
            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;

            txtTongKhachHang.Text = "0";
            txtTongTienThanhToan.Text = "0 VNĐ";
        }

        // Yêu cầu: Textbox số khách hàng chỉ cho nhập số
        private void txtSoKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Kiểm tra xem khách đã chọn ít nhất 1 loại đồ uống hoặc thức ăn chưa
        private bool CoMonDuocChon()
        {
            bool coNuoc = radCafeDen.Checked || radCafeDa.Checked || radCafeSua.Checked ||
                          radCafeSuaDa.Checked || radCafeKem.Checked;

            bool coThucAn = chkBanhMyTrung.Checked || chkBanhMyCa.Checked ||
                            chkMyTomTrung.Checked || chkMyXaoBo.Checked || chkMyCay.Checked;

            return coNuoc || coThucAn;
        }

        // Kiểm tra điều kiện để bật nút Tính Tiền khi người dùng nhập thông tin
        private void DuLieu_ThayDoi(object sender, EventArgs e)
        {
            bool coTen = !string.IsNullOrWhiteSpace(txtTenKhachHang.Text);
            bool coSoKhach = !string.IsNullOrWhiteSpace(txtSoKhachHang.Text);
            bool coMon = CoMonDuocChon();

            // Khi nhập đầy đủ thông tin thì btnTinhTien có tác dụng
            btnTinhTien.Enabled = coTen && coSoKhach && coMon;
        }

        // Yêu cầu: btnTinhTien_Click
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoKhachHang.Text.Trim(), out soKhachHienTai) || soKhachHienTai <= 0)
            {
                MessageBox.Show("Số khách hàng phải là một số nguyên dương (> 0)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoKhachHang.Focus();
                return;
            }

            double tongTienMon = 0;

            // Giá thức uống
            if (radCafeDen.Checked) tongTienMon += 20000;
            else if (radCafeDa.Checked) tongTienMon += 25000;
            else if (radCafeSua.Checked) tongTienMon += 25000;
            else if (radCafeSuaDa.Checked) tongTienMon += 30000;
            else if (radCafeKem.Checked) tongTienMon += 35000;

            // Giá thức ăn
            if (chkBanhMyTrung.Checked) tongTienMon += 15000;
            if (chkBanhMyCa.Checked) tongTienMon += 15000;
            if (chkMyTomTrung.Checked) tongTienMon += 20000;
            if (chkMyXaoBo.Checked) tongTienMon += 30000;
            if (chkMyCay.Checked) tongTienMon += 50000;

            // Kiểm tra giảm giá sinh viên (giảm 20%)
            double giamGia = 0;
            if (chkSinhVien.Checked)
            {
                giamGia = tongTienMon * 0.2;
            }

            tienHienTai = tongTienMon - giamGia;

            string thongBao = $"Khách hàng: {txtTenKhachHang.Text.Trim()}\n" +
                              $"Số khách: {soKhachHienTai}\n" +
                              $"Tổng tiền gốc: {tongTienMon:N0} VNĐ\n" +
                              $"Giảm giá sinh viên (20%): {giamGia:N0} VNĐ\n" +
                              $"------------------------------------\n" +
                              $"Số tiền cần thanh toán: {tienHienTai:N0} VNĐ";

            MessageBox.Show(thongBao, "Thông tin thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Bật sáng các nút theo yêu cầu
            btnNhapLai.Enabled = true;
            btnThanhToan.Enabled = true;
        }

        // Yêu cầu: btnNhapLai_Click
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            XoaTrangThongTinKhach();
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;
            btnTinhTien.Enabled = false;
        }

        // Hàm xóa dữ liệu nhập của khách hiện tại
        private void XoaTrangThongTinKhach()
        {
            txtTenKhachHang.Clear();
            txtSoKhachHang.Clear();
            chkSinhVien.Checked = false;

            radCafeDen.Checked = false;
            radCafeDa.Checked = false;
            radCafeSua.Checked = false;
            radCafeSuaDa.Checked = false;
            radCafeKem.Checked = false;

            chkBanhMyTrung.Checked = false;
            chkBanhMyCa.Checked = false;
            chkMyTomTrung.Checked = false;
            chkMyXaoBo.Checked = false;
            chkMyCay.Checked = false;

            tienHienTai = 0;
            soKhachHienTai = 0;
            txtTenKhachHang.Focus();
        }

        // Yêu cầu: btnThanhToan_Click
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Cộng dồn vào biến thống kê
            tongSoKhach += soKhachHienTai;
            tongTienDoanhThu += tienHienTai;

            // Xuất ra ô tổng
            txtTongKhachHang.Text = tongSoKhach.ToString();
            txtTongTienThanhToan.Text = tongTienDoanhThu.ToString("N0") + " VNĐ";

            // Sẵn sàng cho việc nhập nhóm khách hàng mới
            XoaTrangThongTinKhach();

            // Mờ nút thanh toán và tính tiền
            btnThanhToan.Enabled = false;
            btnNhapLai.Enabled = false;
            btnTinhTien.Enabled = false;
        }

        // Yêu cầu: btnThoat_Click và xác nhận FormClosing
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