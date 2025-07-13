using _2_WebApiEmployee.Controllers;
using _2_WebApiEmployee.Filters;
using _2_WebApiEmployee.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

//6363729
namespace _2_WebApiEmployee.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees;

        public EmployeeController()
        {
            if (_employees == null)
            {
                _employees = GetStandardEmployeeList();
            }
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] 
        public ActionResult<List<Employee>> Get()
        {
           
            throw new Exception("Simulated exception for testing");

        }


        [HttpGet("GetStandard")]
        public ActionResult<Employee> GetStandard()
        {
            return Ok(GetStandardEmployeeList().FirstOrDefault());
        }

        [HttpPost]
        public ActionResult<Employee> Post(Employee emp)
        {
            emp.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(emp);
            return CreatedAtAction(nameof(Get), new { id = emp.Id }, emp);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Employee emp)
        {
            var existing = _employees.FirstOrDefault(e => e.Id == id);
            if (existing == null) return NotFound();

            existing.Name = emp.Name;
            existing.Salary = emp.Salary;
            existing.Permanent = emp.Permanent;
            existing.Department = emp.Department;
            existing.Skills = emp.Skills;
            existing.DateOfBirth = emp.DateOfBirth;

            return NoContent();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Brishti Das",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 101, Name = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(2004, 8, 11)
                }
            };
        }
    }
}
