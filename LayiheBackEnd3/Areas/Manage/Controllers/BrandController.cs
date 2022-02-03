﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayiheBackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LayiheBackEnd.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "admin")]
    public class BrandController : Controller
    {
        private readonly JuanContext _context;
        private readonly IWebHostEnvironment _env;

        public BrandController(JuanContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
       

            var brands = _context.Brands.Include(x => x.Products).AsQueryable();

            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSizeVal").Value;
            int pageSize = pageSizeStr == null ? 3 : int.Parse(pageSizeStr);
            return View(PagenatedList<Brand>.Create(brands, page, pageSize));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Brands.Add(brand);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
            Brand brand = _context.Brands.FirstOrDefault(x => x.Id == id);

            if (brand == null) return NotFound();

            return View(brand);
        }

        [HttpPost]
        public IActionResult Edit(Brand brand)
        {
            if (!ModelState.IsValid)
                return View();

            Brand existbrand = _context.Brands.FirstOrDefault(x => x.Id == brand.Id);

            if (existbrand == null) return NotFound();
            existbrand.Name = brand.Name;

            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            Brand brand = _context.Brands.FirstOrDefault(x => x.Id == id);
            if (brand == null) return NotFound();

            return View(brand);
        }
        [HttpPost]
        public IActionResult Delete(Brand brand)
        {


            Brand existbrand = _context.Brands.FirstOrDefault(x => x.Id == brand.Id);

            if (existbrand == null) return NotFound();

            _context.Brands.Remove(existbrand);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
