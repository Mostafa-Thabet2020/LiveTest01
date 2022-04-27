using LiveTestDomain;
using LiveTestDomain.Infrastructure;
using LiveTestService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTest01.ConsoleService
{
    public class ConsoleService : ApplicationDbContext
    {
        public static void DepartmentDealing()
        {
            for (; ; )
            {
                Console.WriteLine($"Choose action\n" +
                    $"\nfor add enter 1" +
                    $"\nfor  update enter 2" +
                    $"\nfor get  by id enter 3");
                int ActionNumber = Convert.ToInt32(Console.ReadLine());
                switch (ActionNumber)
                {
                    case 1:
                        Department department = new Department();
                        Console.WriteLine("write department name:");
                        department.Name = Console.ReadLine();
                        dbContext.departments.Add(department);
                        dbContext.SaveChanges();
                        break;

                    case 2:
                        Console.WriteLine("write department id");
                        int UpdatedDepartmentId = Convert.ToInt32(Console.ReadLine());
                        Department UpdatedDepartment = dbContext.departments.Where(x => x.Id == UpdatedDepartmentId).SingleOrDefault();
                        Console.WriteLine("enter new name:");
                        UpdatedDepartment.Name = Console.ReadLine();
                        dbContext.departments.Update(UpdatedDepartment);
                        dbContext.SaveChanges();
                        break;

                    case 3:
                        Console.WriteLine("write department id");
                        int DepartmentId = Convert.ToInt32(Console.ReadLine());
                        Department GetDepartment = dbContext.departments.ToList(DepartmentId);
                        dbContext.departments.Get(GetDepartment);
                        dbContext.SaveChanges();
                        break;

                    default:
                        break;
                }
            }
        }

    }
}
