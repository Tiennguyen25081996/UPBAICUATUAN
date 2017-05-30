using DXApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NHANVIEN :_ModelBase
    {
        public string MaNV { get { return GetSTR(0); } set { SetData(0, value); } }
        public string TenNV { get { return GetSTR(1); } set { SetData(1, value); } }
        public string GioiTinh { get { return GetSTR(2); } set { SetData(2, value); } }
        public string DiaChi { get { return GetSTR(3); } set { SetData(3, value); } }
        public string NgaySinh { get { return GetSTR(4); } set { SetData(4, value); } }
        public string Luong { get { return GetSTR(5); } set { SetData(5, value); } }
        public string TenDangNhap { get { return GetSTR(6); } set { SetData(6, value); } }
        public override void Setup()
        {
            MaxFields = 7;
            ValueData = new object[MaxFields];
        }

        public override Type GetDataType()
        {
            return this.GetType();
        }

    }
}
