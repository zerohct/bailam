using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_QLBH.DAL
{
    class DAL_nhacungcap
    {

        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public int themncc(string MaNCC, string TenNCC, string DiaChi, string SDT, string email)
        {

            string sql = "Insert into NHACUNGCAP values(N'" + MaNCC + "',N'" + TenNCC + "',N'" + DiaChi + "',N'" + SDT + "',N'" + email + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        public int suancc(string MaNCC, string TenNCC, string DiaChi, string SDT, string email)
        {
            string sql = "Update NHACUNGCAP set TenNCC =N'" + TenNCC + "',DiaChi = N'" + DiaChi + "',SDT = N'" + SDT + "',email = N'" + email + "'where MaNCC = '" + MaNCC + "'";
            return lopchung.ThemSuaXoa(sql);
        }
        public int xoancc(string mancc)
        {
            string sql = "Delete NHACUNGCAP where MaNCC = N'" + mancc + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable loadncc()
        {
            string sql = "Select * from NHACUNGCAP";
            return lopchung.LoadDuLieu(sql);
        }

    }
}   
