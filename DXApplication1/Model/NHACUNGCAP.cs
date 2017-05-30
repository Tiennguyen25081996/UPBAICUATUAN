using DXApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Model
{
    public class NHACUNGCAP : _ModelBase
    {
        public string MaNCC { get { return GetSTR(0); } set { SetData(0, value); } }
        public string TenNCC { get { return GetSTR(1); } set { SetData(1, value); } }
        public string DiaChi { get { return GetSTR(2); } set { SetData(2, value); } }
        public string SDT { get { return GetSTR(3); } set { SetData(3, value); } }
        
        public override void Setup()
        {
            MaxFields = 4;
            ValueData = new object[MaxFields];
        }

        public override Type GetDataType()
        {
            return this.GetType();
        }
    }
}
