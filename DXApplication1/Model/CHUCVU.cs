using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Model
{
    class CHUCVU:_ModelBase
    {
        public string MaCV { get { return GetSTR(0); } set { SetData(0, value); } }
        public string TenCV { get { return GetSTR(1); } set { SetData(1, value); } }
        public override void Setup()
        {
            MaxFields = 2;
            ValueData = new object[MaxFields];
        }

        public override Type GetDataType()
        {
            return this.GetType();
        }
    }
}
