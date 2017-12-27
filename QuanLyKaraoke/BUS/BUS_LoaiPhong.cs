using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKaraoke.SqlHelper;

namespace QuanLyKaraoke.BUS
{
    public class BUS_LoaiPhong
    {
        Helper helper = new Helper();
        public DataTable HienThiLoaiPhong()
        {
            return helper.ExcuteDataSet("LoaiPhong_HienThi").Tables[0];
        }
    }
}
