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
    class HangHoaController :_ControllerBase<HANGHOA>
    {
        public DataTable LayDonGia(string ma)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@MaHH", ma);
          

            return DataAccess.ExecQuery("HANGHOA_LayDonGia", sp);
        }
        public DataTable LayDonGiaBan(string ma)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@MaHH", ma);
            return DataAccess.ExecQuery("HANGHOA_LayDonGiaBan", sp);
        }
    }
}
