using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLBH.DAL
{
    class DAL_taikhoan
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public int themtk(string TenDangNhap, string MatKhau, string MaNV)
        {

            string sql = "Insert into DangNhap values(N'" + TenDangNhap + "',N'" + MatKhau + "',N'" + MaNV + "')";
            return lopchung.ThemSuaXoa(sql);
        }

        public int suatk(string TenDangNhap, string MatKhau, string MaNV)
        {
            string sql = "Update DangNhap set TenDangNhap =N'" + TenDangNhap + "',MatKhau =N'" + MatKhau + "',MaNV =N'" + MaNV +"'";
            return lopchung.ThemSuaXoa(sql);
        }

        public int xoatk(string TenDangNhap)
        {
            string sql = "Delete DangNhap where TenDangNhap = N'" + TenDangNhap + "'";
            return lopchung.ThemSuaXoa(sql);

        }

        public DataTable loadtk()
        {
            string sql = "Select * from DangNhap";
            return lopchung.LoadDuLieu(sql);
        }
    }
}
