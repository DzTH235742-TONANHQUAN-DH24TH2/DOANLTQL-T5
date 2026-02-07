using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangXeMayDien.Data;

namespace QuanLyCuaHangXeMayDien.Forms
{
    public partial class frmKhachHang : Form
    {
        QLXMDDbContext context = new QLXMDDbContext();
        bool xuLyThem = false;
        int id;

        public frmKhachHang()
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
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            var kh = context.KhachHangs.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtHoVaTen.DataBindings.Clear();
            // Đã sửa thành "HoTen" khớp với CSDL của bạn
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
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
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    var kh = new KhachHang();
                    kh.HoTen = txtHoVaTen.Text; // Đã sửa thành HoTen
                    kh.DienThoai = txtDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    context.KhachHangs.Add(kh);
                    context.SaveChanges();
                }
                else
                {
                    var kh = context.KhachHangs.Find(id);
                    if (kh != null)
                    {
                        kh.HoTen = txtHoVaTen.Text; // Đã sửa thành HoTen
                        kh.DienThoai = txtDienThoai.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        context.KhachHangs.Update(kh);
                        context.SaveChanges();
                    }
                }
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["ID"].Value != null)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    var kh = context.KhachHangs.Find(id);

                    if (kh != null)
                    {
                        context.KhachHangs.Remove(kh);
                        context.SaveChanges();
                        frmKhachHang_Load(sender, e);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}