using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_reuse_as_library
{
    public static class MyUtils
    {
        public static int TinhTuoi (this Emplyee emp)
        {
            return DateTime.Now.Year - emp.birthday.Year + 1;
        }
    }
}
