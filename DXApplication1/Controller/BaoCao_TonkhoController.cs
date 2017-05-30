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
    class BaoCao_TonkhoController

    {
       
        public BaoCao_TonkhoController()
        {

            DataAccess.con = new SqlConnection("server=DESKTOP-4EVF50T\\SQLEXPRESS;database=QuanLyBanHang_lenh;integrated security=SSPI");
        }

        public DataTable LayDSKho()
        {
            return DataAccess.ExecQuery("select MaKho,TenKho from KHO");
        }
        public DataTable LayDSNhom(string makho)
        {
            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@MaKho", SqlDbType.Char, 10);

            sp[0].Value = makho;

            return DataAccess.ExecQuery("NHOMHANG_GetDataById", sp);
        }
        public DataTable LayDSTonKho(string Ngay,string MaKho,string MaNhom )
        {
            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@date", SqlDbType.DateTime, 10);
            sp[1] = new SqlParameter("@makho", SqlDbType.Char, 10);
            sp[2] = new SqlParameter("@manhom", SqlDbType.Char, 10);

            sp[0].Value = Ngay;
            sp[1].Value =MaKho;
            sp[2].Value = MaNhom;
            return DataAccess.ExecQuery("tk_kho2", sp);
        }
        public DataTable LayDSTonKhoTatCa(string Ngay)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@date", SqlDbType.DateTime, 10);


            sp[0].Value = Ngay;

            return DataAccess.ExecQuery("tk_tonkho1", sp);
        }
        //
        //Phần biểu đồ
        public DataTable LayBDTonKho(string Ngay, string MaKho, string MaNhom)
        {
            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@date", SqlDbType.DateTime, 10);
            sp[1] = new SqlParameter("@makho", SqlDbType.Char, 10);
            sp[2] = new SqlParameter("@manhom", SqlDbType.Char, 10);

            sp[0].Value = Ngay;
            sp[1].Value = MaKho;
            sp[2].Value = MaNhom;
            return DataAccess.ExecQuery("BieuDo_TonKho", sp);
        }
        public DataTable LayBDTonKhoTatCa(string Ngay)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@date", SqlDbType.DateTime, 10);


            sp[0].Value = Ngay;

            return DataAccess.ExecQuery("BieuDo_TonKhoTatca", sp);
        }
    }
}
