using ArnGames.DataAccess.Abstract;
using ArnGames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnGames.DataAccess.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void Delete(int id)
        {
            using (var context = new Context())
            {
                var deletedEmployee = GetById(id);
                 context.Employees.Remove(deletedEmployee);
                context.SaveChanges();
            }
        }

        public List<Employee> GetAllList()
        {
            using (var context=new Context())
            {
                return context.Employees.ToList();
            }
        }

        public Employee GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Employees.Find(id);
            }
        }

        public Employee Insert(Employee t)
        {
            using (var context = new Context())
            {
                context.Employees.Add(t);
                context.SaveChanges();
                return t;
            }
        }

        public Employee Update(Employee t)
        {
            using (var context = new Context())
            {
                 context.Employees.Update(t);
                return t;
            }
        }
    }
}
