using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_QLBH.DAL
{
    class DAL_nhanvien
    {

        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public int ThemNV(string manv, string tennv, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, string chucvu)
        {

            string sql = "Insert into NHANVIEN values(N'" + manv + "',N'" + tennv + "',N'" + gioitinh + "',N'" + ngaysinh.ToString() + "',N'" + diachi + "',N'" + sdt + "',N'" + email + "',N'" + chucvu + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        public int suanv(string manv, string hoten, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, string chucvu)
        {
            string sql = "Update NHANVIEN set HoTen =N'" + hoten + "',GioiTinh =N'" + gioitinh + "',NgaySinh =N'" + ngaysinh.ToString() + "',DiaCHI =N'" + diachi + "',SDT =N'" + sdt + "',email =N'" + email + "',ChucVu =N'" + chucvu + "'where MaNV = '" + manv + "'";
            return lopchung.ThemSuaXoa(sql);
        }
        public int xoanv(string manv)
        {
            string sql = "Delete NHANVIEN where MaNV = N'" + manv + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable loadnv()
        {
            string sql = "Select * from NHANVIEN";
            return lopchung.LoadDuLieu(sql);
        }
       
    }
}