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
    public partial class HoaDon : DevExpress.XtraEditors.XtraForm
    {
        BUS_DichVu dv = new BUS_DichVu();
        BUS_DatPhong datphong = new BUS_DatPhong();
        string mahd;
        string phonghat;
        DateTime ngay;
        DateTime thoigianbatdau;
        DateTime thoigianketthuc;
        public HoaDon()
        {
            InitializeComponent();
        }
        public HoaDon(string mahd1, string phonghat1, DateTime ngay1 , DateTime thoigianbatdau1, DateTime thoigianketthuc1)
        {
            InitializeComponent();
            mahd=mahd1;
            phonghat=phonghat1;
            ngay= ngay1;
            thoigianbatdau=thoigianbatdau1;
            thoigianketthuc=thoigianketthuc1;   
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

            textEdit1.Text = mahd;
            textEdit2.Text = phonghat;
            textEdit3.Text = ngay.ToString("MM:dd:yyyy");
            textEdit4.Text = thoigianbatdau.ToString("hh:mm");
            textEdit5.Text = thoigianketthuc.ToString("hh:mm");

            //Tính số thời gian đã dùng
            DateTime tBegin = Convert.ToDateTime(textEdit4.Text);
            DateTime tEnd = Convert.ToDateTime(textEdit5.Text);
            TimeSpan ts = new TimeSpan();
             ts = (TimeSpan)(tEnd - tBegin);
            DateTime tempt = Convert.ToDateTime(ts.ToString());
            
            int sophut = tempt.Minute;
            double tongthoigian = Math.Round(tempt.Hour + ((double)sophut / 60),1);
           
            gridControl1.DataSource = dv.Load_DichVu(textEdit1.Text);
            textEdit7.Text = dv.Load_ThanhTien(textEdit1.Text);
            string giatien = datphong.GetGiaPhong(textEdit2.Text);
            double tiengio = Math.Round(tongthoigian * float.Parse(giatien),0);
            textEdit6.Text = tiengio.ToString();
            Console.WriteLine(tongthoigian);
            double thanhtien = double.Parse(textEdit7.Text) + tiengio;
            textEdit8.Text = thanhtien.ToString();


        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datphong.ThanhToan(textEdit6.Text, textEdit7.Text, textEdit8.Text,textEdit5.Text,textEdit2.Text);
            MessageBox.Show("Thanh toán thành công! Cảm ơn quý khách");
        }
    }
}