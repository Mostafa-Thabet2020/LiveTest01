using LiveTestDomain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTestDomain
{
    public static class DataSeed
    {
        public static string StartSeeding()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            bool IfDataSeed = context.settings.Any(x => x.IsSeedData == true);
            if (!IfDataSeed)
            {


                using (var Transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (!context.departments.Any())
                        {
                            context.AddRange(GetDepartments());
                            context.SaveChanges();
                        }
                        int DepartmentHRId = context.departments.Where(x => x.Name == "HR").FirstOrDefault().Id;
                        int DepartmentPRId = context.departments.Where(x => x.Name == "PR").FirstOrDefault().Id;
                        int DepartmentDevId = context.departments.Where(x => x.Name == "Dev").FirstOrDefault().Id;

                        context.AddRange(GetEmpolyees(DepartmentHRId, DepartmentPRId, DepartmentDevId));
                        context.settings.Add(new ApplicationSetting() { IsSeedData = true });
                        context.SaveChanges();
                        Transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Transaction.Rollback();
                        return ex.Message;
                    }
                }
                context.Dispose();
            }
            return IfDataSeed ? null : "Data seeded succesfully";
        }
        private static List<Department> GetDepartments()
        {
            return new List<Department>() {
                new Department() { Name = "HR"},
                new Department() { Name = "PR"},
                new Department() { Name = "Dev"},
            };
        }
        private static List<Empolyee> GetEmpolyees(int HRId,int PRID,int DevId)
        {
            return new List<Empolyee>()
            {
                new Empolyee(){FirstName="Ahmed",SecoundName="Thabet",DepartmentId=HRId,Mobile="01558488488",Address=""},
                new Empolyee(){FirstName="Ali",SecoundName="Mohamed",DepartmentId=HRId,Mobile="01558488489",Address=""},
                new Empolyee(){FirstName="Salma",SecoundName="AbdAllah",DepartmentId=PRID,Mobile="01558488490",Address=""},
                new Empolyee(){FirstName="Shady",SecoundName="Yasser",DepartmentId=DevId,Mobile="01558488499",Address=""},
                new Empolyee(){FirstName="Esraa",SecoundName="Said",DepartmentId=DevId,Mobile="01558488470",Address=""},
            };
        }
    }
}
