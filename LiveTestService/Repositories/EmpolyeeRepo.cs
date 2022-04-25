using LiveTestDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTestService.Repositories 
{
    public interface EmpolyeeRepo : IGenericCRUD<Empolyee> 
    {
        /// <summary>
        /// Add new empolyee
        /// </summary>
        void Add(Empolyee empolyee);
        /// <summary>
        /// Update old Empolyee
        /// </summary>
        void Update(Empolyee empolyee);
        /// <summary>
        /// Get Total Salary
        /// </summary>
        double TotalSalaries();
        /// <summary>
        /// Get all empolyees
        /// </summary>
        List<Empolyee> Get();
        /// <summary>
        /// Get empolyee by Id
        /// </summary>
        Empolyee Get(int Id);
        /// <summary>
        /// Check if there empolyee by id
        /// </summary>
        bool IsExist(int Id);
    }
}
