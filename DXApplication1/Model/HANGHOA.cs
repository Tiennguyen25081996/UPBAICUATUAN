using DXApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HANGHOA :_ModelBase
    {
        public string MaHH { get { return GetSTR(0); } set { SetData(0, value); } }
        public string TenHH { get { return GetSTR(1); } set { SetData(1, value); } }
        public string NoiSX { get { return GetSTR(2); } set { SetData(2, value); } }
        public string DonVi { get { return GetSTR(3); } set { SetData(3, value); } }
        public string DonGia { get { return GetSTR(4); } set { SetData(4, value); } }
        public string MaNCC { get { return GetSTR(5); } set { SetData(5, value); } }
        public string MaNhom { get { return GetSTR(6); } set { SetData(6, value); } }
        public string DonGiaBan { get { return GetSTR(7); } set { SetData(7, value); } }



        public HANGHOA(string ma, string ten, string noisx, string dv, string mancc, string manhom,string dg)
        {
            MaHH = ma;
            TenHH = ten;
            NoiSX = noisx;
            DonVi = dv;
            MaNCC = mancc;
            MaNhom = manhom;
            DonGia = dg;
        }
        public HANGHOA() { }
        public override void Setup()
        {
            MaxFields = 8;
            ValueData = new object[MaxFields];
        }

        public override Type GetDataType()
        {
            return this.GetType();
        }
    }
}
