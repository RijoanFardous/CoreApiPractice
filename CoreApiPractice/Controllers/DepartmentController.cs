using CoreApiPractice.EF;
using CoreApiPractice.EF.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly UniversityMSContext _context;
        public DepartmentController(UniversityMSContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAllDepartments")]
        public IActionResult GetAll()
        {
            var departments = _context.Departments.ToList();
            return Ok(departments);
        }

        [HttpGet]
        [Route("GetDepartment/{id}")]
        public IActionResult Get(int id)
        {
            var department = _context.Departments.Find(id);
            return Ok(department);
        }

        [HttpPost]
        [Route("CreateDepartment")]
        public IActionResult AddDepartment(Department dept)
        {
            if(ModelState.IsValid)
            {
                _context.Departments.Add(dept);
                _context.SaveChanges();

                return Ok("Successful");
            }
            return BadRequest(ModelState);
        }
    }
}
