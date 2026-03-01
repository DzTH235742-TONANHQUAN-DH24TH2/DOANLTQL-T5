namespace QuanLyCuaHangXeMayDien.Forms
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            btnXuat = new Button();
            btnTimKiem = new Button();
            btnInHoaDon = new Button();
            btnLapHoaDon = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            panel1 = new Panel();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewTextBoxColumn();
            btnNhap = new Button();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(918, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dan Sách Hóa Đơn";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(btnNhap);
            panel2.Controls.Add(btnXuat);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(btnInHoaDon);
            panel2.Controls.Add(btnLapHoaDon);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Location = new Point(47, 323);
            panel2.Name = "panel2";
            panel2.Size = new Size(859, 115);
            panel2.TabIndex = 1;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(688, 36);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(74, 34);
            btnXuat.TabIndex = 32;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(570, 36);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 34);
            btnTimKiem.TabIndex = 31;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(158, 36);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(112, 34);
            btnInHoaDon.TabIndex = 30;
            btnInHoaDon.Text = "In Hóa Đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.ForeColor = Color.Blue;
            btnLapHoaDon.Location = new Point(16, 36);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(136, 34);
            btnLapHoaDon.TabIndex = 29;
            btnLapHoaDon.Text = "Lập Hóa Đơn..";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(472, 36);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(92, 34);
            btnThoat.TabIndex = 28;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(276, 36);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(92, 34);
            btnSua.TabIndex = 27;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(374, 36);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 34);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(71, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 287);
            panel1.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(776, 287);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân Viên";
            HoVaTenNhanVien.MinimumWidth = 8;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách Hàng";
            HoVaTenKhachHang.MinimumWidth = 8;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày Lập";
            NgayLap.MinimumWidth = 8;
            NgayLap.Name = "NgayLap";
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 8;
            TongTienHoaDon.Name = "TongTienHoaDon";
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            XemChiTiet.HeaderText = "Chi Tiết";
            XemChiTiet.MinimumWidth = 8;
            XemChiTiet.Name = "XemChiTiet";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(768, 36);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(68, 34);
            btnNhap.TabIndex = 33;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(918, 450);
            Controls.Add(groupBox1);
            Name = "frmHoaDon";
            Text = "Hóa Đơn";
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridView;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLapHoaDon;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnTimKiem;
        private Button btnInHoaDon;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewTextBoxColumn XemChiTiet;
        private Button btnNhap;
    }
}
//12