using ECommerceBackend.DAL.Interfaces;
using ECommerceBackend.Data;
using ECommerceBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBackend.DAL
{
    public class CategoryDAL: ICategoryDAL
    {
        private readonly EcommerceAppDbContext _context;

        public CategoryDAL(EcommerceAppDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
