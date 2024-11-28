using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Custom_Validation.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace MVC_Custom_Validation.Controllers{
   public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(){
            var data = _context.students;
            return View(data);
        }

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student newStudent){

            if(ModelState.IsValid){
                _context.students.Add(newStudent);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id){
            var data = _context.students.FirstOrDefault(c => c.Id == id);
            return View(data);

            // if(id == -1){
            //     return NotFound();
            // }
            // else{

            //     var data = _context.students.FirstOrDefault(c => c.Id == id);
            //     if(data == null){
            //         return NotFound();
            //     }
            //     return View(data);

            // }
        }

        [HttpPost]
        public IActionResult Edit(int id,Student newStudent){
            // if(ModelState.IsValid){
            //     _context.students.Update(newStudent);
            //     _context.SaveChanges();

            //     return RedirectToAction("Index");
            // }

            // return View();

            var data = _context.students.FirstOrDefault(c => c.Id == id);

            if(data == null){
                return BadRequest();
            }
            else{
                _context.students.Update(newStudent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id){
            var data = _context.students.FirstOrDefault(x => x.Id ==id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(Student deletestudent){
            if(ModelState.IsValid){
                _context.students.Remove(deletestudent);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(deletestudent);
        }

    }
}