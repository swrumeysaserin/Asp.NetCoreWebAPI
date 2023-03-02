using ArnGames.DataAccess.Abstract;
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
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public List<Department> Get()
        {
            return _departmentRepository.GetAllList();
        }
        [HttpGet("{id}")]
        public Department Get(int id)
        {
            return _departmentRepository.GetById(id);
        }

        [HttpPost]
        public Department Post([FromBody] Department department)
        {

            return _departmentRepository.Insert(department);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
               _departmentRepository.Delete(id);
        }

        [HttpPut]
        public Department Put([FromBody] Department department)
        {
          return  _departmentRepository.Update(department);

        }
    }
}
