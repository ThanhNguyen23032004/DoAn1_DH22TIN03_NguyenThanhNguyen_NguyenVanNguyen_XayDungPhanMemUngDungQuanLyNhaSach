﻿namespace QLyNhaSach
{
    partial class FrmTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaiKhoan));
            this.GrpBThongTin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbTenNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbPhanQquyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pcbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvDanhSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GruBChucNang = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuuLai = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHuy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.GrpBThongTin.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.GruBChucNang.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBThongTin
            // 
            this.GrpBThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBThongTin.BorderRadius = 20;
            this.GrpBThongTin.Controls.Add(this.tableLayoutPanel2);
            this.GrpBThongTin.Controls.Add(this.guna2Panel2);
            this.GrpBThongTin.CustomBorderColor = System.Drawing.Color.Silver;
            this.GrpBThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GrpBThongTin.ForeColor = System.Drawing.Color.Black;
            this.GrpBThongTin.Location = new System.Drawing.Point(12, 9);
            this.GrpBThongTin.Name = "GrpBThongTin";
            this.GrpBThongTin.Size = new System.Drawing.Size(1191, 275);
            this.GrpBThongTin.TabIndex = 0;
            this.GrpBThongTin.Text = "Thông Tin";
            this.GrpBThongTin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.38758F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.8758F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.817987F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.7666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.03212F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.01285F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbbTrangThai, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbbTenNV, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbbPhanQquyen, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtHoTen, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMatKhau, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtTaiKhoan, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(257, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.510638F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.74468F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.53192F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.82979F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.06383F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(934, 235);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(68, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(602, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "Trạng Thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(321, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 36);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tài Khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(602, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 36);
            this.label6.TabIndex = 27;
            this.label6.Text = "Phân Quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(321, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 36);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(68, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 36);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbbTrangThai.BorderRadius = 15;
            this.cbbTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTrangThai.ItemHeight = 30;
            this.cbbTrangThai.Items.AddRange(new object[] {
            ""});
            this.cbbTrangThai.Location = new System.Drawing.Point(602, 58);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(277, 36);
            this.cbbTrangThai.TabIndex = 28;
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTenNV.BackColor = System.Drawing.Color.Transparent;
            this.cbbTenNV.BorderRadius = 15;
            this.cbbTenNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTenNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTenNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTenNV.ItemHeight = 30;
            this.cbbTenNV.Location = new System.Drawing.Point(68, 154);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(205, 36);
            this.cbbTenNV.TabIndex = 29;
            // 
            // cbbPhanQquyen
            // 
            this.cbbPhanQquyen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPhanQquyen.BackColor = System.Drawing.Color.Transparent;
            this.cbbPhanQquyen.BorderRadius = 15;
            this.cbbPhanQquyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbPhanQquyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPhanQquyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhanQquyen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPhanQquyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPhanQquyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbPhanQquyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbPhanQquyen.ItemHeight = 30;
            this.cbbPhanQquyen.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên",
            "Thủ kho"});
            this.cbbPhanQquyen.Location = new System.Drawing.Point(602, 154);
            this.cbbPhanQquyen.Name = "cbbPhanQquyen";
            this.cbbPhanQquyen.Size = new System.Drawing.Size(277, 36);
            this.cbbPhanQquyen.TabIndex = 30;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.Transparent;
            this.txtHoTen.BorderRadius = 15;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(68, 59);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(205, 52);
            this.txtHoTen.TabIndex = 31;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.BorderRadius = 15;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Location = new System.Drawing.Point(321, 155);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(231, 48);
            this.txtMatKhau.TabIndex = 32;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTaiKhoan.BorderRadius = 15;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.DefaultText = "";
            this.txtTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.Location = new System.Drawing.Point(321, 59);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PlaceholderText = "";
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.Size = new System.Drawing.Size(231, 52);
            this.txtTaiKhoan.TabIndex = 33;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.pcbAvatar);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 40);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(257, 235);
            this.guna2Panel2.TabIndex = 26;
            // 
            // pcbAvatar
            // 
            this.pcbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pcbAvatar.BorderRadius = 20;
            this.pcbAvatar.Image = global::QLyNhaSach.Properties.Resources.icon_Account;
            this.pcbAvatar.ImageRotate = 0F;
            this.pcbAvatar.Location = new System.Drawing.Point(29, 15);
            this.pcbAvatar.Name = "pcbAvatar";
            this.pcbAvatar.Size = new System.Drawing.Size(200, 190);
            this.pcbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAvatar.TabIndex = 25;
            this.pcbAvatar.TabStop = false;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox3.BorderRadius = 20;
            this.guna2GroupBox3.Controls.Add(this.dgvDanhSach);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(12, 425);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(1191, 229);
            this.guna2GroupBox3.TabIndex = 2;
            this.guna2GroupBox3.Text = "Danh Sách Dữ Liệu Tài Khoản Người Dùng";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSach.ColumnHeadersHeight = 61;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.TaiKhoan,
            this.MatKhau,
            this.PhanQuyen,
            this.TrangThai,
            this.NgayTao});
            this.dgvDanhSach.Cursor = System.Windows.Forms.Cursors.AppStarting;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Enabled = false;
            this.dgvDanhSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 40);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.DividerHeight = 1;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(1191, 189);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.TabStop = false;
            this.dgvDanhSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDanhSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDanhSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSach.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDanhSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvDanhSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDanhSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhSach.ThemeStyle.HeaderStyle.Height = 61;
            this.dgvDanhSach.ThemeStyle.ReadOnly = true;
            this.dgvDanhSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDanhSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvDanhSach.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDanhSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaNV
            // 
            this.MaNV.DividerWidth = 1;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DividerWidth = 1;
            this.HoTen.HeaderText = "Tên Nhân Viên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.DividerWidth = 1;
            this.TaiKhoan.HeaderText = "Tài Khoản";
            this.TaiKhoan.MinimumWidth = 6;
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DividerWidth = 1;
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // PhanQuyen
            // 
            this.PhanQuyen.DividerWidth = 1;
            this.PhanQuyen.HeaderText = "Phân Quyền";
            this.PhanQuyen.MinimumWidth = 6;
            this.PhanQuyen.Name = "PhanQuyen";
            this.PhanQuyen.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DividerWidth = 1;
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // NgayTao
            // 
            this.NgayTao.DividerWidth = 1;
            this.NgayTao.HeaderText = "Ngày Tạo";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            // 
            // GruBChucNang
            // 
            this.GruBChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GruBChucNang.BackColor = System.Drawing.Color.Transparent;
            this.GruBChucNang.BorderRadius = 20;
            this.GruBChucNang.Controls.Add(this.tableLayoutPanel1);
            this.GruBChucNang.CustomBorderColor = System.Drawing.Color.Silver;
            this.GruBChucNang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GruBChucNang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GruBChucNang.ForeColor = System.Drawing.Color.Black;
            this.GruBChucNang.Location = new System.Drawing.Point(12, 290);
            this.GruBChucNang.Name = "GruBChucNang";
            this.GruBChucNang.Size = new System.Drawing.Size(676, 129);
            this.GruBChucNang.TabIndex = 1;
            this.GruBChucNang.Text = "Chức Năng";
            this.GruBChucNang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.53231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.53231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.53231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.53231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.87075F));
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLuuLai, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnHuy, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 89);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // btnThem
            // 
            this.btnThem.BorderColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderRadius = 10;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FillColor = System.Drawing.Color.Lime;
            this.btnThem.FillColor2 = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.btnThem.Location = new System.Drawing.Point(3, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.BorderColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderRadius = 10;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.FillColor = System.Drawing.Color.Red;
            this.btnSua.FillColor2 = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.btnSua.Location = new System.Drawing.Point(107, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 44);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.BorderColor = System.Drawing.Color.Transparent;
            this.btnLuuLai.BorderRadius = 10;
            this.btnLuuLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuLai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuuLai.FillColor = System.Drawing.Color.Lime;
            this.btnLuuLai.FillColor2 = System.Drawing.Color.White;
            this.btnLuuLai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuLai.ForeColor = System.Drawing.Color.Black;
            this.btnLuuLai.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.btnLuuLai.Location = new System.Drawing.Point(211, 22);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(98, 44);
            this.btnLuuLai.TabIndex = 2;
            this.btnLuuLai.Text = "Lưu Lại";
            // 
            // btnHuy
            // 
            this.btnHuy.BorderColor = System.Drawing.Color.Transparent;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuy.FillColor = System.Drawing.Color.Red;
            this.btnHuy.FillColor2 = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.btnHuy.Location = new System.Drawing.Point(315, 22);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 44);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.btnTimKiem);
            this.guna2Panel1.Controls.Add(this.txtTimKiem);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(419, 22);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(254, 44);
            this.guna2Panel1.TabIndex = 26;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.BorderColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(190, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(38, 38);
            this.btnTimKiem.TabIndex = 24;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiem.BorderRadius = 15;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(0, 0);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(254, 44);
            this.txtTimKiem.TabIndex = 23;
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 666);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.GruBChucNang);
            this.Controls.Add(this.GrpBThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTaiKhoan";
            this.Text = "FrmTaiKhoan";
            this.GrpBThongTin.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.GruBChucNang.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GrpBThongTin;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSach;
        private Guna.UI2.WinForms.Guna2PictureBox pcbAvatar;
        private Guna.UI2.WinForms.Guna2GroupBox GruBChucNang;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuuLai;
        private Guna.UI2.WinForms.Guna2GradientButton btnHuy;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTenNV;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPhanQquyen;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
    }
}