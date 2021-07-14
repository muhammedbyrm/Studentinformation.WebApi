using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studentinformation.Core;


namespace Studentinformation.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {

        private readonly IStudentServices _studentServices;

        public StudentsController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet]
        public IActionResult GetStudents() 
        {
           return Ok(_studentServices.GetStudents());
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public IActionResult GetStudent(string id)
        {
            try
            {
                return Ok(_studentServices.GetStudent(id));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        
        /*
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _studentServices.AddStudent(student);
            return CreatedAtRoute("GetStudent", new { id = student.Id }, student);
        }

        */

    }
}
