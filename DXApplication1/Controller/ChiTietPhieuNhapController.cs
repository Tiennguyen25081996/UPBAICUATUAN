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
    class ChiTietPhieuNhapController : _ControllerBase<CHITIETPHIEUNHAP>
    {
        public DataTable XemCTPN(string mapn)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@MaPN", mapn);
            DataTable dt = DataAccess.ExecQuery("xem_ctpn", sp);
            return dt;
        }
        public void XoaCTPN(string mapn,string mahh)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@MaPN", mapn);
            sp[1] = new SqlParameter("@MaHH", mahh);
            DataTable dt = DataAccess.ExecQuery("xoa_ctpn", sp);
            
        }
    }
}
