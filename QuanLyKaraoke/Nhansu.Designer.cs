namespace QuanLyKaraoke
{
    partial class Nhansu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qlnhanvien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.tbten = new System.Windows.Forms.TextBox();
            this.lbgioitinh = new System.Windows.Forms.Label();
            this.tbgioitinh = new System.Windows.Forms.TextBox();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.Luu = new System.Windows.Forms.Button();
            this.lbidnv = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qlnhanvien);
            this.groupBox1.Location = new System.Drawing.Point(48, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // qlnhanvien
            // 
            this.qlnhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlnhanvien.Location = new System.Drawing.Point(3, 17);
            this.qlnhanvien.MainView = this.gridView1;
            this.qlnhanvien.Name = "qlnhanvien";
            this.qlnhanvien.Size = new System.Drawing.Size(688, 287);
            this.qlnhanvien.TabIndex = 0;
            this.qlnhanvien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.qlnhanvien.Click += new System.EventHandler(this.qlnhanvien_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TenNhanVien,
            this.GioiTinh,
            this.SoDienThoai,
            this.DiaChi});
            this.gridView1.GridControl = this.qlnhanvien;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Caption = "Tên Nhân Viên";
            this.TenNhanVien.FieldName = "TenNhanVien";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Visible = true;
            this.TenNhanVien.VisibleIndex = 1;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "GioiTinh";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 2;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Caption = "Số Điện Thoại";
            this.SoDienThoai.FieldName = "SoDienThoai";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Visible = true;
            this.SoDienThoai.VisibleIndex = 3;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 4;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(64, 160);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(94, 58);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(183, 160);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(94, 58);
            this.Sua.TabIndex = 2;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(304, 160);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(94, 58);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(619, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 58);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã nhân viên: ";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(80, 92);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(79, 13);
            this.lbten.TabIndex = 7;
            this.lbten.Text = "Tên nhân viên:";
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(183, 84);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(100, 21);
            this.tbten.TabIndex = 8;
            this.tbten.TextChanged += new System.EventHandler(this.tbten_TextChanged);
            this.tbten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbten_KeyPress);
            // 
            // lbgioitinh
            // 
            this.lbgioitinh.AutoSize = true;
            this.lbgioitinh.Location = new System.Drawing.Point(80, 123);
            this.lbgioitinh.Name = "lbgioitinh";
            this.lbgioitinh.Size = new System.Drawing.Size(49, 13);
            this.lbgioitinh.TabIndex = 9;
            this.lbgioitinh.Text = "Giới tính:";
            // 
            // tbgioitinh
            // 
            this.tbgioitinh.Location = new System.Drawing.Point(183, 115);
            this.tbgioitinh.Name = "tbgioitinh";
            this.tbgioitinh.Size = new System.Drawing.Size(100, 21);
            this.tbgioitinh.TabIndex = 10;
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(354, 118);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(73, 13);
            this.lbsdt.TabIndex = 11;
            this.lbsdt.Text = "Số điện thoại:";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(384, 92);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(43, 13);
            this.lbdiachi.TabIndex = 12;
            this.lbdiachi.Text = "Địa chỉ:";
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(448, 84);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(100, 21);
            this.tbdiachi.TabIndex = 13;
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(448, 110);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(100, 21);
            this.tbsdt.TabIndex = 14;
            this.tbsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsdt_KeyPress);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(481, 160);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(94, 58);
            this.Luu.TabIndex = 15;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // lbidnv
            // 
            this.lbidnv.AutoSize = true;
            this.lbidnv.Location = new System.Drawing.Point(180, 70);
            this.lbidnv.Name = "lbidnv";
            this.lbidnv.Size = new System.Drawing.Size(19, 13);
            this.lbidnv.TabIndex = 6;
            this.lbidnv.Text = "...";
            // 
            // Nhansu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 557);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.tbdiachi);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.tbgioitinh);
            this.Controls.Add(this.lbgioitinh);
            this.Controls.Add(this.tbten);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbidnv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nhansu";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.Nhansu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qlnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.Label lbgioitinh;
        private System.Windows.Forms.TextBox tbgioitinh;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.TextBox tbsdt;
        private DevExpress.XtraGrid.GridControl qlnhanvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button Luu;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private System.Windows.Forms.Label lbidnv;
    }
}