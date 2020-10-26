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
    public class ProductsController : ControllerBase
    {

        IProductBLL _productBLL;

        public ProductsController(IProductBLL productBLL)
        {
            this._productBLL = productBLL;
        }



        [HttpGet]
        public IActionResult GetProducts()
        {
            var result = _productBLL.GetProducts();
            if (result.Count() == 0)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProductByID(long id)
        {
         
            var product = _productBLL.GetProductByID(id);
            if(product != null)
                return Ok(product);
            return NotFound();

        }
    }
}