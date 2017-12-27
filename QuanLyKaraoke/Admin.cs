using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QuanLyKaraoke
{
    public partial class Admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoaiPhong lp = new LoaiPhong();
            lp.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {

            QuanLyDatPhong datphong = new QuanLyDatPhong();
            datphong.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            DichVu dv = new DichVu();
            this.Visible = false;
            dv.ShowDialog();
            this.Visible = true;
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            HoaDon hd = new HoaDon();
            this.Visible = false;
            hd.ShowDialog();
            this.Visible = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
                return;
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            Nhansu ns = new Nhansu();
            this.Visible = false;
            ns.ShowDialog();
            this.Visible = true;
        }
    }
}