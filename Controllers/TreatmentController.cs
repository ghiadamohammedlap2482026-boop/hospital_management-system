using hospital.Data;
using hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hospital.Controllers
{
    public class TreatmentController : Controller
    {
        Hospital_db_context db = new Hospital_db_context();

        // Treatments List
        public IActionResult Treatments()
        {
            var treatments = db.Treatment
                .Include(t => t.Doctor)
                .Include(t => t.Patient)
                .ToList();

            return View(treatments);
        }

        // Details
        public IActionResult Details(int doctorId, int patientId)
        {
            var treatment = db.Treatment
                .Include(t => t.Doctor)
                .Include(t => t.Patient)
                .FirstOrDefault(t => t.Doctor_ID == doctorId && t.Patient_ID == patientId);

            if (treatment == null)
                return NotFound();

            return View(treatment);
        }

        // Add - GET
        [HttpGet]
        public IActionResult AddTreatment()
        {
            ViewBag.Doctors = db.Doctor.ToList();
            ViewBag.Patients = db.Patient.ToList();

            return View();
        }

        // Add - POST
        [HttpPost]
        public IActionResult SaveAdd(Treatment treatment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Treatment.Add(treatment);
                    db.SaveChanges();

                    return RedirectToAction("Treatments");
                }

                ViewBag.Doctors = db.Doctor.ToList();
                ViewBag.Patients = db.Patient.ToList();

                return View("AddTreatment", treatment);
            }
            catch (Exception ex)
            {
                return Content(ex.InnerException?.Message ?? ex.Message);
            }
        }

        // Update - GET
        [HttpGet]
        public IActionResult UpdateTreatment(int doctorId, int patientId)
        {
            var treatment = db.Treatment.Find(doctorId, patientId);

            if (treatment == null)
                return NotFound();

            ViewBag.Doctors = db.Doctor.ToList();
            ViewBag.Patients = db.Patient.ToList();

            return View(treatment);
        }

        // Update - POST
        [HttpPost]
        public IActionResult SaveUpdate(Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Treatment.Update(treatment);
                db.SaveChanges();

                return RedirectToAction("Treatments");
            }

            ViewBag.Doctors = db.Doctor.ToList();
            ViewBag.Patients = db.Patient.ToList();

            return View("UpdateTreatment", treatment);
        }

        // Delete
        public IActionResult DeleteTreatment(int doctorId, int patientId)
        {
            var treatment = db.Treatment.Find(doctorId, patientId);

            if (treatment != null)
            {
                db.Treatment.Remove(treatment);
                db.SaveChanges();
            }

            return RedirectToAction("Treatments");
        }
    }
}