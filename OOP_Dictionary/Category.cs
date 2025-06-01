using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Dictionary<int, Product> Products { get; set; }

        public Category()
        {
            Products = new Dictionary<int, Product>();
        }
        // CRUD
        //thêm mới 1 sản phẩm 
        public void AddPrduct (Product p)
        {
            if (!Products.ContainsKey(p.Id))
            {
                Products.Add(p.Id, p);
            }
            
           
        }
        public void PrintAllProduct()
        {
            foreach(KeyValuePair<int , Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p);// tự động gọi hàm toString()
            }

        }
        // lấy chi tiết 1 đối tượng 
        public Product GetProduct (int id)
        {
            if (Products.ContainsKey(id) == false)
                return null;
            return Products[id];
        }

        public Dictionary<int , Product> SortProduct()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }


        public Dictionary<int , Product> ComplexSort()
        {
            return Products.OrderByDescending(item => item.Value.Quantity).OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }

        public void EditProduct(Product p)
        {
            if(Products.ContainsKey(p.Id)== false)
            {
                return;
            }
            // sửa dữ liệu tại ô nhớ có chứa P.id 
            Products[p.Id] = p;
        }

        public bool RemoveProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
            {
                return false;
            }
            else return Products.Remove(id);
        }
        // xóa tất cả sản phẩm ế trong quý 1 năm 2025
        // ế : bán chỉ dc 1 sản phẩm 
    }
}
