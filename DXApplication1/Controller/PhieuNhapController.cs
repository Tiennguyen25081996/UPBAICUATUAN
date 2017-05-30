using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DXApplication1.DAL;
using System.Data;

namespace DXApplication1.Controller
{
    class PhieuNhapController:_ControllerBase<PHIEUNHAP>
    {
        public void ThemPN(PHIEUNHAP hdn)
        {

            SqlParameter[] sp = new SqlParameter[2];
            //sp[0] = new SqlParameter("@mahdn", SqlDbType.Char, 10);
            sp[0] = new SqlParameter("@ngay", SqlDbType.DateTime);
            sp[1] = new SqlParameter("@manv", SqlDbType.Char, 10);

            //  sp[0].Value = hdn.MaHDN;
            sp[0].Value = hdn.NgayNhap;
            sp[1].Value = hdn.MaNV;


            DataAccess.ExecNonQuery("them_hdn", sp);
        }
        public void SuaPN(PHIEUNHAP hdn)
        {
            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@mahd", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@ngay", SqlDbType.DateTime);
            sp[2] = new SqlParameter("@manv", SqlDbType.Char, 10);

            sp[0].Value = hdn.MaPN;
            sp[1].Value = hdn.NgayNhap;
            sp[2].Value = hdn.MaNV;

            DataAccess.ExecNonQuery("sua_hdn", sp);

        }
        public void XoaPN(string ma)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@ma", SqlDbType.Char, 10);

            sp[0].Value = ma;
            DataAccess.ExecNonQuery("xoa_hdn", sp);
        }
    }
}
