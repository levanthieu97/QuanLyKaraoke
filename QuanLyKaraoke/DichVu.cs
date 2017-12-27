using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKaraoke.BUS;
using QuanLyKaraoke.Object;
#pragma warning disable CS0105 // The using directive for 'System.Data' appeared previously in this namespace
using System.Data;
#pragma warning restore CS0105 // The using directive for 'System.Data' appeared previously in this namespace
using System.Data.SqlClient;
namespace QuanLyKaraoke
{
    public partial class DichVu : DevExpress.XtraEditors.XtraForm
    {
        BUS_DichVu bdv;
        String TenButton = "";
        public DichVu()
        {
            bdv = new BUS_DichVu();
            InitializeComponent();
            qlDichVu.DataSource = bdv.HienThiDichVu();
            TrangThaiTextBox(false);
            TrangThaiButtonLuuAndHuy(false);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.qlDichVu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.lbten = new System.Windows.Forms.Label();
            this.Sua = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.tbgia = new System.Windows.Forms.Label();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.id = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.Luu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.qlDichVu);
            this.panel1.Location = new System.Drawing.Point(319, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 334);
            this.panel1.TabIndex = 7;
            // 
            // qlDichVu
            // 
            this.qlDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlDichVu.Location = new System.Drawing.Point(0, 0);
            this.qlDichVu.MainView = this.gridView1;
            this.qlDichVu.Name = "qlDichVu";
            this.qlDichVu.Size = new System.Drawing.Size(452, 334);
            this.qlDichVu.TabIndex = 0;
            this.qlDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.qlDichVu.Click += new System.EventHandler(this.qlDichVu_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.qlDichVu;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(162, 99);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(138, 20);
            this.txtTen.TabIndex = 6;
            this.txtTen.EditValueChanged += new System.EventHandler(this.txtTen_EditValueChanged);
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.Location = new System.Drawing.Point(22, 100);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(121, 19);
            this.lbten.TabIndex = 5;
            this.lbten.Text = "Tên sản phẩm: ";
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(120, 211);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(76, 39);
            this.Sua.TabIndex = 9;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(26, 211);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(76, 39);
            this.Them.TabIndex = 8;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // tbgia
            // 
            this.tbgia.AutoSize = true;
            this.tbgia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgia.Location = new System.Drawing.Point(23, 164);
            this.tbgia.Name = "tbgia";
            this.tbgia.Size = new System.Drawing.Size(38, 19);
            this.tbgia.TabIndex = 10;
            this.tbgia.Text = "Giá:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(162, 163);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(138, 20);
            this.txtGia.TabIndex = 11;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(24, 56);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(37, 19);
            this.id.TabIndex = 12;
            this.id.Text = "ID: ";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(67, 61);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(19, 13);
            this.lbid.TabIndex = 13;
            this.lbid.Text = "...";
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(224, 211);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(76, 39);
            this.Xoa.TabIndex = 14;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(162, 268);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(76, 39);
            this.Thoat.TabIndex = 15;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsoluong.Location = new System.Drawing.Point(24, 134);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(83, 19);
            this.lbsoluong.TabIndex = 16;
            this.lbsoluong.Text = "Số Lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(162, 133);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(138, 20);
            this.txtSoLuong.TabIndex = 17;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(67, 268);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(76, 39);
            this.Luu.TabIndex = 18;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click_1);
            // 
            // DichVu
            // 
            this.ClientSize = new System.Drawing.Size(793, 407);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lbsoluong);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.id);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.tbgia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Them);
            this.Name = "DichVu";
            this.Text = "Dịch vụ";
            this.Load += new System.EventHandler(this.DichVu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qlDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel panel1;
        private TextEdit txtTen;
        private Label lbten;
        private Button Sua;
        private Button Them;

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void DichVu_Load(object sender, EventArgs e)
        {

        }

        private Label tbgia;
        private TextEdit txtGia;
        private Label id;
        private Label lbid;
        private Button Xoa;
        private Button Thoat;
        private Label lbsoluong;
        private TextEdit txtSoLuong;

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private DevExpress.XtraGrid.GridControl qlDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

        private void txtTen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void qlDichVu_Click(object sender, EventArgs e)
        {

        }
        private void loadHienThi()
        {
            qlDichVu.DataSource = bdv.HienThiDichVu();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            TenButton = Them.Text;
            TrangThaiButton(false);
            Them.Enabled = true;
            TrangThaiButtonLuuAndHuy(true);
            clearTextBox();
            TrangThaiTextBox(true);
            lbid.Text = "";
            ThemDIchVu();
            lbid.Text = "";
        }
        private void ThemDIchVu()
        {
            try
            {
                BangDichVu dv = new BangDichVu();
                dv.TenSanPham = txtTen.Text;
                dv.SoLuong = int.Parse(txtSoLuong.Text);
                dv.Gia = txtGia.Text;
                bdv = new BUS_DichVu();
                if (bdv.InsertDichVu(dv))
                {
                    MessageBox.Show("Bạn đã thêm sản phẩm thành công.");
                    loadHienThi();
                    TenButton = "";
                }
                else
                    MessageBox.Show("Thêm Sản phẩm thất bại");
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            } catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            TenButton = Sua.Text;
            TrangThaiButton(false);
            Sua.Enabled = true;
            TrangThaiButtonLuuAndHuy(true);
            TrangThaiTextBox(true);
        }
        private void SuaDichVu()
        {
            try
            {
                BangDichVu suadv = new BangDichVu();
                suadv.IDSanPham = int.Parse(gridView1.GetFocusedRowCellValue("IDSanPham").ToString());
                suadv.TenSanPham = txtTen.Text;
                suadv.SoLuong = int.Parse(txtSoLuong.Text);
                suadv.Gia = txtGia.Text;
                bdv = new BUS_DichVu();
                if (bdv.UpdateDichVu(suadv))
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công !!");
                    loadHienThi();
                    TenButton = "";
                }
                else
                    MessageBox.Show("Cập nhật nhân viên thất bại !");
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            clearTextBox();
            TrangThaiButtonLuuAndHuy(false);
            TrangThaiButton(true);
        }

        private Button Luu;

        private void Luu_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (TenButton)
                {
                    case "Sửa":
                        SuaDichVu();
                        break;
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                lbid.Text = gridView1.GetFocusedRowCellValue("IDSanPham").ToString();
                txtTen.Text = gridView1.GetFocusedRowCellValue("TenSanPham").ToString();
                txtSoLuong.Text = gridView1.GetFocusedRowCellValue("SoLuong").ToString();
                txtGia.Text = gridView1.GetFocusedRowCellValue("Gia").ToString();

            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
        }

        private void XoaDichVu()
        {
            int IDDV = int.Parse(lbid.Text);
            bdv = new BUS_DichVu();
            if (bdv.DeleteDichVu(IDDV))
            {
                MessageBox.Show("Bạn đã xóa sản phẩm thành công!!");
                loadHienThi();
                TenButton = "";
            }
            else
                MessageBox.Show("Xóa sản phẩm thất bại");
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm", "xóa", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                TenButton = Xoa.Text;
                XoaDichVu();
            }
            else
                return;
        }
        private void TrangThaiButton(bool trangthai)
        {
            Them.Enabled = Sua.Enabled = Xoa.Enabled = trangthai;
        }

        private void TrangThaiButtonLuuAndHuy(bool trangthai)
        {
            Luu.Enabled = Thoat.Enabled = trangthai;
        }

        private void TrangThaiTextBox(bool trangthai)
        {
            txtTen.Enabled = txtSoLuong.Enabled = txtGia.Enabled = trangthai;
        }

        private void clearTextBox()
        {
            txtTen.Text = txtSoLuong.Text = txtGia.Text = "";
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}