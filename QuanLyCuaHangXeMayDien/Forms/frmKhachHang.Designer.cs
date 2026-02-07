namespace QuanLyCuaHangXeMayDien.Forms
{
    partial class frmKhachHang
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
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            HovaTen = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(898, 161);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(765, 107);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 34);
            btnXuat.TabIndex = 14;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(765, 67);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 34);
            btnNhap.TabIndex = 13;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(765, 27);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 34);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 107);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 11;
            label3.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(95, 107);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(481, 31);
            txtDiaChi.TabIndex = 10;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(426, 33);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(150, 31);
            txtDienThoai.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 36);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 8;
            label2.Text = "Điện Thoại: ";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(677, 107);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 34);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(677, 67);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(82, 34);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(677, 27);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 34);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(594, 67);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(594, 107);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(77, 34);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(594, 27);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(77, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(133, 33);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(181, 31);
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
            groupBox2.Location = new Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(898, 259);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { HovaTen, DiaChi, SoDienThoai });
            dataGridView.Location = new Point(17, 34);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(875, 225);
            dataGridView.TabIndex = 1;
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 8;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            // 
            // HovaTen
            // 
            HovaTen.DataPropertyName = "HovaTen";
            HovaTen.HeaderText = "Họ Và Tên";
            HovaTen.MinimumWidth = 8;
            HovaTen.Name = "HovaTen";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmKhachHang";
            Text = "Khách Hàng";
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtHoVaTen;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Label label3;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn HovaTen;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
    }
}