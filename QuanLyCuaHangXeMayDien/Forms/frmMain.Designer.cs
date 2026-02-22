namespace QuanLyCuaHangXeMayDien.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            button1 = new Button();
            btnLoaiXe = new Button();
            btnHangXe = new Button();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            button2 = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pnlContent = new Panel();
            btnHoaDon = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(472, 117);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLoaiXe
            // 
            btnLoaiXe.BackColor = Color.LightCyan;
            btnLoaiXe.FlatStyle = FlatStyle.Popup;
            btnLoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLoaiXe.Location = new Point(13, 91);
            btnLoaiXe.Name = "btnLoaiXe";
            btnLoaiXe.Size = new Size(149, 34);
            btnLoaiXe.TabIndex = 1;
            btnLoaiXe.Text = "Loại Xe";
            btnLoaiXe.UseVisualStyleBackColor = false;
            btnLoaiXe.Click += btnLoaiXe_Click;
            // 
            // btnHangXe
            // 
            btnHangXe.BackColor = Color.LightCyan;
            btnHangXe.FlatStyle = FlatStyle.Popup;
            btnHangXe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHangXe.Location = new Point(11, 152);
            btnHangXe.Name = "btnHangXe";
            btnHangXe.Size = new Size(149, 34);
            btnHangXe.TabIndex = 2;
            btnHangXe.Text = "Hãng Xe";
            btnHangXe.UseVisualStyleBackColor = false;
            btnHangXe.Click += btnHangXe_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.LightCyan;
            btnKhachHang.FlatStyle = FlatStyle.Popup;
            btnKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnKhachHang.Location = new Point(11, 218);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(150, 34);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.LightCyan;
            btnNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnNhanVien.Location = new Point(12, 283);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(150, 34);
            btnNhanVien.TabIndex = 4;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // button2
            // 
            button2.Location = new Point(481, 231);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(13, 421);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(149, 34);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnHoaDon);
            panel1.Controls.Add(btnLoaiXe);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHangXe);
            panel1.Controls.Add(btnKhachHang);
            panel1.Controls.Add(btnNhanVien);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 467);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(181, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(703, 79);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(703, 79);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ CỬA HÀNG XE MÁY ĐIỆN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.BackgroundImage = (Image)resources.GetObject("pnlContent.BackgroundImage");
            pnlContent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(181, 79);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(703, 388);
            pnlContent.TabIndex = 7;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.LightCyan;
            btnHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHoaDon.Location = new Point(10, 341);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(150, 34);
            btnHoaDon.TabIndex = 5;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 467);
            Controls.Add(pnlContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmMain";
            Text = "Trang Chủ";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnLoaiXe;
        private Button btnHangXe;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private Button button2;
        private Button btnThoat;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel pnlContent;
        private Button btnHoaDon;
    }
}