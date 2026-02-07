using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangXeMayDien.Data;
using BCrypt.Net;

namespace QuanLyCuaHangXeMayDien.Forms
{
    public partial class frmNhanVien : Form
    {
        QLXMDDbContext context = new QLXMDDbContext();
        bool xuLyThem = false;
        int id;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            var nv = context.NhanViens.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.SelectedIndex = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["ID"].Value != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text)) return;
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text)) return;

            if (xuLyThem)
            {
                if (string.IsNullOrWhiteSpace(txtMatKhau.Text)) return;

                var nv = new NhanVien();
                nv.HoTen = txtHoVaTen.Text;
                nv.DienThoai = txtDienThoai.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;

                context.NhanViens.Add(nv);
                context.SaveChanges();
            }
            else
            {
                var nv = context.NhanViens.Find(id);
                if (nv != null)
                {
                    nv.HoTen = txtHoVaTen.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;

                    if (string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        context.Entry(nv).Property(x => x.MatKhau).IsModified = false;
                    }
                    else
                    {
                        nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                    }

                    context.NhanViens.Update(nv);
                    context.SaveChanges();
                }
            }
            frmNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["ID"].Value != null)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    var nv = context.NhanViens.Find(id);

                    if (nv != null)
                    {
                        context.NhanViens.Remove(nv);
                        context.SaveChanges();
                        frmNhanVien_Load(sender, e);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}