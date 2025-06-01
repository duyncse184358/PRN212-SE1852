
using System.Text;
using OOP4_Dictionary;

Category Laptop = new Category();
Laptop.Id = 1;
Laptop.Name = "danh muc laptop ";

Product dell = new Product()
{
    Id = 1, Name = "Dell 1", Quantity = 10 , Price = 15000000
};
Laptop.AddPrduct(dell);
Product dell2 = new Product()
{
    Id = 2,
    Name = "Dell 2",
    Quantity = 30,
    Price = 17000000
};
Laptop.AddPrduct(dell2);

Product dell3 = new Product()
{
    Id = 3,
    Name = "Dell 3",
    Quantity = 40,
    Price = 2000000
};
Laptop.AddPrduct(dell3);
Product HP = new Product()
{
    Id = 4,
    Name = "HP 1",
    Quantity = 20,
    Price = 23000000
};
Laptop.AddPrduct(HP);
Product HP2 = new Product()
{
    Id = 5,
    Name = "HP 2",
    Quantity = 30,
    Price = 23000000
};
Laptop.AddPrduct(HP2);
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("================================");
Console.WriteLine("danh sách sản phẩm laptop");
Laptop.PrintAllProduct();

Console.WriteLine("nhập mã sane phẩm bạn muốn tìm :");
int id = int.Parse(Console.ReadLine());

Product p = Laptop.GetProduct(id);
if(p == null)
{
    Console.WriteLine("không tìm thấy sản phẩm");

}
else
{
    Console.WriteLine("đã tìm thấy sản phẩm = "+ id);
    Console.WriteLine(p);
}

Console.WriteLine("danh sách chưa sắp xếp");
Laptop.PrintAllProduct();

Dictionary<int, Product> sortedproduct = Laptop.SortProduct();
Console.WriteLine("danh sách đã sắp xếp");
foreach(KeyValuePair<int, Product> item in sortedproduct)
{
    Product x = item.Value;
    Console.WriteLine(x);
}


Dictionary<int, Product> sortComplex  = Laptop.ComplexSort();
Console.WriteLine("danh sách đã sắp xếp");
foreach (KeyValuePair<int, Product> item in sortComplex)
{
    Product x = item.Value;
    Console.WriteLine(x);
}
Product px = new Product();
px.Id = 1;
px.Name = "macbook 100";
px.Quantity = 80;
px.Price = 500;
Laptop.EditProduct(px);
Console.WriteLine("----danh sách sản phẩm sau khi sửa----");
Laptop.PrintAllProduct();

int p_remove_id = 1;
Laptop.RemoveProduct(p_remove_id);
Console.WriteLine("----danh sách sản phẩm sau khi xóa----");
Laptop.PrintAllProduct();