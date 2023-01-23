using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Infinite.MVC.Week8.Test.Models
{
    public class Category
    {
        public int Id { get; set; }       
        public string CategoryName { get; set; }
    }
}