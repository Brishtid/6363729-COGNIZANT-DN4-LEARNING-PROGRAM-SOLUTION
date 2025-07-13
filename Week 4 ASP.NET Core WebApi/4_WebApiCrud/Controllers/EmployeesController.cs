using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace _3_WebApiCrud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        
        private static List<Employee> employeeList = new List<Employee>
        {
            new Employee { Id = 1, Name = "Brishti", Department = "ML engineer ", Salary = 63636729 },
            new Employee { Id = 2, Name = "Rain", Department = "Finance", Salary = 60000 },
            new Employee { Id = 3, Name = "Cloud", Department = "IT", Salary = 70000 }
        };

        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existingEmployee = employeeList.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
                return BadRequest("Invalid employee id");

            
            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Department = updatedEmployee.Department;
            existingEmployee.Salary = updatedEmployee.Salary;

            return Ok(existingEmployee); 
        }
    }
}
