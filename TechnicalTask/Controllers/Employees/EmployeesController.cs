using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechnicalTask.Data.Models;
using TechnicalTask.Services.EmployeeServices;

namespace TechnicalTask.Controllers.Employees
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeServices _Services;
        public EmployeesController(IEmployeeServices services) 
        {
        _Services = services;
        }
        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var result = await _Services.GetAllEmployees();
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("GetAllMaleEmployees")]
        public async Task<IActionResult> GetAllMaleEmployees()
        {
            var result = await _Services.GetAllMaleEmployees();
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("GetAllFemaleEmployees")]
        public async Task<IActionResult> GetAllFemaleEmployees()
        {
            var result = await _Services.GetAllFemaleEmployees();
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("GetAllActiveEmployees")]
        public async Task<IActionResult> GetAllActiveEmployees()
        {
            var result = await _Services.GetAllActiveEmployees();
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetEmployeeById/Id")]
        public async Task<IActionResult> GetEmployeeById(int Id)
        {
            var result = await _Services.GetEmployeeById(Id);
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody] Employee Employee)
        {
            var result = await _Services.AddEmployee(Employee);
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }

    }

}
