using LiveTestDomain;
using LiveTestService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveTestService;
using Microsoft.EntityFrameworkCore;


namespace LiveTestService.Service
{
    public class EmpolyeeService : EmpolyeeRepo
    {
        public void Add(Empolyee empolyee)
        {
            empolyee.CreatedDate=DateTime.Now;
            DbContext.empolyees.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            dbContext.empolyees.Remove(Get(Id));
            dbContext.SaveChanges();
        }

        public List<Empolyee> Get()
        {
            return dbContext.empolyees.ToList();
        }

        public Empolyee Get(int Id)
        {
            if (IsExist(Id))
            {
                return dbContext.empolyees.Where(x => x.Id == Id).SingleOrDefault();
            }
            return null;
        }

        public bool IsExist(int Id)
        {
            return dbContext.empolyees.Any(x => x.Id==Id);
        }

        public double TotalSalaries()
        {
            throw new NotImplementedException();
        }

        public void Update(Empolyee empolyee)
        {
            if (IsExist(entity))
            {
                empolyees oldEntity = Get(entity.Id);
                oldEntity.empolyees = entity.empolyees;
            }
        }
    }
}
