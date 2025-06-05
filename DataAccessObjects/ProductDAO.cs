using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> listProducts;

        public ProductDAO()
        {
            Product chai = new Product(1, "Chai",3,12,18);
            Product chang = new Product(2, "Chang", 1,23, 19);
            Product anissed = new Product(3, "Aniseed", 2, 23, 10);
            listProducts = new List<Product> { chai, chang, anissed };
        }

        public List<Product> GetProducts()
        {
            return listProducts;
        }
        public static List<Product> GetProducts()
        {
            var listProducts = new List<Product>();
            try
            {
                using var db = new MyStoreContext();
                listProducts = db.Products.Tolist();
                
            } catch (Exception e)
            {
            }
            return listProducts;
        }

        public  static void SaveProduct(Product p)
        {
            listProducts.Add(p);
        }

        public static void UpdateProduct (Product product)
        {
            foreach(Product p in listProducts.ToList())
            {
                if(p.ProductiId == product.ProductiId)
                {
                    p.ProductiId = product.ProductiId;
                    p.ProductName = product.ProductName;
                    p.UnitPrice = product.UnitPrice;
                    p.UnitInStock = product.UnitInStock;
                    p.CategoryId = product.CategoryId;
                }
            }
        }
        public static void DeleteProduct(Product product)
        {

            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductiId == product.ProductiId)
                {
                    listProducts.Remove(p);
                }
            }

        }

        public static Product GetProductById (int id)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductiId == id)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
