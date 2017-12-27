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
namespace QuanLyKaraoke
{
    public partial class LoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        BUS_LoaiPhong blp;
        public LoaiPhong()
        {
            blp = new BUS_LoaiPhong();
            InitializeComponent();
            comboBox1.DataSource = blp.HienThiLoaiPhong();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}