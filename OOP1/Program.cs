using OOP1;

using System.Text;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "nước mắm";
Console.OutputEncoding = Encoding.UTF8;
//c1.PrintInfor;
//Employee emp1.id = 1;
//Employee emp1. = 1;
// để thay đổi giá trị của thược tính

Employee emp1 = new Employee();
emp1.Id = 1;
emp1.Name = "tèo";
emp1.Email = "t@gmail.com";
emp1.Phome = "113";
// để lấy giá trị thuộc tính 
// tự gọi get trong property id
Console.WriteLine($"Employee id { emp1.Id}");
// tự gọi get trong property Name 
Console.WriteLine($"Employee Name { emp1.Name}");
//Hoặc chúng ta gọi hàm:
emp1.PrintInfor();


//Ngoài ra mọi lớp đối tượng có hàm toString() giống Java
//để tự động triệu gọi hàm này khi đối tượng được 
//xuất ra màn hình
Console.WriteLine("----------------------");
Console.WriteLine(emp1); // tự gọi tới toString()
//Vừa tạo đối tượng vừa khởi tạo giá trị cho thuộc tính:
Employee employee2 = new Employee(2,"tý đại bàng","ty@gmail.com","0981234567");
Console.WriteLine(employee2);
// vừa khởi tạo đôi tượng 
Employee emp3 = new Employee()
{
    Id = 1,
    Name = " tún",
    Email = "tun@gmail.com",
    Phome = " 094332321"
};
// xuât thong tin emp 3
Console.WriteLine(emp3);


