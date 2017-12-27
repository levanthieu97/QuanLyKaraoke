using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKaraoke.SqlHelper;
using QuanLyKaraoke.Object;
using System.Data.SqlClient;
namespace QuanLyKaraoke.BUS
{
    public class BUS_DichVu
    {
        Helper helper = new Helper();
        public DataTable HienThiDichVu()
        {
            return helper.ExcuteDataSet("DichVu_HienThi").Tables[0];
        }
        public bool InsertDichVu(BangDichVu bdv)
        {
            bool b = false;
            try
            {
                SqlParameter[] Param = new SqlParameter[] {
                new SqlParameter("TenSanPham",bdv.TenSanPham),
                new SqlParameter("SoLuong",bdv.SoLuong),
                new SqlParameter("Gia",bdv.Gia) };
                b = helper.ExcuteNonQuery("DichVu_Insert", Param) > 0;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
            return b;
        }
        public bool UpdateDichVu(BangDichVu bdv)
        {
            bool b = false;
            try
            {
                SqlParameter[] Params = new SqlParameter[]
                {
                new SqlParameter("IDSanPham",bdv.IDSanPham),
                new SqlParameter("TenSanPham",bdv.TenSanPham),
                new SqlParameter("SoLuong",bdv.SoLuong),
                new SqlParameter("Gia",bdv.Gia) };
                b = helper.ExcuteNonQuery("DichVu_Update", Params) > 0;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
            return b;
        }
        public bool DeleteDichVu(int IDSanPham)
        {
            bool b = false;
            try
            {
                b = helper.ExcuteNonQuery("DichVu_Delete", new SqlParameter("IDSanPham", IDSanPham)) > 0;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
            return b;
        }
        public DataTable LoadDanhSachDichVu()
        {
            return helper.ExcuteDataSet("[LoadDanhSachDichVu]").Tables[0];
        }

        public string getGiaTien(string tensanpham)
        {
            SqlParameter Param = new SqlParameter("@tensanpham", tensanpham);
            return helper.ExecuteScalar("[getGiaTien]", Param);
        }

        public int ThemDichVu(string IDHoaDon, string tensanpham, string soluong, string giatien)
        {
            SqlParameter[] Param = new SqlParameter[]
           {
                new SqlParameter("IDHoaDon",IDHoaDon),
                new SqlParameter("TenSanPham",tensanpham),
                new SqlParameter("SoLuong",soluong),
                new SqlParameter("ThanhTien",giatien)
           };

            return helper.ExcuteNonQuery("ThemDichVu", Param);
        }
        public DataTable Load_DichVu(string idhoadon)
        {
            SqlParameter[] Params = new SqlParameter[]
                {             
                new SqlParameter("IDHoaDon",idhoadon),
             };
            return helper.ExcuteDataSet("Load_DichVu", Params).Tables[0];
        }
        public DataTable LoadChiTietDichVu(string IDHoaDon)
        {
            SqlParameter[] Param = new SqlParameter[]
            {
                new SqlParameter("IDHoaDon",IDHoaDon),
            };

            return helper.ExcuteDataSet("LoadChiTietDichVu").Tables[0];
        }

        public string Load_ThanhTien(string IDHoaDon)
        {
            SqlParameter[] Param = new SqlParameter[]
            {
                new SqlParameter("IDHoaDon",IDHoaDon),
            };

            return helper.ExecuteScalar("GetThanhTien",Param);
        }
    }
}
