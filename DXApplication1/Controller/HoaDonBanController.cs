using DXApplication1.DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Controller
{
    class HoaDonBanController :_ControllerBase<HOADONBAN>
    {
        public void ThemHDB(HOADONBAN hdb)
        {

            SqlParameter[] sp = new SqlParameter[2];
            // sp[0] = new SqlParameter("@mahdb", SqlDbType.Char, 10);
            sp[0] = new SqlParameter("@ngay", SqlDbType.DateTime);
            sp[1] = new SqlParameter("@manv", SqlDbType.Char, 10);

            //sp[0].Value = hdb.MaHDB;
            sp[0].Value = hdb.NgayBan;
            sp[1].Value = hdb.MaNV;


            DataAccess.ExecNonQuery("them_hdb", sp);
        }
        public void SuaHDB(HOADONBAN hdb)
        {
            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@mahd", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@ngay", SqlDbType.DateTime, 50);
            sp[2] = new SqlParameter("@manv", SqlDbType.Char, 10);

            sp[0].Value = hdb.MaHDB;
            sp[1].Value = hdb.NgayBan;
            sp[2].Value = hdb.MaNV;

            DataAccess.ExecNonQuery("sua_hdb", sp);

        }
        public void XoaHDB(string hdb)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@mahd", SqlDbType.Char, 10);

            sp[0].Value = hdb;
            DataAccess.ExecNonQuery("xoa_hdb", sp);
        }
    }
}
