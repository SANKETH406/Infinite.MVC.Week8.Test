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
        public string ProductName { get; set; }
        public Category Category { get; set; }
        public PackSize Packsize { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }       
        public float Discount { get; set; }
        public double TotalPrice { get; set; }
        public int CategoryId { get; set; }
        public int PacksizeId { get; set; }
    }
}