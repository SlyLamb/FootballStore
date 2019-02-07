using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FootballStore.ViewModels
{
    public class ProductViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "The Product name cannot be blank")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please enter a product name between 1 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-Z'_'\s]*$", ErrorMessage = "Please enter a product name made up of letters and spaces")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Product description cannot be blank")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Please enter a product description between 5 and 200 characters in length")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Product price cannot be blank")]
        [Range(0.10, 10000, ErrorMessage = "Please enter a product price between 0.10 and 10000")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        [Display(Name = "Brand")]
        public int BrandID { get; set; }
        public SelectList BrandList { get; set; }

        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        public SelectList CategoryList { get; set; }

        public List<SelectList> ImageLists { get; set; }

        public string[] ProductImages { get; set; }
    }
}