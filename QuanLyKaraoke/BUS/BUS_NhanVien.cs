using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKaraoke.SqlHelper;
using System.Data.SqlClient;
using System.Data;
using QuanLyKaraoke.Object;

namespace QuanLyKaraoke.BUS
{
    public class BUS_NhanVien
    {
        Helper helper = new Helper();
        public DataTable HienThiNhanVien()
        {
            return helper.ExcuteDataSet("NhanSu_Hienthi").Tables[0];
        }
        public bool InsertNhanVien(LopNhanVien nv)
        {
            bool b = false;
            try
            {
                SqlParameter[] Param = new SqlParameter[] {
                new SqlParameter("TenNhanVien",nv.TenNhanVien),
                new SqlParameter("GioiTinh",nv.GioiTinh),
                new SqlParameter("SoDienThoai",nv.SoDienThoai),
                new SqlParameter("DiaChi", nv.DiaChi) };
                b = helper.ExcuteNonQuery("NhanSu_Insert", Param) > 0;
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            }catch(Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
            return b;
        }
        public bool UpdateNhanVien(LopNhanVien nv)
        {
            bool b = false;
            try
            {
                SqlParameter[] Params = new SqlParameter[]
                {
                new SqlParameter("ID",nv.ID),
                new SqlParameter("TenNhanVien",nv.TenNhanVien),
                new SqlParameter("GioiTinh",nv.GioiTinh),
                new SqlParameter("SoDienThoai",nv.SoDienThoai),
                new SqlParameter("DiaChi", nv.DiaChi) };
                b = helper.ExcuteNonQuery("NhanSu_Update", Params) > 0;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch(Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
            return b;
        }
        public bool DeleteNhanVien(int ID)
        {
            bool b = false;
            try
            {
                b = helper.ExcuteNonQuery("NhanSu_Delete", new SqlParameter("ID", ID)) > 0;
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            }catch(Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
            return b;
        }
    }
}

