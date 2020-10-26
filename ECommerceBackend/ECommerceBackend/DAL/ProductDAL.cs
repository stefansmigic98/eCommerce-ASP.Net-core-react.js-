using ECommerceBackend.DAL.Interfaces;
using ECommerceBackend.Data;
using ECommerceBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBackend.DAL
{
    public class ProductDAL :IProductDAL
    {
        private readonly EcommerceAppDbContext _context;
        public ProductDAL(EcommerceAppDbContext context)
        {
            this._context = context;
        }

        public Product GetProductByID(long productID)
        {
            return _context.Products.FirstOrDefault(x => x.ID == productID);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}
