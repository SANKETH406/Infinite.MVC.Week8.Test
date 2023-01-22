using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Infinite.MVC.Week8.Test.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Product Name Cannot be Empty")]
        [Display(Name="Product Name")]
        [StringLength(50)]
        public string ProductName { get; set; }
        
        public Category Category { get; set; }
        //public string Packsize { get; set; }

        public double Price { get; set; }

        [Required(ErrorMessage = "Quantity Cannot be Empty")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Discount cannot be empty")]
        [Display(Name = "Discount")]
        public float Discount { get; set; }
        [Required(ErrorMessage = "Enter Total Price")]
        [Display(Name = "Total Price")]
        public double TotalPrice { get; set; }


        public int CategoryId { get; set; }

        //public int PacksizeId { get; set; }
    }
}