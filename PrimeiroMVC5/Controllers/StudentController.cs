using PrimeiroMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiroMVC5.Controllers
{
    public class StudentController : Controller
    {
        // GET: Aluno
        [Route("new-student")]
        public ActionResult New(Student aluno)
        {
            aluno = new Student()
            {
                Name = "matheus",
                CPF = "12345678911",
                SignupDate = DateTime.Now,
                Email = "matheus@vinicius.com",
                Active = true/*,
                Password = "123",
                PasswordCheck = "123"*/
            };
            return RedirectToAction("Index", aluno);
        }
        public ActionResult Index(Student aluno)
        {
            if(!ModelState.IsValid) return View(aluno);
            return View(aluno);
        }

        [Route("add-new-student")]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        [Route("add-new-student")]
        public ActionResult AddStudent(Student student)
        {
            if (!ModelState.IsValid) return View(student);
            return View(student);
        }
    }
}