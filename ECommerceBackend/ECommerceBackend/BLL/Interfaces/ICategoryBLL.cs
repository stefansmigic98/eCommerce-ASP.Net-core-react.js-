using ECommerceBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBackend.BLL.Interfaces
{
    public interface ICategoryBLL
    {
        public IEnumerable<Category> GetCategories();
    }
}
