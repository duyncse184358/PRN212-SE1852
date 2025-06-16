using System.Text;
using DEmoLINQtoObject2;

Console.OutputEncoding = Encoding.UTF8;

ListProduct lp = new ListProduct();
// giả lập dữ liệu 

lp.gen_sample_product();

Console.WriteLine("danh sách product");

lp.PrintProduct();


Console.WriteLine("danh sách product có gía từ 80 tới 100 ");
lp.FilterProductPrice(80, 100);
Console.WriteLine("danh sách product  giảm dần có gía từ 80 tới 100  ");
lp.FilterProductByPriceDSC(80 ,100);