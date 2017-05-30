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
    class ChiTietHoaDonBanController :_ControllerBase<CHITIETHOADONBAN>
    {
        public DataTable XemCTHDB(string mahdb)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@MaHDB", mahdb);
            DataTable dt = DataAccess.ExecQuery("xem_ctpb", sp);
            return dt;
        }
        public void XoaCTHDB(string mahdb, string mahh)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@MaHDB", mahdb);
            sp[1] = new SqlParameter("@MaHH", mahh);
            DataTable dt = DataAccess.ExecQuery("xoa_ctpb", sp);

        }
    }
}
