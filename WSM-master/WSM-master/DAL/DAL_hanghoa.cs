using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_QLBH.DAL
{
    class DAL_hanghoa
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public int themhang(string malk,string tenlk, string thongso, string giaban, string  gianhap, string ngaynhap,string maloai,string makho,string mancc)
        {

            string sql = "Insert into LinhKien values(N'" + malk + "',N'" + tenlk + "',N'" + thongso + "',N'" + giaban + "',N'" + gianhap+ "',N'" + ngaynhap + "',N'" + maloai + "',N'" + makho + "',N'" + mancc + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        public int suahang(string malk, string tenlk, string thongso, string giaban, string gianhap, string ngaynhap, string maloai, string makho, string mancc)
        {
            string sql = "Update LinhKien set TenLK =N'" + tenlk + "',ThongSo =N'" + thongso+ "',GiaBan =N'" + giaban + "',GiaNhap =N'" + gianhap + "',NgayNhap =N'" + ngaynhap + "',MaLoai =N'" + maloai + "',MaKho =N'" + makho + "',MaNCC =N'" + mancc + "'where MaLK = '" + malk + "'";
            return lopchung.ThemSuaXoa(sql);
        }
        public int xoahang(string malk)
        {
            string sql = "Delete LinhKien where MaLK = N'" + malk + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        
        public DataTable loadhh()
        {
            string sql = "Select * from LinhKien";
            return lopchung.LoadDuLieu(sql);
        }

        public DataTable loadllk()
        {
            string sql = "Select * from LoaiLinhKien";
            return lopchung.LoadDuLieu(sql);
        }

        public DataTable loadkho()
        {
            string sql = "Select * from Kho";
            return lopchung.LoadDuLieu(sql);
        }
    }
}
