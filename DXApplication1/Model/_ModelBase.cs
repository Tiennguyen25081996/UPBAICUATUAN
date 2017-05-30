using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Model
{
    public abstract class _ModelBase
    {
        public static List<string> FieldName = null;
        static Type T;
        public abstract Type GetDataType();
        public object[] ValueData;
        public static string IDName;
        protected int MaxFields;
        public _ModelBase()
        {
            Setup();
            
                T = GetDataType();
                FieldName = new List<string>();
                PropertyInfo[] pi = T.GetProperties();
                IDName = pi[0].Name;
                foreach (PropertyInfo p in pi)
                {
                    FieldName.Add(p.Name);
                }
            
        }
        public abstract void Setup();
        public void SetData(int pos, object val)
        {
            ValueData[pos] = val;
        }
        public int GetINT(int pos)
        {
            return (int)ValueData[pos];
        }
        public string GetSTR(int pos)
        {
            return ValueData[pos].ToString();
        }
    }
}
