using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class ICategoryRepository : ICategoryService
    {
        public readonly ICategoryRepository icategoryRepository;
        public CategoryService()
        {
            icategoryRepository = new CategoryRepository();
        }
        public List<Category> GetCategories()
        {
            return icategoryRepository.GetCategories();
        }

        
    }
}
