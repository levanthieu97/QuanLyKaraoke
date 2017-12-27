using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyKaraoke.SqlHelper;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace QuanLyKaraoke.BUS
{
    public class BUS_DatPhong
    {
        Helper help = new Helper();
        public int DatPhong(string phong, DateTime giodat, DateTime ngaydat)
        {
            SqlParameter[] Param = new SqlParameter[]
           {
               new SqlParameter("IDPhongHat",phong),
               new SqlParameter("Thoigianvao",giodat),
               new SqlParameter("NgayDat",ngaydat)
           };

            return help.ExcuteNonQuery("DatPhongHat", Param);
        }

        public int TaoHoaDon(string phong, DateTime giodat)
        {
            SqlParameter[] Param = new SqlParameter[]
           {
               new SqlParameter("IDPhongHat",phong),
               new SqlParameter("Thoigianvao",giodat),
           };

            return help.ExcuteNonQuery("TaoHoaDon", Param);
        }
        public DataTable LoadDanhSachPhong()
        {
            return help.ExcuteDataSet("Load_DatPhong").Tables[0];
        }
        public DataTable LoadDanhSachPhongTrong()
        {
            return help.ExcuteDataSet("[LoadDanhSachPhongTrong]").Tables[0];
        }
        public int DoiPhong(string phongdoi, string phong)
        {
            SqlParameter[] Params = new SqlParameter[]
                {
                new SqlParameter("IDPhong",phong),
                new SqlParameter("IDPhongDoi",phongdoi),
             };
            MessageBox.Show(phong);
            MessageBox.Show(phongdoi);
            return help.ExcuteNonQuery("DoiPhong", Params);
        }
        public string getIDHoaDon(string IDPhongHat)
        {
            SqlParameter Param = new SqlParameter("@IDPhongHat", IDPhongHat);
            return help.ExecuteScalar("[getIDHoaDon]", Param);
        }

        public string GetGiaPhong(string IDPhongHat)
        {
            SqlParameter Param = new SqlParameter("@IDPhongHat", IDPhongHat);
            return help.ExecuteScalar("[GetGiaPhong]", Param);
        }
        public int ThanhToan(string tiengio, string tiendichvu, string tongtien,string gioketthuc, string idphong)
        {
            SqlParameter[] Param = new SqlParameter[]
           {
               new SqlParameter("TienGio",tiengio),
               new SqlParameter("TienDichVu",tiendichvu),
               new SqlParameter("TongTien",tongtien),
               new SqlParameter("GioKetThuc",gioketthuc),
               new SqlParameter("idphong",idphong)
           };

            return help.ExcuteNonQuery("ThanhToan", Param);
        }
    }
}
