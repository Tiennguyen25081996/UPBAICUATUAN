using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Model
{
    public class TonKhoModel
    {
        public string MaKho { get; set; }
        public string MaNhom { get; set; }
        public string Ngay { get; set; }
       
        public TonKhoModel (string mk,string mn,string n)
        {
            MaKho = mk;
            MaNhom = mn;
            Ngay = n;
        }
        public TonKhoModel( string n)
        {
           
            Ngay = n;
        }
        public TonKhoModel() { }
    }
}
