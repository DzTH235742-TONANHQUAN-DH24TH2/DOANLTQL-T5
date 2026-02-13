namespace QuanLyCuaHangXeMayDien.Forms
{
    partial class frmLoaiXe
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
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenXe = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            lD = new DataGridViewTextBoxColumn();
            TenXe = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1006, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Xe";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTenXe);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 114);
            panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 71);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(502, 71);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 34);
            btnHuyBo.TabIndex = 14;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(384, 71);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(266, 71);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(148, 71);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(30, 71);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtTenXe
            // 
            txtTenXe.Location = new Point(128, 9);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(583, 31);
            txtTenXe.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 12);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 8;
            label1.Text = "Tên Xe (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1006, 289);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Xe";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(dataGridView);
            panel2.Location = new Point(18, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(970, 229);
            panel2.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { lD, TenXe });
            dataGridView.Location = new Point(3, 3);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(948, 212);
            dataGridView.TabIndex = 1;
            // 
            // lD
            // 
            lD.DataPropertyName = "ID";
            lD.HeaderText = "ID";
            lD.MinimumWidth = 8;
            lD.Name = "lD";
            // 
            // TenXe
            // 
            TenXe.DataPropertyName = "TenLoai";
            TenXe.HeaderText = "Tên Xe";
            TenXe.MinimumWidth = 8;
            TenXe.Name = "TenXe";
            // 
            // frmLoaiXe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLoaiXe";
            Text = "Loại Xe";
            Load += frmLoaiXe_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Panel panel1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenXe;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn lD;
        private DataGridViewTextBoxColumn TenXe;
    }
}