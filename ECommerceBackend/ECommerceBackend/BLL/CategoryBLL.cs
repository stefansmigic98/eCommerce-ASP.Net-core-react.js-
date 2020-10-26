using ECommerceBackend.BLL.Interfaces;
using ECommerceBackend.DAL.Interfaces;
using ECommerceBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBackend.BLL
{
    public class CategoryBLL:ICategoryBLL
    {
        private readonly ICategoryDAL _categoryDAL;

        public CategoryBLL(ICategoryDAL categoryDAL)
        {
            this._categoryDAL = categoryDAL;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryDAL.GetCategories();
        }

    }
}
