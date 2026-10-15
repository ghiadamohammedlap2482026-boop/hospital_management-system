using hospital.Data;
using hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hospital.Controllers
{
    public class DepartmentController : Controller
    {
        Hospital_db_context db = new Hospital_db_context();

        // Departments List
        public IActionResult Departments()
        {
            var departments = db.Department.ToList();

            return View(departments);
        }

        // Details
        public IActionResult Details(int id)
        {
            var dept = db.Department
                .Include(d => d.Doctor)
                .FirstOrDefault(d => d.Department_ID == id);

            if (dept == null)
                return NotFound();

            return View(dept);
        }

        // Add - GET
        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }

        // Add - POST
        [HttpPost]
        public IActionResult SaveAdd(Department dept)
        {
            try
            {
                db.Department.Add(dept);
                db.SaveChanges();

                return RedirectToAction("Departments");
            }
            catch (Exception ex)
            {
                return Content(ex.InnerException?.Message ?? ex.Message);
            }
        }

        // Update - GET
        [HttpGet]
        public IActionResult UpdateDepartment(int id)
        {
            var dept = db.Department.Find(id);

            if (dept == null)
                return NotFound();

            return View(dept);
        }

        // Update - POST
        [HttpPost]
        public IActionResult SaveUpdate(Department dept)
        {
            db.Department.Update(dept);
            db.SaveChanges();

            return RedirectToAction("Departments");
        }

       
    
    }
}