using ArnGames.DataAccess.Abstract;
using ArnGames.DataAccess.Concrete;
using ArnGames.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArnGames.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public List<Employee> Get()
        {
            return _employeeRepository.GetAllList();
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employeeRepository.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            var added_T = _employeeRepository.Insert(employee);
            return Ok(added_T);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted_T = _employeeRepository.GetById(id);

            if (deleted_T == null)
            {
                return NotFound();
            }
            else
            {
                _employeeRepository.Delete(id);

                return Ok();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Employee employee)
        {
            _employeeRepository.Update(employee);

            return Ok(employee);
        }
    }
}
