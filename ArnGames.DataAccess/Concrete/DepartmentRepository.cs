using ArnGames.DataAccess.Abstract;
using ArnGames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnGames.DataAccess.Concrete
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public void Delete(int id)
        {
            using (var context = new Context())
            {
                var deletedDepartment = GetById(id);
                context.Departments.Remove(deletedDepartment);
                context.SaveChanges();
            }
        }

        public List<Department> GetAllList()
        {
            using (var context = new Context())
            {
                return context.Departments.ToList();
            }
        }

        public Department GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Departments.Find(id);
            }
        }

        public Department Insert(Department t)
        {
            using (var context = new Context())
            {
                context.Departments.Add(t);
                context.SaveChanges();
                return t;
            }
        }

        public Department Update(Department t)
        {
            using (var context = new Context())
            {
                context.Departments.Update(t);
                context.SaveChanges();
                return t;
            }
        }
    }
}
