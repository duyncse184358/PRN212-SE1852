using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

FullTimeEmployee teo = new FullTimeEmployee();
teo.id = 1;
teo.name = "tèo";
Console.WriteLine(teo.calSalary);

PartTimeEmployee ty = new PartTimeEmployee();
ty.WorkHour = 2;
ty.name = "tý ";
ty.id = 2;
Console.WriteLine("Lương của tý = " + ty.calSalary);

FullTimeEmployee obama = new FullTimeEmployee()
{
    id = 1,
    Idcard = " 123",
    name = " barac obama ",
    birthday = new DateTime(1960 / 12 / 26)
};

PartTimeEmployee trump = new PartTimeEmployee()
{

}
