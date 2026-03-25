using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangXeMayDien.Data; // Thêm dòng này để gọi được QLXMDDbContext
using ClosedXML.Excel;
using System.Data;

namespace QuanLyCuaHangXeMayDien.Forms
{
    public partial class frmLoaiXe : Form
    {
        QLXMDDbContext context = new QLXMDDbContext();
        bool xuLyThem = false;
        int id;

        public frmLoaiXe()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenXe.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmLoaiXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // Gọi đúng bảng LoaiXes trong DbContext của bạn
            var lsp = context.LoaiXes.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;

            txtTenXe.DataBindings.Clear();
            // Lưu ý: Nếu trong file LoaiXe.cs bạn đổi thuộc tính TenLoai thành tên khác (vd: TenXe) thì sửa chữ "TenLoai" ở đây lại nhé
            txtTenXe.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenXe.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells[0].Value != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenXe.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại xe?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    var lsp = new LoaiXe();
                    lsp.TenLoai = txtTenXe.Text; // Sửa "TenLoai" nếu file LoaiXe.cs bạn dùng tên biến khác
                    context.LoaiXes.Add(lsp);
                    context.SaveChanges();
                }
                else
                {
                    var lsp = context.LoaiXes.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenLoai = txtTenXe.Text; // Sửa "TenLoai" nếu file LoaiXe.cs bạn dùng tên biến khác
                        context.LoaiXes.Update(lsp);
                        context.SaveChanges();
                    }
                }
                frmLoaiXe_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại xe này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells[0].Value != null)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
                    var lsp = context.LoaiXes.Find(id);

                    if (lsp != null)
                    {
                        context.LoaiXes.Remove(lsp);
                        context.SaveChanges();
                        frmLoaiXe_Load(sender, e);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiXe_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu loại xe từ Excel";
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
                            LoaiXe lx = new LoaiXe();
                            lx.TenLoai = r["TenLoai"].ToString();

                            context.LoaiXes.Add(lx);
                        }
                        context.SaveChanges();
                        MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " loại xe.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmLoaiXe_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: Kiểm tra lại tên cột trong file Excel xem đã đúng chuẩn chưa (TenLoai).\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu loại xe ra Excel";
            saveFileDialog.Filter = "Tập tin Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "LoaiXe_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("TenLoai", typeof(string))
            });

                    var danhSachLX = context.LoaiXes.ToList();
                    foreach (var lx in danhSachLX)
                    {
                        table.Rows.Add(lx.ID, lx.TenLoai);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "LoaiXe");
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