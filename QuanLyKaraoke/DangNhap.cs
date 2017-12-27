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
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text != "" && textEdit2.Text != "")
            {
                if (kiemtralogin(textEdit1.Text, textEdit2.Text) == 1)
                    if (textEdit1.Text.Contains("admin"))
                    {
                        Admin ad = new Admin();
                        this.Visible = false;
                        ad.ShowDialog();
                        this.Visible = true;
                        textEdit1.Text = "";
                        textEdit2.Text = "";
                    }
                    else
                    {
                        NhanVien nv = new NhanVien();
                        this.Visible = false;
                        nv.ShowDialog();
                        this.Visible = true;
                        textEdit1.Text = "";
                        textEdit2.Text = "";

                    }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc mật khẩu không chính xác");
                    textEdit1.Text = "";
                    textEdit2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
                textEdit1.Text = "";
                textEdit2.Text = "";
            }
        }
        private int kiemtralogin(String user, String pass)
        {
            BUS_DangNhap dn = new BUS_DangNhap();
            return dn.kiemtrataikhoan(user, pass);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình", "Thoát", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Dispose();
                }
                else
                    return;

        }

    }
}