using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("category")]
        public int CategoryID { get; set; } //This is the actual foergin key;This is a wa to address the relationship

        public string ImageUrl { get; set; }

        public int Stock { get; set; }

        [DefaultValue(false)]
        public bool disbale { get; set; }
    }
}
