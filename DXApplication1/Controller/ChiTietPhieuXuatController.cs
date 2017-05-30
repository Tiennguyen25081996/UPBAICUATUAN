
using DXApplication1.DAL;
using DXApplication1.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Controller
{
    class ChiTietPhieuXuatController :_ControllerBase<CHITIETPHIEUXUAT>
    {
        public DataTable XemCTPX(string mapx)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@MaPX", mapx);
            DataTable dt = DataAccess.ExecQuery("xem_CHITIETPHIEUXUAT", sp);
            return dt;
        }
        public void XoaCTPX(string mapn, string mahh)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@MaPX", mapn);
            sp[1] = new SqlParameter("@MaHH", mahh);
            DataTable dt = DataAccess.ExecQuery("CHITIETPHIEUXUAT_xoa", sp);

        }
    }
}
