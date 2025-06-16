using System.Security.Cryptography.X509Certificates;
using System.Text;
using LucyDemoLINQ2SQL;

Console.OutputEncoding = Encoding.UTF8;
String connectionString = "server=LAPTOP-CMSU7LK1;database=Lucy_SalesData;uid=sa;pwd=12345";

// câu 1 xuất danh sách khách hàng 

Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
/*
var ds1 = from c in context.Customers
          where c.Orders.Count() > 0
          select c;

Console.WriteLine("Danh sach khach hang co mua hang:");
foreach (var c in ds1)
{
    Console.WriteLine(c.CustomerID + "\t" + c.CompanyName);
}
*/
// câu 2   tìm 3 khác hàng có giá trị mua hàng cao nhất

/*var ds2 = from c in context.Order_Details
          join o in context.Orders on c.OrderID equals o.OrderID
          join cu in context.Customers on o.CustomerID equals cu.CustomerID
          group c by cu into g
          orderby g.Sum(x => x.UnitPrice * x.Quantity) descending
          select g.Take(3);*/


var ds2 = (from c in context.Customers
         join o in context.Orders on c.CustomerID equals o.CustomerID
         join od in context.Order_Details on o.OrderID equals od.OrderID
         group od by new { c.CustomerID, c.ContactName } into g
         select new
         {
             CustomerID = g.Key.CustomerID,
             ContactName = g.Key.ContactName,
             TotalAmount = g.Sum(x => x.UnitPrice * x.Quantity)
         }).OrderByDescending(x => x.TotalAmount)
             .Take(3);

foreach (var item in ds2)
{
    Console.WriteLine(item.CustomerID + "\t" + item.ContactName + "\t" + item.TotalAmount);
}