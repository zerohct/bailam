using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLBH.BLL
{
    class BLL_dangnhap
    {
        DAL.DAL_taikhoan DAL_tk = new DAL.DAL_taikhoan();
        GUI.frm_taikhoan frm_tk;
        GUI.frm_dangnhap frm_dn;

        public BLL_dangnhap(GUI.frm_dangnhap f)
        {
            frm_dn = f;
        }

        public void LayDSNV()
        {
            frm_dn.cb_tendn.DataSource = DAL_tk.loadtk();
            frm_dn.cb_tendn.DisplayMember = "TenDangNhap";
            frm_dn.cb_tendn.ValueMember = "TenDangNhap";
        }
    }
}
