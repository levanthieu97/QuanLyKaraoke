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
using System.Data.SqlClient;
using QuanLyKaraoke.BUS;

namespace QuanLyKaraoke
{
    public partial class QuanLyDatPhong : DevExpress.XtraEditors.XtraForm
    {
        BUS_DatPhong datphong = new BUS_DatPhong();
        public QuanLyDatPhong()
        {

            InitializeComponent();
            gridControl1.DataSource = datphong.LoadDanhSachPhong();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void QuanLyDatPhong_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            datphong.DatPhong(comboBox1.SelectedValue.ToString(), DateTime.Parse(textEdit1.Text), DateTime.Parse(textEdit2.Text));
            gridControl1.DataSource = datphong.LoadDanhSachPhong();
            Console.WriteLine(DateTime.Parse(textEdit1.Text));
            datphong.TaoHoaDon(comboBox1.SelectedValue.ToString(), DateTime.Parse(textEdit1.Text));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            comboBox1.DataSource = datphong.LoadDanhSachPhongTrong();
            comboBox1.DisplayMember = "IDPhongHat";
            comboBox1.ValueMember = "IDPhongHat";
            textEdit2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textEdit1.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void đổiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiPhong dp = new DoiPhong(gridView1.GetFocusedRowCellValue("IDPhongHat").ToString());
            dp.ShowDialog();
            
        }

        private void thêmDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLiDichVu formdichvu = new QuanLiDichVu(datphong.getIDHoaDon(gridView1.GetFocusedRowCellValue("IDPhongHat").ToString()));
            this.Visible = false;
            formdichvu.ShowDialog();
            this.Visible = true;

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void tínhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gio = gridView1.GetFocusedRowCellDisplayText("ThoiGianVao").ToString();
            DateTime giodat = DateTime.Parse(gio);
            string ngay = gridView1.GetFocusedRowCellDisplayText("NgayDat").ToString();
            DateTime ngaydat = DateTime.Parse(ngay);
            HoaDon f = new HoaDon(datphong.getIDHoaDon(gridView1.GetFocusedRowCellValue("IDPhongHat").ToString()), gridView1.GetFocusedRowCellValue("IDPhongHat").ToString(),ngaydat,giodat,DateTime.Now);
            f.ShowDialog();

        }
    }
}   