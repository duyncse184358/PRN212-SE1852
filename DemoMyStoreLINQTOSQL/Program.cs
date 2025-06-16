using System.Net.Http.Headers;
using System.Text;
using DemoMyStoreLINQTOSQL;

Console.OutputEncoding = Encoding.UTF8;
String connectionString = "server=LAPTOP-CMSU7LK1;database=MyStore;uid=sa;pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
// câu 1 Dùng linnq2 sql  dể lấy toàn bộ categories
var categories = context.Categories;
foreach ( var cate in categories)
{
    Console.WriteLine(cate.CategoryID + "\t" + cate.CategoryName);
}

// câu 2 tim chi tiết d anh mục khi biết id 

int cateid = 5;
Category category = context.Categories.FirstOrDefault(c => c.CategoryID == cateid);
if(category == null)
{
    Console.WriteLine($"không tìm thấy danh mục có mã = {cateid}");

}
else
{
    Console.WriteLine($" tìm thấy danh mục có mã = {cateid}, chi tiết ");
    Console.WriteLine(category.CategoryID + "\t" + category.CategoryName);
}

/*// câu 3 them mới 1 danh mục 
Category cnew = new Category();
*//*cnew.CategoryName = "hách nôi";
context.Categories.InsertOnSubmit(cnew);
context.SubmitChanges();*/


// thêm mới nhiều danh mục 1 luc 
/*List<Category> dsdm_new = new List<Category>();
dsdm_new.Add(new Category() { CategoryName = "latop " });
dsdm_new.Add(new Category() { CategoryName = "TV " });
dsdm_new.Add(new Category() { CategoryName = "phụ kiện " });
context.Categories.InsertAllOnSubmit(dsdm_new);
context.SubmitChanges();*/


// câu 5 sửa tên danh mục 
// nguyên tắc : phải tím thấy mới sửa

/*Category c = from x in context.Categories
             where x.CategoryID == 10
             select x).FirstOrDefault();

Category c2 = context.Categories.FirstOrDefault(x => x.CategoryID == 10);
if(c2 != null)
{
    c2.CategoryName = "hôi nách";
    context.SubmitChanges();
}
*/
// câu 6  xóa danh mục 
// tìm thấy rồi mới xóa 
Category c3 = context.Categories.FirstOrDefault(x => x.CategoryID == 10);
if (c3 != null)
{
    context.Categories.DeleteOnSubmit(c3);
    context.SubmitChanges();
}

// câu 7  xóa tât cả danh mục mà không chứa bất kỳ sản phẩm nào 

var c4 = context.Categories.Where(c => c.Products.Count == 0).ToList;
context.Categories.DeleteAllOnSubmit<Category>(c4());
context.SubmitChanges();




