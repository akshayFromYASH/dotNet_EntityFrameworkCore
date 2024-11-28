using Microsoft.AspNetCore.Mvc;
using MVC_DBFirst_Demo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace MyApp.Namespace
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context){
            _context = context;
        }


        // GET: ProductController
        public IActionResult Index()
        {
            var data = _context.Products;
            return View(data);
        }

        [HttpGet]
        public IActionResult Create(){
            return View();
        } 

        public IActionResult Create(Product newprod){
            
            if(ModelState.IsValid){
                _context.Products.Add(newprod);
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

                var data = _context.Products.FirstOrDefault(c => c.ProdId == id);
                if(data == null){
                    return NotFound();
                }
                 
            return View(data);
            }
        } 

        [HttpPost]
        public IActionResult Edit(Product newprod){
            if(ModelState.IsValid){
                _context.Products.Add(newprod);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(){
            return View();
        }
    }
}
