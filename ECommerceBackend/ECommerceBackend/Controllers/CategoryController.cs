using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceBackend.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBLL _categoryBLL;

        public CategoryController(ICategoryBLL categoryBLL)
        {
            this._categoryBLL = categoryBLL;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var res = _categoryBLL.GetCategories();
            if (res.Count() > 0)
                return Ok(res);
            else
                return NotFound();

        }
        
    }
}