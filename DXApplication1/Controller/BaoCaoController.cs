
using DXApplication1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Controller
{
    class BaoCaoController 

    {
        public BaoCaoController()
        {
            DataAccess.con= new SqlConnection("server=DESKTOP-4EVF50T\\SQLEXPRESS;database=QuanLyBanHang_lenh;integrated security=SSPI");

        }
        public DataTable LayDSHangDaBan(string date1, string date2)
        {

            DataAccess.con.Open();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@date1", SqlDbType.DateTime, 10);
            sp[1] = new SqlParameter("@date2", SqlDbType.DateTime, 10);

            sp[0].Value = date1;
            sp[1].Value = date2;

            return DataAccess.ExecQuery("BaoCao_HangBan", sp);
        }
        public DataTable BieuDoSPBanChay(string date1,string date2 )
        {

            DataAccess.con.Open();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@date1", SqlDbType.DateTime, 10);
            sp[1] = new SqlParameter("@date2", SqlDbType.DateTime, 10);

            sp[0].Value = date1;
            sp[1].Value = date2;

            return DataAccess.ExecQuery("BieuDo_HangBan_Soluong", sp);
        }
        public DataTable BieuDoSPDoanhThu(string date1, string date2)
        {

            DataAccess.con.Open();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@date1", SqlDbType.DateTime, 10);
            sp[1] = new SqlParameter("@date2", SqlDbType.DateTime, 10);

            sp[0].Value = date1;
            sp[1].Value = date2;

            return DataAccess.ExecQuery("BieuDo_HangBan_DoanhThu", sp);
        }
        //Phần nhập
        public DataTable LayDSHangNhap(string date1, string date2)
        {

            DataAccess.con.Open();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@date1", SqlDbType.DateTime, 10);
            sp[1] = new SqlParameter("@date2", SqlDbType.DateTime, 10);

            sp[0].Value = date1;
            sp[1].Value = date2;

            return DataAccess.ExecQuery("BaoCao_HangNhap", sp);
        }
        public DataTable BieuDoSPNhap_Soluong(string date1, string date2)
        {

            DataAccess.con.Open();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@date1", SqlDbType.DateTime, 10);
            sp[1] = new SqlParameter("@date2", SqlDbType.DateTime, 10);

            sp[0].Value = date1;
            sp[1].Value = date2;

            return DataAccess.ExecQuery("BieuDo_HangNhap_Soluong", sp);
        }
        public DataTable BieuDoSPNhap_Doanhthu(string date1, string date2)
        {

            DataAccess.con.Open();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@date1", SqlDbType.DateTime, 10);
            sp[1] = new SqlParameter("@date2", SqlDbType.DateTime, 10);

            sp[0].Value = date1;
            sp[1].Value = date2;

            return DataAccess.ExecQuery("BieuDo_HangNhap_DoanhThu", sp);
        }




    }
}
