using PrimeiroMVC5.Data;
using PrimeiroMVC5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PrimeiroMVC5.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public StudentController()
        {
            _appDbContext = new AppDbContext();
        }


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
            if (!ModelState.IsValid) return View(aluno);
            return View(aluno);
        }

        [Route("add-new-student")]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        [Route("add-new-student")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddStudent(Student student)
        {
            if (!ModelState.IsValid) return View(student);
            if (!ModelState.IsValid) return View(student);
            student.SignupDate = DateTime.Now;
            _appDbContext.Students.Add(student);
            await _appDbContext.SaveChangesAsync();
            return View(student);
        }

        [HttpPost]
        [Route("get-students")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GetStudents()
        {
            var students = _appDbContext.Students.ToList();
            return View(students);
        }

        [HttpGet]
        [Route("edit-student")]
        public async Task<ActionResult> EditStudent()
        {
            var student = _appDbContext.Students.FirstOrDefault(a => a.Name == "asd");
            student.Name = "João";
            var entry = _appDbContext.Entry(student);
            _appDbContext.Set<Student>().Attach(student);
            entry.State = EntityState.Modified;
            _appDbContext.SaveChanges();

            var newStudent = _appDbContext.Students.Find(student.Id);
            return View("AddStudent", newStudent);
        }



        [HttpGet]
        [Route(template: "delete-student")]
        public ActionResult ExcluirAluno()
        {
            var student = _appDbContext.Students.FirstOrDefault(a => a.Name == "João");
            _appDbContext.Students.Remove(student);
            _appDbContext.SaveChanges();
            var students = _appDbContext.Students.ToList();
            return View("AddStudent", model: students.FirstOrDefault());
        }
    }
}