﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using Emre.MvcWebUI.Entity;
using Emre.MvcWebUI.Models;

namespace Emre.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();


        public ActionResult Index()
        {
            var urunler = _context.Products.Where(i => i.IsHome == true && i.IsApproved == true).Select(i =>
                new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 50) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                }).ToList();
            return View(urunler);
        }
        public ActionResult Details(int Id)
        {
            return View(_context.Products.FirstOrDefault(i=>i.Id==Id));
        }
        public ActionResult List(int? id)
        {
            var urunler = _context.Products.Where(i=>i.IsApproved == true).Select(i =>
                new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "1.jpg",
                    CategoryId = i.CategoryId
                }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }
            return View(urunler.ToList());
        }
        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
    }
}