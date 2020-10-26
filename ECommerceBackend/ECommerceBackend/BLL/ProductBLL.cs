using ECommerceBackend.BLL.Interfaces;
using ECommerceBackend.DAL.Interfaces;
using ECommerceBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBackend.BLL
{
    public class ProductBLL: IProductBLL
    {
        private readonly IProductDAL _productDAL;

        public ProductBLL(IProductDAL productDAL)
        {
            this._productDAL = productDAL;
            
        }

        public Product GetProductByID(long productID)
        {
            return _productDAL.GetProductByID(productID);
        }

        public IEnumerable<Product> GetProducts()
        {
           return _productDAL.GetProducts();
        }
    }
}
