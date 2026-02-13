using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangXeMayDien.Data;

namespace QuanLyCuaHangXeMayDien.Forms
{
    public partial class frmHangXe : Form
    {
        QLXMDDbContext context = new QLXMDDbContext();
        bool xuLyThem = false;
        int id;

        public frmHangXe()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenHangXe.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmHangXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            var nsx = context.NhaSanXuats.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nsx;

            txtTenHangXe.DataBindings.Clear();
            txtTenHangXe.DataBindings.Add("Text", bindingSource, "TenNhaSanXuat", false, DataSourceUpdateMode.Never);

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHangXe.Clear();
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
            if (string.IsNullOrWhiteSpace(txtTenHangXe.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hãng xe?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    var nsx = new NhaSanXuat();
                    nsx.TenNhaSanXuat = txtTenHangXe.Text.Trim();

                    // Ép EF Core hiểu đây là đối tượng hoàn toàn mới, bỏ qua tracking cũ
                    context.Entry(nsx).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                    context.SaveChanges();

                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Sửa chữa (Giả sử bạn có biến luu ID đang chọn, ví dụ: idDangChon)
                    // Thay "idDangChon" bằng tên biến hoặc cách bạn lấy ID thực tế đang chọn trên DataGridView
                    int id = int.Parse(dataGridView.CurrentRow.Cells["ID"].Value.ToString());

                    var nsx = context.NhaSanXuats.Find(id);
                    if (nsx != null)
                    {
                        nsx.TenNhaSanXuat = txtTenHangXe.Text.Trim();
                        context.SaveChanges();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Gọi lại hàm load dữ liệu lên DataGridView ở đây (ví dụ: LoadData();)

                // Reset lại trạng thái các nút
                xuLyThem = false;
                // Vô hiệu hóa/Kích hoạt lại các nút Thêm, Sửa, Xóa, Lưu... theo thiết kế của bạn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hãng xe này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["ID"].Value != null)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    var nsx = context.NhaSanXuats.Find(id);

                    if (nsx != null)
                    {
                        context.NhaSanXuats.Remove(nsx);
                        context.SaveChanges();
                        frmHangXe_Load(sender, e);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangXe_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}