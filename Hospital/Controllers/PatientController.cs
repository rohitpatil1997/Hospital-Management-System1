using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Add()
        {
            return View("PatientAdd");
        }
        public IActionResult Submit(string PatientName, string PatientProblem)
        {
            return Content("You had Submitted " + PatientName
                + " he has a Problem of " + PatientProblem);

        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}