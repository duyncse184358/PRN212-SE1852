using System.ComponentModel.DataAnnotations;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
 * Dùng LÌNQ2Object để xuất các số chẵn trong danh sách 
 */

int[] arr = { 100, 35, 80, 17, 22, 40, 70, 33, 18 };

var Even_List = arr.Where(x => x % 2 == 0);
Console.WriteLine("dánh sách các số chẵn theo method syntax:");
foreach (var x in Even_List) 
Console.Write(x + "\t");

// cách 2 Quẻu syntax (cú pháp tương tự SQL)

var even_list2 = from x in arr
                 where x % 2 == 0
                 select x;
Console.WriteLine("\ndánh sách các số chẵn theo Query syntax:");
foreach (var x in even_list2) 
Console.Write(x + "\t");

// sắp xếp mang tăng x dần và giảm dần  dùng method àd query syntax 
// dùng method

var List_asc = arr.OrderBy(x => x);

// dùng query 

var List_asc2 = from x in arr
                orderby x
                select x;
var List_Dsc2 = from x in arr
                orderby x descending
                select x;

 
