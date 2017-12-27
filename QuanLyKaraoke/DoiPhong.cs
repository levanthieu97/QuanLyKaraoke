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
    public partial class DoiPhong : DevExpress.XtraEditors.XtraForm
    {
        BUS_DatPhong datphong = new BUS_DatPhong();
        string phongcandoi;
        public DoiPhong(String phong)
        {
            InitializeComponent();
            comboBox1.DataSource = datphong.LoadDanhSachPhongTrong();
            comboBox1.DisplayMember = "IDPhongHat";
            comboBox1.ValueMember = "IDPhongHat";
            textBox1.Text = phong;
            phongcandoi = phong;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datphong.DoiPhong(comboBox1.SelectedValue.ToString(), phongcandoi);
        }
    }
}