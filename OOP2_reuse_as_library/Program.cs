using OOP2;
using OOP2_reuse_as_library;

FullTimeEmployee e1 = new FullTimeEmployee();
e1.id = 1;
e1.name = "Tèo";
e1.birthday = new DateTime(1960, 1, 1);
Console.WriteLine("----Thông tin E1----");
Console.WriteLine(e1);
Console.WriteLine("AGE===> " + e1.TinhTuoi());