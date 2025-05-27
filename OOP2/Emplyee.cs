using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Emplyee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Idcard  { get; set; }

        public DateTime birthday { get; set; }
        public virtual double calSalary()
        {
            return 4000000;
        }

        public override string ToString()
        {
            return id+"\t"+Idcard+"\t" + name + "\t" + birthday.ToString("dd/MM/yyyy\t") + calSalary ;
        }
    }
}
