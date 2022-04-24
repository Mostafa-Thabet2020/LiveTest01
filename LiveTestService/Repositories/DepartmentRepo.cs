using LiveTestDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTestService.Repositories
{
    public interface DepartmentRepo
    {
        /// <summary>
        /// Add new Department
        /// </summary>
        void Add (Department department);
        /// <summary>
        /// Update old department
        /// </summary>
        void Update (Department department);
        /// <summary>
        /// Get Count of all departments
        /// </summary>
        int Count();
        /// <summary>
        /// Get all departments order by name
        /// </summary>
        List<Department> Get();
        /// <summary>
        /// Get department by id
        /// </summary>
        Department Get(int id);
        /// <summary>
        /// Check if department exist by Id
        /// </summary>
        bool IsExist(int id);
    }
}
