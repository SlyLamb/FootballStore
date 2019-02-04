using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace FootballStore.Models
{
    public class Brand
    {
        public int ID { get; set; }

        [Display(Name = "Brand Name")]
        [Required(ErrorMessage = "The brand name cannot be blank")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Please enter a brand name between 3 and 15 characters in length")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Please enter a brand name beginning with a capital letter and only enter letters and spaces")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}