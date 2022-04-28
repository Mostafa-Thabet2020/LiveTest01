using LiveTestDomain;
using LiveTestDomain.Infrastructure;
using LiveTestService;
using LiveTestService.Service;
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
                DepartmentService departmentService = new DepartmentService();

                Department department = new Department();

                Console.WriteLine($"Choose action\n" +
                    $"\nfor add enter 1" +
                    $"\nfor update enter 2" +
                    $"\nfor Get all departments order by name enter 3" +
                    $"\nfor get department by id enter 4");
                int ActionNumber = Convert.ToInt32(Console.ReadLine());
                switch (ActionNumber)
                {
                    case 1:
                        Console.WriteLine("write department name:");
                        department.Name = Console.ReadLine();
                        departmentService.Add(department);
                        break;

                    case 2:
                        Console.WriteLine("write department id");
                        Convert.ToInt32(Console.ReadLine());
                        departmentService.Update(department);
                        break;

                    case 3:
                        Console.WriteLine("write department name");
                        int DepartmentName = Convert.ToInt32(Console.ReadLine());
                        departmentService.Count(DepartmentName);
                        break;

                    case 4:
                        Console.WriteLine("write department id");
                        int DepartmentId = Convert.ToInt32(Console.ReadLine());
                        departmentService.Get(DepartmentId);
                        break;

                    default:
                        break;
                }
            }
        }

    }
}
