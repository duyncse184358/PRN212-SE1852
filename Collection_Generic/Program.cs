/*
 * n úng dụng generic để quan lí nhân viên ,thực hiện các thao tác CRUD 
các thao tác CRUD
 * C- Create -> Thêm mới
 * R- Read (Retrieve) --> truy vấn: Xem, sắp xếp, lọc...
 * U- Update -> Chỉnh sửa dữ liệu
 * D- Delete -> Xóa dữ liệu
 */

// câu 1 : tạo 5 nhân viên  , 4 fulltime , 1 part .

using OOP1;
using OOP2;
using System.Text;

List<Emplyee> employees = new List<Emplyee>();
FullTimeEmployee f1 = new FullTimeEmployee()
{
    id = 1,
    name = "Name 1 ",
    Idcard = "123",
    birthday = new DateTime(1980, 1, 1)
};
employees.Add(f1);


FullTimeEmployee f2 = new FullTimeEmployee()
{
    id = 2,
    name = "Name 2 ",
    Idcard = "456",
    birthday = new DateTime(1982, 12, 13)
};
employees.Add(f2);

FullTimeEmployee f3 = new FullTimeEmployee()
{
    id = 3,
    name = "Name 3 ",
    Idcard = "789",
    birthday = new DateTime(1990, 11, 21)
};
employees.Add(f3);

FullTimeEmployee f4 = new FullTimeEmployee()
{
    id = 4,
    name = "Name 4 ",
    Idcard = "321",
    birthday = new DateTime(1993, 9, 27)

};
employees.Add(f4);


PartTimeEmployee f5 = new PartTimeEmployee()
{
    id = 5,
    name = "Name 5 ",
    Idcard = "789",
    WorkHour = 3,
    birthday = new DateTime(1995, 2, 2)
};
employees.Add(f5);



// cau 2  xuất toàn bộ thông tin nhân sự
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("thông tin nhân sự :");
//cách 1  dùng expresssion body to ( lamda  expression
employees.ForEach(e => Console.WriteLine(e));
// cach 2 dung for thông thương 
Console.WriteLine("------Cách for thông thường------");
foreach (var e in employees)
{
    Console.WriteLine(e);
}



// câu 3 sắp xếp nhân viên theo năm sinh tăng dần 

for (int i = 0; i < employees.Count; i++)
{
    for (int j = i+1; j < employees.Count; j++)
    {
        Emplyee ei = employees[i];
        Emplyee ej = employees[j];
        if ( ei.birthday < ej.birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }
    }


    // câu 4 update 

    for (int j = 0; j < employees.Count; j++)
    {
        if (employees[j].id == 3)
        {
            employees[j].name =  "Updated Name" ;
            break;
        }
    }

    foreach (var e in employees)
    {
        Console.WriteLine(e);
    }
   

    // câu 5 delete

    for(int a = 0;a < employees.Count; a++)
    {
        if (employees[a].id == 3)
        {
            employees.Remove(employees[a]);
        }
    }
}



