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
    public partial class QuanLiDichVu : DevExpress.XtraEditors.XtraForm
    {
        BUS_DichVu dichvu = new BUS_DichVu();
        string idhoadon;
        public QuanLiDichVu(string id)
        {
            idhoadon = id;
            InitializeComponent();
           gridControl1.DataSource = dichvu.Load_DichVu(idhoadon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChiTietDichVu ctdv = new ChiTietDichVu();
            ctdv.ShowDialog();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = dichvu.LoadDanhSachDichVu();
            comboBox1.DisplayMember = "TenSanPham";
            comboBox1.ValueMember = "TenSanPham";
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textEdit3.Text = dichvu.getGiaTien(comboBox1.SelectedValue.ToString());
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
           

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textEdit1.Text.Equals(""))
                MessageBox.Show("Vui lòng nhập số lượng.");
            else
            {
                textEdit2.Text = (int.Parse(textEdit1.Text) * int.Parse(textEdit3.Text)).ToString();
                dichvu.ThemDichVu(idhoadon, comboBox1.SelectedValue.ToString(), textEdit1.Text, textEdit2.Text);
                gridControl1.DataSource = dichvu.Load_DichVu(idhoadon);

            }
        }

        private void QuanLiDichVu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}