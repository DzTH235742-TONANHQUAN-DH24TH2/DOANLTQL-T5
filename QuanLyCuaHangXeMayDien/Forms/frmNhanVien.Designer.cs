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
            dataGridView = new DataGridView();
            HoVaTen = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHang = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 161);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản Lý", "Nhân Viên" });
            cboQuyenHan.Location = new Point(508, 108);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(236, 33);
            cboQuyenHan.TabIndex = 20;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(508, 70);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(236, 31);
            txtMatKhau.TabIndex = 19;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(508, 30);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(236, 31);
            txtTenDangNhap.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 107);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 17;
            label6.Text = "Quyền Hạn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 67);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 16;
            label5.Text = "Mật Khẩu: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 32);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 15;
            label4.Text = "Tên Đăng Nhập: ";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(921, 107);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 34);
            btnXuat.TabIndex = 14;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(921, 67);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 34);
            btnNhap.TabIndex = 13;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(921, 27);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 34);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 107);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 11;
            label3.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(117, 107);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(223, 31);
            txtDiaChi.TabIndex = 10;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(117, 67);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(223, 31);
            txtDienThoai.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 67);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 8;
            label2.Text = "Điện Thoại: ";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(833, 107);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 34);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(833, 67);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(82, 34);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(833, 27);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 34);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(750, 67);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(750, 107);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(77, 34);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(750, 27);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(77, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(117, 33);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(223, 31);
            txtHoVaTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 36);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(23, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1029, 259);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { HoVaTen, DiaChi, SoDienThoai, TenDangNhap, QuyenHang });
            dataGridView.Location = new Point(17, 34);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1006, 225);
            dataGridView.TabIndex = 0;
            // 
            // HoVaTen
            // 
            HoVaTen.HeaderText = "Họ Tên";
            HoVaTen.MinimumWidth = 8;
            HoVaTen.Name = "HoVaTen";
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 8;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // TenDangNhap
            // 
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 8;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHang
            // 
            QuyenHang.HeaderText = "Quyen Hạng";
            QuyenHang.MinimumWidth = 8;
            QuyenHang.Name = "QuyenHang";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmNhanVien";
            Text = "Nhân Viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
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
        private GroupBox groupBox2;
        private TextBox txtTenDangNhap;
        private Label label6;
        private Label label5;
        private ComboBox cboQuyenHan;
        private TextBox txtMatKhau;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHang;
    }
}