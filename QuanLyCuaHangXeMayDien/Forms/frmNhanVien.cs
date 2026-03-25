using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangXeMayDien.Data;
using BCrypt.Net;
using ClosedXML.Excel;
using System.Data;

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

            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["lD"].Value != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["lD"].Value.ToString());
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
                if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells[0].Value != null)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
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

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu nhân viên từ Excel";
            openFileDialog.Filter = "Tập tin Excel (*.xlsx)|*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Columns.Add(cell.Value.ToString());
                                }
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                    }

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow r in table.Rows)
                        {
                            NhanVien nv = new NhanVien();
                            nv.HoTen = r["HoTen"].ToString();
                            nv.TenDangNhap = r["TenDangNhap"].ToString();
                            nv.MatKhau = r["MatKhau"].ToString();
                            // Nếu bảng Nhân viên của bạn có cột QuyenHan (kiểu int) thì bỏ comment dòng dưới và sửa lại cho đúng
                            // nv.QuyenHan = Convert.ToInt32(r["QuyenHan"]); 

                            context.NhanVien.Add(nv);
                        }
                        context.SaveChanges();
                        MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " nhân viên.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmNhanVien_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: Kiểm tra lại tên cột trong file Excel xem đã đúng chuẩn chưa (HoTen, TenDangNhap, MatKhau).\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu nhân viên ra Excel";
            saveFileDialog.Filter = "Tập tin Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("HoTen", typeof(string)),
                new DataColumn("TenDangNhap", typeof(string)),
                new DataColumn("MatKhau", typeof(string))
            });

                    var danhSachNV = context.NhanVien.ToList();
                    foreach (var nv in danhSachNV)
                    {
                        table.Rows.Add(nv.ID, nv.HoTen, nv.TenDangNhap, nv.MatKhau);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}