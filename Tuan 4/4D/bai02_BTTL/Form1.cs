using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bai02_BTTL
{
    // ==========================================
    // YÊU CẦU 1: CLASS QUẢN LÝ MẢNG MỘT CHIỀU
    // ==========================================
    public class MangSoNguyen
    {
        private List<int> a;

        public MangSoNguyen()
        {
            a = new List<int>();
        }

        public MangSoNguyen(IEnumerable<int> collection)
        {
            a = new List<int>(collection);
        }

        public int SoPhanTu => a.Count;

        public List<int> DanhSach => a;

        // Phương thức xuất chuỗi mảng
        public string XuatChuoi()
        {
            return string.Join(" ", a);
        }

        // 1. Sắp xếp
        public void SapXepTang()
        {
            a.Sort();
        }

        public void SapXepGiam()
        {
            a.Sort();
            a.Reverse();
        }

        // 2. Tìm kiếm
        public int TimViTriCuaGiaTri(int giaTri)
        {
            return a.IndexOf(giaTri); // Trả về index đầu tiên tìm thấy hoặc -1
        }

        public int LayGiaTriTaiViTri(int viTri)
        {
            if (viTri >= 0 && viTri < a.Count)
                return a[viTri];
            throw new IndexOutOfRangeException("Vị trí nằm ngoài phạm vi mảng!");
        }

        // 3. Xóa
        public bool XoaTheoGiaTri(int giaTri)
        {
            return a.Remove(giaTri); // Xóa phần tử đầu tiên có giá trị đó
        }

        public void XoaTaiViTri(int viTri)
        {
            if (viTri >= 0 && viTri < a.Count)
                a.RemoveAt(viTri);
            else
                throw new IndexOutOfRangeException("Vị trí cần xóa không hợp lệ!");
        }

        // 4. Thêm
        public void ThemTaiViTri(int viTri, int giaTri)
        {
            if (viTri >= 0 && viTri <= a.Count)
                a.Insert(viTri, giaTri);
            else
                throw new IndexOutOfRangeException("Vị trí chèn không hợp lệ!");
        }

        // 5. Tính tổng
        public long TinhTongMang() => a.Sum(x => (long)x);

        public long TinhTongChan() => a.Where(x => x % 2 == 0).Sum(x => (long)x);

        public long TinhTongLe() => a.Where(x => x % 2 != 0).Sum(x => (long)x);

        // 6. Max - Min
        public int TimMax() => a.Max();

        public int TimMin() => a.Min();

        // 7. Thay thế
        public bool ThayTheTheoGiaTri(int giaTriCu, int giaTriMoi)
        {
            int index = a.IndexOf(giaTriCu);
            if (index != -1)
            {
                a[index] = giaTriMoi;
                return true;
            }
            return false;
        }

        public void ThayTheTaiViTri(int viTri, int giaTriMoi)
        {
            if (viTri >= 0 && viTri < a.Count)
                a[viTri] = giaTriMoi;
            else
                throw new IndexOutOfRangeException("Vị trí cần thay thế không hợp lệ!");
        }
    }

    public partial class Form1 : Form
    {
        private MangSoNguyen mang = null;

        public Form1()
        {
            InitializeComponent();
        }

        // Hàm đọc mảng từ ô Nhập mảng
        private bool DocDuLieuMang()
        {
            string input = txtNhapMang.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập các phần tử của mảng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapMang.Focus();
                return false;
            }

            // Tách các số theo dấu cách hoặc dấu phẩy
            string[] tokens = input.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> danhSach = new List<int>();

            foreach (string t in tokens)
            {
                if (int.TryParse(t, out int val))
                {
                    danhSach.Add(val);
                }
                else
                {
                    MessageBox.Show($"Phần tử '{t}' không phải là một số nguyên hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNhapMang.Focus();
                    txtNhapMang.SelectAll();
                    return false;
                }
            }

            if (danhSach.Count == 0)
            {
                MessageBox.Show("Mảng chưa có phần tử nào hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            mang = new MangSoNguyen(danhSach);
            return true;
        }

        // Nút THỰC HIỆN: Sắp xếp, Tìm kiếm, Xóa, Thêm, Thay thế
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!DocDuLieuMang()) return;

            // 1. Xử lý Sắp xếp
            if (radTang.Checked)
            {
                mang.SapXepTang();
            }
            else if (radGiam.Checked)
            {
                mang.SapXepGiam();
            }

            // 2. Xử lý Tìm kiếm
            if (radTimGiaTri.Checked)
            {
                if (int.TryParse(txtGiaTriTim.Text.Trim(), out int val))
                {
                    int index = mang.TimViTriCuaGiaTri(val);
                    txtKetQuaTimKiem.Text = (index != -1) ? index.ToString() : "Không thấy";
                }
                else
                {
                    MessageBox.Show("Giá trị cần tìm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (radTimViTri.Checked)
            {
                if (int.TryParse(txtViTriTim.Text.Trim(), out int viTri))
                {
                    try
                    {
                        txtKetQuaTimKiem.Text = mang.LayGiaTriTaiViTri(viTri).ToString();
                    }
                    catch
                    {
                        MessageBox.Show($"Vị trí tìm kiếm phải nằm trong khoảng [0, {mang.SoPhanTu - 1}]!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vị trí cần tìm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // 3. Xử lý Xóa (Yêu cầu mảng sắp xếp tăng)
            if (radXoaGiaTri.Checked)
            {
                mang.SapXepTang();
                radTang.Checked = true;
                if (int.TryParse(txtGiaTriXoa.Text.Trim(), out int val))
                {
                    if (!mang.XoaTheoGiaTri(val))
                        MessageBox.Show($"Không tìm thấy giá trị {val} để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (radXoaViTri.Checked)
            {
                mang.SapXepTang();
                radTang.Checked = true;
                if (int.TryParse(txtViTriXoa.Text.Trim(), out int viTri))
                {
                    try
                    {
                        mang.XoaTaiViTri(viTri);
                    }
                    catch
                    {
                        MessageBox.Show($"Vị trí cần xóa phải từ 0 đến {mang.SoPhanTu - 1}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            // 4. Xử lý Thêm (Yêu cầu mảng sắp xếp tăng)
            if (radThemGiaTri.Checked)
            {
                mang.SapXepTang();
                radTang.Checked = true;
                if (int.TryParse(txtGiaTriThem.Text.Trim(), out int giaTriThem) &&
                    int.TryParse(txtViTriThem.Text.Trim(), out int viTriThem))
                {
                    try
                    {
                        mang.ThemTaiViTri(viTriThem, giaTriThem);
                    }
                    catch
                    {
                        MessageBox.Show($"Vị trí thêm phải nằm trong khoảng [0, {mang.SoPhanTu}]!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            // 5. Xử lý Thay thế
            if (radGiaTriThayThe.Checked)
            {
                if (int.TryParse(txtGiaTriThayThe.Text.Trim(), out int cu) &&
                    int.TryParse(txtSoThayThe.Text.Trim(), out int moi))
                {
                    if (!mang.ThayTheTheoGiaTri(cu, moi))
                    {
                        mang.ThayTheTheoGiaTri(cu, moi);
                    }
                }
            }
            else if (radViTriThayThe.Checked)
            {
                if (int.TryParse(txtViTriThayThe.Text.Trim(), out int viTri) &&
                    int.TryParse(txtSoThayThe.Text.Trim(), out int moi))
                {
                    try
                    {
                        mang.ThayTheTaiViTri(viTri, moi);
                    }
                    catch
                    {
                        MessageBox.Show($"Vị trí cần thay thế phải từ 0 đến {mang.SoPhanTu - 1}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            // Cập nhật kết quả mảng lên giao diện
            txtKetQuaMang.Text = mang.XuatChuoi();
        }

        // Nút TÍNH TỔNG
        private void btnTong_Click(object sender, EventArgs e)
        {
            if (mang == null && !DocDuLieuMang()) return;

            txtTongMang.Text = mang.TinhTongMang().ToString();
            txtTongChan.Text = mang.TinhTongChan().ToString();
            txtTongLe.Text = mang.TinhTongLe().ToString();
        }

        // Nút TÌM MAX - MIN
        private void btnTimMaxMin_Click(object sender, EventArgs e)
        {
            if (mang == null && !DocDuLieuMang()) return;

            txtGiaTriLonNhat.Text = mang.TimMax().ToString();
            txtGiaTriNhoNhat.Text = mang.TimMin().ToString();
        }

        // Nút RESET
        private void btnReset_Click(object sender, EventArgs e)
        {
            mang = null;
            txtNhapMang.Clear();
            txtKetQuaMang.Clear();
            txtGiaTriTim.Clear();
            txtViTriTim.Clear();
            txtKetQuaTimKiem.Clear();
            txtGiaTriXoa.Clear();
            txtViTriXoa.Clear();
            txtGiaTriThem.Clear();
            txtViTriThem.Clear();
            txtTongMang.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtGiaTriLonNhat.Clear();
            txtGiaTriNhoNhat.Clear();
            txtGiaTriThayThe.Clear();
            txtViTriThayThe.Clear();
            txtSoThayThe.Clear();
            radTang.Checked = true;
            radTimGiaTri.Checked = false;
            radTimViTri.Checked = false;
            radXoaGiaTri.Checked = false;
            radXoaViTri.Checked = false;
            radThemGiaTri.Checked = false;
            radGiaTriThayThe.Checked = false;
            radViTriThayThe.Checked = false;
            txtNhapMang.Focus();
        }

        // Nút THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // YÊU CẦU: ĐÓNG FORM PHẢI CÓ XÁC NHẬN TỪ NGƯỜI DÙNG
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