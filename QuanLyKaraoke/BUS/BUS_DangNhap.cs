using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyKaraoke.SqlHelper;

namespace QuanLyKaraoke.BUS
{
    public class BUS_DangNhap
    {
        Helper help = new Helper();
        public int kiemtrataikhoan(String user, String pass)
        {
            SqlParameter[] Param = new SqlParameter[]
           {

               new SqlParameter("@username",user),
               new SqlParameter("@password",pass)
           };
            if (help.ExecuteScalar("KiemTraDangNhap", Param).Equals("1")) return 1; return 0;
        }
    }
}
