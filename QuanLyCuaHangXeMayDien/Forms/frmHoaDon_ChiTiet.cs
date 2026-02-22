using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangXeMayDien.Data;

namespace QuanLyCuaHangXeMayDien.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        QLXMDDbContext context = new QLXMDDbContext();
        int id;
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();

        public frmHoaDon_ChiTiet()
        {
            InitializeComponent();
        }

        public frmHoaDon_ChiTiet(int maHoaDon)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoTen";
        }

        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoTen";
        }

        public void LayXeVaoComboBox()
        {
            cboXe.DataSource = context.XeMayDien.ToList();
            cboXe.ValueMember = "ID";
            cboXe.DisplayMember = "TenXe"; // Giả định trong class XeMayDien bạn đặt tên xe là TenXe
        }

        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0)
            {
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                cboXe.Text = "";
                numSoLuongBan.Value = 1;
                numDonGiaBan.Value = 0;
            }
            btnLuuHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LayXeVaoComboBox();

            dataGridView.AutoGenerateColumns = false;

            if (id != 0)
            {
                var hoaDon = context.HoaDon.Where(r => r.ID == id).SingleOrDefault();
                if (hoaDon != null)
                {
                    cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                    cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                }

                var ct = context.ChiTietHoaDons.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    XeMayDienID = r.XeMayDienID,
                    TenXe = r.XeMayDien.TenXe,
                    SoLuongBan = (short)r.SoLuong,
                    DonGiaBan = r.DonGia,
                    ThanhTien = r.SoLuong * r.DonGia
                }).ToList();

                hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
            }

            dataGridView.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        private void cboXe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboXe.SelectedValue != null)
            {
                int maXe = Convert.ToInt32(cboXe.SelectedValue.ToString());
                var xe = context.XeMayDien.Find(maXe);
                if (xe != null)
                {
                    numDonGiaBan.Value = xe.DonGia; // Giả định class XeMayDien có biến DonGia
                }
            }
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboXe.Text))
                MessageBox.Show("Vui lòng chọn xe.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongBan.Value <= 0)
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGiaBan.Value <= 0)
                MessageBox.Show("Đơn giá bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int maXe = Convert.ToInt32(cboXe.SelectedValue.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.XeMayDienID == maXe);

                if (chiTiet != null)
                {
                    chiTiet.SoLuongBan = Convert.ToInt16(numSoLuongBan.Value);
                    chiTiet.DonGiaBan = Convert.ToInt32(numDonGiaBan.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value);
                    dataGridView.Refresh();
                }
                else
                {
                    DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
                    {
                        ID = 0,
                        HoaDonID = id,
                        XeMayDienID = maXe,
                        TenXe = cboXe.Text,
                        SoLuongBan = Convert.ToInt16(numSoLuongBan.Value),
                        DonGiaBan = Convert.ToInt32(numDonGiaBan.Value),
                        ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value)
                    };
                    hoaDonChiTiet.Add(ct);
                }
                BatTatChucNang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int maXe = Convert.ToInt32(dataGridView.CurrentRow.Cells["XeMayDienID"].Value.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.XeMayDienID == maXe);
                if (chiTiet != null)
                {
                    hoaDonChiTiet.Remove(chiTiet);
                }
                BatTatChucNang();
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
                MessageBox.Show("Vui lòng chọn nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboKhachHang.Text))
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id != 0)
                {
                    HoaDon hd = context.HoaDon.Find(id);
                    if (hd != null)
                    {
                        hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                        hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
                        context.HoaDon.Update(hd);

                        var old = context.ChiTietHoaDons.Where(r => r.HoaDonID == id).ToList();
                        context.ChiTietHoaDons.RemoveRange(old);

                        foreach (var item in hoaDonChiTiet.ToList())
                        {
                            ChiTietHoaDon ct = new ChiTietHoaDon();
                            ct.HoaDonID = id;
                            ct.XeMayDienID = item.XeMayDienID;
                            ct.SoLuong = item.SoLuongBan;
                            ct.DonGia = item.DonGiaBan;
                            context.ChiTietHoaDons.Add(ct);
                        }
                        context.SaveChanges();
                    }
                }
                else
                {
                    HoaDon hd = new HoaDon();
                    hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
                    hd.NgayLap = DateTime.Now;
                    context.HoaDon.Add(hd);
                    context.SaveChanges();

                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        ChiTietHoaDon ct = new ChiTietHoaDon();
                        ct.HoaDonID = hd.ID;
                        ct.XeMayDienID = item.XeMayDienID;
                        ct.SoLuong = item.SoLuongBan;
                        ct.DonGia = item.DonGiaBan;
                        context.ChiTietHoaDons.Add(ct);
                    }
                    context.SaveChanges();
                }
                MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}