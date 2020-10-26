using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBackend.Models
{
    public class Category
    {
        [Key]
        public long ID { get; set; }
        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }
    }
}
