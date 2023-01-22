using Infinite.MVC.Week8.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Infinite.MVC.Week8.Test.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context = null;
        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Products

        public ActionResult Index()
        {
            var Products = _context.Products.ToList();
            return View(Products);
        }

        public ActionResult Create()
        {
            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;
            return View();  
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }   
            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }      
        
    }
}