using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shoppingcart.domain.Models
{
     
    public class Product
    {
        [Key]
        
        public Guid id { get; set;}
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public virtual Category category { get; set; }

        public string ImageUrl { get; set; }

        public int Stock { get; set; }
    }
}
