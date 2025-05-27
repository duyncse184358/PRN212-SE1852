using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        #region nhóm các thuộc tính của employee
        private int _id;
        private String _name;
        private String _email;
        private String _phone;
        #endregion

   #region nhóm contructors của employee 
        public Employee() 
        {
            
        }
     
        public Employee(int _id, String _name,String _email, String _phone)
        {
            this._id = _id;
            this._name = _name;

            Email = _email;
            Phome = _phone;
        }
        #endregion

        #region nhom profile employee
        public int Id
        {
            get { return _id; }
            set { _id = value; } 
        }
        public String Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public String Phome        {
            get { return _phone; }
            set { _phone = value; }
        }
#endregion
        public void PrintInfor()
        {
            Console.WriteLine($"{_id}\t{_name}\t{_email}\t{_phone}");
        }
        public override string ToString()
        {
            String msg = $"{_id}\t{_name}\t{_email}\t{_phone}";
            return msg;
        }
    }
}
