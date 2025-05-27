/*
 * n úng dụng generic để quan lí nhân viên ,thực hiện các thao tác CRUD 
 * C -
 * R 
 * U
 * D 
 * 
 * 
 */

// câu 1 : tạo 5 nhân viên  , 4 fulltime , 1 part .

using OOP2;

List<Emplyee> employee = new List<Emplyee>();

FullTimeEmployee f2 = new FullTimeEmployee();

PartTimeEmployee f3 = new PartTimeEmployee();



// cau 2  xuất toàn bộ thông tin nhân sự

//cách 1  dùng expresssion body to ( lamda  expression

// cach 2 dung for thông thương 

// câu 3 sắp xếp nhân viên theo năm sinh tăng dần 

for (int i = 0; i < employee.Count; i++)
{
    for (int j = i+1; j < employee.Count; j++)
    {
        Emplyee ei = employee[i];
        Emplyee ej = employee[j];
        if ( ei.birthday < ej.birthday)
        {
            ei
        }
    }

}



