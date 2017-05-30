using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NhaCungCapModel
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
      
        public NhaCungCapModel(string ma, string ten, string sdt, string dc)
        {
            MaNCC = ma;
            TenNCC = ten;
            SDT = sdt;
            DiaChi = dc;
          
        }
        public NhaCungCapModel() { }
    }
}
