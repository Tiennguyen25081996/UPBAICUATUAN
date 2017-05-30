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
    public class NhanVienController :_ControllerBase<NHANVIEN>
    {
        public string getTenDangNhap(string mvn)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@MaNV",mvn);
       

            DataTable dt=DataAccess.ExecQuery("select TenDangNhap from NHANVIEN where MaNV=@MaNV", sp);
             return dt.Rows[0][0].ToString();
           
        }
        public void updateTenDangNhap(string MaNV,string TenDN)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[1] = new SqlParameter("@MaNV", MaNV);
            sp[0] = new SqlParameter("@TenDangNhap", TenDN);


        DataAccess.ExecNonQuery("update NHANVIEN set TenDangNhap=@TenDangNhap where MaNV=@MaNV", sp);
            

        }
    }
}
