using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    public class Singleton
    {
        private static Singleton _instance;

        // Constructor is 'protected'
        private Singleton()
        {
        }

        public static Singleton getInstance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
        public TAIKHOAN taiKhoan;
    }
}
