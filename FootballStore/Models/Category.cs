using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootballStore.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "The category name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a category name between 3 and 50 characters in length")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Please enter a category name beginning with a capital letter and only enter letters and spaces")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}