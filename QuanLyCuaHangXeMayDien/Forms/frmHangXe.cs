using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangXeMayDien.Data;
using ClosedXML.Excel;
using System.Data;

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

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu hãng xe từ Excel";
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
                            // Tùy theo tên class bạn đặt là HangXe hay NhaSanXuat mà sửa lại cho đúng nhé
                            NhaSanXuat hx = new NhaSanXuat();
                            hx.TenNhaSanXuat = r["TenHang"].ToString();

                            context.NhaSanXuats.Add(hx); // Hoặc context.NhaSanXuat.Add(hx);
                        }
                        context.SaveChanges();
                        MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " hãng xe.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmHangXe_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: Kiểm tra lại tên cột trong file Excel xem đã đúng chuẩn chưa (TenHang).\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu hãng xe ra Excel";
            saveFileDialog.Filter = "Tập tin Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "HangXe_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("TenHang", typeof(string))
            });

                    var danhSachHX = context.NhaSanXuats.ToList(); // Hoặc context.NhaSanXuat.ToList();
                    foreach (var hx in danhSachHX)
                    {
                        table.Rows.Add(hx.ID, hx.TenNhaSanXuat);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "HangXe");
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