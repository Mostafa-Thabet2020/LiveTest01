using LiveTestDomain;
using LiveTestDomain.Infrastructure;
using LiveTestService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTestService.Service
{
    public class DepartmentService : DepartmentRepo
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public void Add(Department department)
        {
            if (!IsExist(department.Name)) 
            {
                dbContext.departments.Add(department);
                dbContext.SaveChanges();
            }
        }
        public void Update(Department department)
        {
            if (IsExist(department.Id))
            {
                Department oldDepartment = Get(department.Id);
                oldDepartment.Name = department.Name;
                dbContext.departments.Update(oldDepartment);
                dbContext.SaveChanges();
            }
        }
        public int Count()
        {
            throw new NotImplementedException();
        }

        public List<Department> Get()
        {
            return dbContext.departments.ToList();
        }

        public Department Get(int id)
        {
            if (IsExist(id))
            {
                return dbContext.departments.Find(id);
            }
            return null;
        }

        public bool IsExist(int id)
        {
            return dbContext.departments.Any(x => x.Id == id);
        }
        public bool IsExist(string departmentsName)
        {
            return dbContext.departments.Any(x => x.Name == departmentsName);
        }

        
    }
}
