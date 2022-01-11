using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Project_API.Data;
using Student_Project_API.Models;
using Student_Project_API.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Student_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            List<DtoStudent> DtoStudents = new List<DtoStudent>();
            foreach (var item in _context.Students.ToList())
            {
                DtoStudent dtoStudent = new DtoStudent();

                dtoStudent.Id = item.Id;
                dtoStudent.Name = item.Name;
                dtoStudent.Surname = item.Surname;
                dtoStudent.Age = item.Age;
                dtoStudent.Class = item.Class;
                dtoStudent.specialtyId = item.specialtyId;
                dtoStudent.Specialty = _context.Specialties.Select(s => new { s.Id, s.Name })
                   .FirstOrDefault(sa => sa.Id == item.specialtyId);

                DtoStudents.Add(dtoStudent);
            };

            return Ok(DtoStudents);
        }
        [HttpGet("{id}")]
        public IActionResult GetStudents(int? id)
        {
            if (id == null)
            {
                //return BadRequest();

                //ModelState.AddModelError("", "Error message!");
                //return StatusCode(StatusCodes.Status400BadRequest, ModelState);

                return StatusCode(StatusCodes.Status400BadRequest, "Error message!");
            }

            Student employee = _context.Students.Find(id);
            if (employee == null)
            {
                ModelState.AddModelError("", "Error, nese oluf!");
                return StatusCode(StatusCodes.Status404NotFound, ModelState);

                //return StatusCode(StatusCodes.Status400BadRequest, "Error message?!");
            }

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult CreateStudents(Student model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                _context.Students.Add(model);
                _context.SaveChanges();
                return Ok();
            }

            return BadRequest();
        }
    }
}
