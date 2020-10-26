using ECommerceBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBackend.DAL.Interfaces
{
    public interface ICategoryDAL
    {

        public IEnumerable<Category> GetCategories();
    }
}
