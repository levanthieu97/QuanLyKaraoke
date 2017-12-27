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
    public partial class NhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLyDatPhong datphong = new QuanLyDatPhong();
            datphong.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
                return;
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Nhansu ns = new Nhansu();
            ns.ShowDialog();
        }
    }
}