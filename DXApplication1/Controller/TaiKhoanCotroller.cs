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
  public class TaiKhoanCotroller :_ControllerBase<TAIKHOAN>
    {
        public DataTable LayTK(TAIKHOAN tk)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@name",tk.TenDangNhap);
            sp[1] = new SqlParameter("@pass",tk.MatKhau);
            
            return DataAccess.ExecQuery("check_tk", sp);
        }
      
    }
}
