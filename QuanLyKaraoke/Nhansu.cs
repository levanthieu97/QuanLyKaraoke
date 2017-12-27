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
namespace QuanLyKaraoke
{
    public partial class Nhansu : DevExpress.XtraEditors.XtraForm
    {
        BUS_NhanVien bnv;
        string TenButton = "";
        public Nhansu()
        {
            bnv = new BUS_NhanVien();
            InitializeComponent();
            LoadHienThi();
            TrangThaiTextBox(false);
            TrangThaiButtonLuuAndHuy(false);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void qlnhanvien_Click(object sender, EventArgs e)
        {

        }

        private void LoadHienThi()
        {
            qlnhanvien.DataSource = bnv.HienThiNhanVien();
        }
        private void Nhansu_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            TenButton = btnthem.Text;
            TrangThaiButton(false);
            btnthem.Enabled = true;
            TrangThaiButtonLuuAndHuy(true);
            clearTextBox();
            TrangThaiTextBox(true);
            lbidnv.Text = "";
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            try
            {
                switch (TenButton)
                {
                    case "Thêm":
                        ThemNhanVien();
                        break;
                    case "Sửa":
                        SuaNhanVien();
                        break;
                    /*case "Xóa":
                        XoaNhanVien();
                        break;*/
                }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            }catch(Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
        }
        private void ThemNhanVien()
        {
            try
            {
                LopNhanVien nv = new LopNhanVien();                
                nv.TenNhanVien = tbten.Text;
                nv.GioiTinh = tbgioitinh.Text;
                nv.SoDienThoai = tbsdt.Text;
                nv.DiaChi = tbdiachi.Text;
                bnv = new BUS_NhanVien();
                if (bnv.InsertNhanVien(nv))
                {
                    MessageBox.Show("Bạn đã thêm nhân viên thành công.");
                    LoadHienThi();
                    TenButton = "";
                }
                else
                    MessageBox.Show("Thêm nhân viên thất bại!");
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            }catch(Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
        }
        private void SuaNhanVien()
        {
            try
            {
                LopNhanVien NhanVienSua = new LopNhanVien();
                NhanVienSua.ID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                NhanVienSua.TenNhanVien = tbten.Text;
                NhanVienSua.GioiTinh = tbgioitinh.Text;
                NhanVienSua.SoDienThoai = tbsdt.Text;
                NhanVienSua.DiaChi = tbdiachi.Text;
                bnv = new BUS_NhanVien();
                if (bnv.UpdateNhanVien(NhanVienSua))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công !!");
                    LoadHienThi();
                    TenButton = "";
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại !!");

                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
        }
        private void XoaNhanVien()
        {
            int IDNV = int.Parse(lbidnv.Text);
            bnv = new BUS_NhanVien();
            if (bnv.DeleteNhanVien(IDNV))
            {
                MessageBox.Show("Bạn đã xóa nhân viên thành công !!");
                LoadHienThi();
                TenButton = "";
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                lbidnv.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                tbten.Text = gridView1.GetFocusedRowCellValue("TenNhanVien").ToString();
                tbgioitinh.Text = gridView1.GetFocusedRowCellValue("GioiTinh").ToString();
                tbsdt.Text = gridView1.GetFocusedRowCellValue("SoDienThoai").ToString();
                tbdiachi.Text = gridView1.GetFocusedRowCellValue("DiaChi").ToString();
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch(Exception ex)
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

        private void Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên", "xóa", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                TenButton = Xoa.Text;
                XoaNhanVien();
            }
            else
                return;
        }
        private void TrangThaiButton(bool trangthai)
        {
            btnthem.Enabled = Sua.Enabled = Xoa.Enabled = trangthai;
        }

        private void TrangThaiButtonLuuAndHuy(bool trangthai)
        {
            Luu.Enabled = btnThoat.Enabled = trangthai;
        }

        private void TrangThaiTextBox(bool trangthai)
        {
            tbten.Enabled = tbgioitinh.Enabled = tbsdt.Enabled = tbdiachi.Enabled = trangthai;
        }

        private void clearTextBox()
        {
            tbten.Text = tbgioitinh.Text = tbsdt.Text = tbdiachi.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            clearTextBox();
            TrangThaiButtonLuuAndHuy(false);
            TrangThaiButton(true);
        }

        private void tbten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbten_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}