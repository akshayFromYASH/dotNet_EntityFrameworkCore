using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_DBFirst_Demo.Models;

namespace MVC_DBFirst_Demo.Controllers{
    public class CategoryController : Controller{

        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context){
            _context = context;
        }

        public IActionResult Index(){
            var data = _context.Categories;
            return View(data);
        }

        [HttpGet]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category newcategory){
            if(ModelState.IsValid){
                _context.Categories.Add(newcategory);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id){
            if(id == -1){
                return NotFound();
            }
            else{

                var data = _context.Categories.FirstOrDefault(c => c.CatId == id);
                if(data == null){
                    return NotFound();
                }
                 
            return View(data);
            }
        }

        [HttpPost]
        public IActionResult Edit(int id,Category updatedcategory){

            // Method 1 
            // if(ModelState.IsValid){
            //     _context.Categories.Update(updatedcategory);
            //     _context.SaveChanges();
            //     TempData["success"] = "Category updated successfully!";
            //     return RedirectToAction("Index","Category");
            // }

            // Method 2 ==> Shown by Madam
            var data = _context.Categories.FirstOrDefault(c => c.CatId == id);

            if(data == null){
                return BadRequest();
            }
            else{
                data.CatName = updatedcategory.CatName;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id){
            
            if(id == -1){
                return NotFound();
            }
            else{
                var data = _context.Categories.FirstOrDefault(c=> c.CatId == id);
                if(data == null){
                    return NotFound();
                }
                 
            return View(data);
            }

            // var data=_context.categories.Find(id);
            // return View(data);
           
        }
 
        [HttpPost]
        public IActionResult Delete( Category deletedcategory)
        {
            if(ModelState.IsValid)
            {   
                _context.Categories.Remove(deletedcategory);
                _context.SaveChanges();
 
                return RedirectToAction("Index");
            }
            return View(deletedcategory);
        }
    }
}