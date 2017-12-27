using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKaraoke.BUS;
using System.Data;
using QuanLyKaraoke.Object;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        BUS_DangNhap testDangNhap;
        BUS_DichVu testDichVu;
        [TestMethod]
        public void TestDangNhap()
        {
            testDangNhap = new BUS_DangNhap();
            //ten tai khoan voi mat khau cua m la gi ml
            int actual = testDangNhap.kiemtrataikhoan("admin", "123456");
            Assert.AreEqual(1, actual);
        }
        
        [TestMethod]
        public void TestDangNhap2()
        {
            testDangNhap = new BUS_DangNhap();
            //ten tai khoan voi mat khau cua m la gi ml
            int actual = testDangNhap.kiemtrataikhoan("admin", "tambayne");
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestHienThiDichVu()
        {
            testDichVu = new BUS_DichVu();
            DataTable dt = testDichVu.HienThiDichVu();
            bool actual;
            if(dt.Rows.Count == 0)
            {
                actual = false;
            }
            else
            {
                actual = true;
            }
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void testInsertDichVu()
        {
            testDichVu = new BUS_DichVu();
            BangDichVu bdv = new BangDichVu();
            //ku, bảng dịch vụ mới đầu có dữ liệu gì chưa
            //ku ku ku
            bdv.IDSanPham = 1;
            bool actual = testDichVu.InsertDichVu(bdv);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void testUpdateDichVu()
        {
            testDichVu = new BUS_DichVu();
            BangDichVu bdv = new BangDichVu();
            bdv.IDSanPham = 1;
            bool actual = testDichVu.UpdateDichVu(bdv);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void testDeleteDichVu()
        {
            testDichVu = new BUS_DichVu();

        }
    }
}
