using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBackend.Models
{
    public class Product
    {
        [Key]
        public long ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }
    }
}
