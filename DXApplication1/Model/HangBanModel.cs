using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class HangBanModel
    {
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public HangBanModel() { }
        public HangBanModel(string n1, string n2)
        {
            NgayBatDau = n1;
            NgayKetThuc = n2;
        }
    }
}
