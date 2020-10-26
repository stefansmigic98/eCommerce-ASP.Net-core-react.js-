using ECommerceBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBackend.DAL.Interfaces
{
    public interface IProductDAL
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProductByID(long productID);

    }
}

