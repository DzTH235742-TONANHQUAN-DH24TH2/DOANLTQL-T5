namespace QuanLyCuaHangXeMayDien.Forms
{
    partial class frmNhanVien
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
            panel1 = new Panel();
            cboQuyenHan = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            label3 = new Label();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            label2 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtHoVaTen = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            HoVaTen = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHang = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1068, 184);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(cboQuyenHan);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnXuat);
            panel1.Controls.Add(btnNhap);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtDienThoai);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtHoVaTen);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 150);
            panel1.TabIndex = 0;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản Lý", "Nhân Viên" });
            cboQuyenHan.Location = new Point(493, 99);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(236, 33);
            cboQuyenHan.TabIndex = 41;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(493, 61);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(236, 31);
            txtMatKhau.TabIndex = 40;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(493, 21);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(236, 31);
            txtTenDangNhap.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 98);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 38;
            label6.Text = "Quyền Hạn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 58);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 37;
            label5.Text = "Mật Khẩu: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 23);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 36;
            label4.Text = "Tên Đăng Nhập: ";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(906, 98);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 34);
            btnXuat.TabIndex = 35;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(906, 58);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 34);
            btnNhap.TabIndex = 34;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(906, 18);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 34);
            btnTimKiem.TabIndex = 33;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 98);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 32;
            label3.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(102, 98);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(223, 31);
            txtDiaChi.TabIndex = 31;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(102, 58);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(223, 31);
            txtDienThoai.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 58);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 29;
            label2.Text = "Điện Thoại: ";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(818, 98);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 34);
            btnThoat.TabIndex = 28;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(818, 58);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(82, 34);
            btnHuyBo.TabIndex = 27;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(818, 18);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 34);
            btnLuu.TabIndex = 26;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(735, 58);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 34);
            btnXoa.TabIndex = 25;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(735, 98);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(77, 34);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(735, 18);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(77, 34);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(102, 24);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(223, 31);
            txtHoVaTen.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 27);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 21;
            label1.Text = "Họ và Tên :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1068, 275);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Nhân Viên";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(dataGridView);
            panel2.Location = new Point(14, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1011, 229);
            panel2.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { HoVaTen, DiaChi, SoDienThoai, TenDangNhap, QuyenHang });
            dataGridView.Location = new Point(2, 21);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1006, 186);
            dataGridView.TabIndex = 1;
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoTen";
            HoVaTen.HeaderText = "Họ Tên";
            HoVaTen.MinimumWidth = 8;
            HoVaTen.Name = "HoVaTen";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "DienThoai";
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 8;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 8;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHang
            // 
            QuyenHang.DataPropertyName = "QuyenHang";
            QuyenHang.HeaderText = "Quyền Hạng";
            QuyenHang.MinimumWidth = 8;
            QuyenHang.Name = "QuyenHang";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 459);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "Nhân Viên";
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private ComboBox cboQuyenHan;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Label label3;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private Label label2;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtHoVaTen;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHang;
    }
}