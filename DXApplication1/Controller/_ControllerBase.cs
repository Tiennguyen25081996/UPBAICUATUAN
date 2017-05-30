using DXApplication1.DAL;
using DXApplication1.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Controller
{
    public class _ControllerBase<T> where T : _ModelBase, new()
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-PHFH3VR\\TIENNGUYEN1;database=QuanLyBanHang_lenh;integrated security=SSPI");
        static string QueryAll = "{0}_GetAllData";
        static string QueryDataById = "{0}_GetDataById";
        static string InsertCommand = "{0}_Them";
        static string UpdateCommand = "{0}_Sua";
        static string DeleteCommand = "{0}_Xoa";
        List<T> lstData = new List<T>();
        List<string> lstName;
        public static string TableName;
        T temp = new T();
        public int RecordPerPage { get; set; }
        public int PageToGet { get; set; }
        public _ControllerBase()
        {
             DataAccess.con = con;
            TableName = temp.GetType().Name;
            lstName = _ModelBase.FieldName;
            QueryAll = string.Format(QueryAll, TableName);
            QueryDataById = string.Format(QueryDataById, TableName);
            InsertCommand = string.Format(InsertCommand, TableName);
            UpdateCommand = string.Format(UpdateCommand, TableName);
            DeleteCommand = string.Format(DeleteCommand, TableName);
        }
        public DataTable GetAllData()
        {
            lstData.Clear();

            //con.Open();
            //SqlCommand sc = new SqlCommand(QueryAll, con);
            //sc.CommandType = CommandType.StoredProcedure;
            //SqlDataReader dr = sc.ExecuteReader();
            //while (dr.Read())
            //{
            //    T objT = new T();
            //    dr.GetValues(objT.ValueData);
            //    lstData.Add(objT);
            //}
            //con.Open();
            
            DataTable dt = DataAccess.ExecQuery(QueryAll);
            return dt;
        }
        
        public DataTable getDataById(string id,int pos)
        {

            con.Open();
            SqlParameter sp = new SqlParameter("@" +lstName[pos], id);  
            DataTable dt = DataAccess.ExecQuery(QueryDataById, sp);
            return dt;

        }
        public void Insert(T objT)
        {
            
            SqlParameter[] sp = new SqlParameter[objT.ValueData.Length];
            for (int i = 0; i < objT.ValueData.Length; i++)
            {                if (objT.ValueData[i].ToString().Contains("/"))
                    sp[i] = new SqlParameter("@" + lstName[i], SqlDbType.Date);
                else sp[i] = new SqlParameter("@" + lstName[i], SqlDbType.NVarChar);
                sp[i].Value=objT.ValueData[i];
            }
            DataAccess.ExecNonQuery(InsertCommand, sp);
        }
        public void Update(T objT)
        {

            SqlParameter[] sp = new SqlParameter[objT.ValueData.Length];
            for (int i = 0; i < objT.ValueData.Length; i++)
            {
                if (objT.ValueData[i].ToString().Contains("/"))
                    sp[i] = new SqlParameter("@" + lstName[i], SqlDbType.Date);
               
                else sp[i] = new SqlParameter("@" + lstName[i], SqlDbType.NVarChar);
                sp[i].Value = objT.ValueData[i];
            }
            DataAccess.ExecNonQuery(UpdateCommand, sp);
        }
        public void Delete(string id)
        {

            SqlParameter sp = new SqlParameter("@"+lstName[0],id);
          
            DataAccess.ExecNonQuery(DeleteCommand, sp);
        }
        public void Hien()
        {
            foreach (T objT in lstData)
            {
                PropertyInfo[] pi = objT.GetType().GetProperties();
                string str = "";
                foreach (PropertyInfo p in pi)
                {
                    str += p.GetValue(objT, null).ToString() + " -- ";
                }
                Console.WriteLine(str);
            }
        }
    }
}
