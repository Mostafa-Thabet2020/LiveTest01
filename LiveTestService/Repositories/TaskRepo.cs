using LiveTestDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTestService.Repositories
{
    public interface TaskRepo
    {
        /// <summary>
        /// Add new task for an empolyee
        /// </summary>
        void Add(EmpolyeeTask empolyeeTask);
        /// <summary>
        /// Update old task
        /// </summary>
        void Update(EmpolyeeTask empolyeeTask);
        /// <summary>
        /// Get task by id
        /// </summary>
        EmpolyeeTask Get(int id);
        /// <summary>
        /// Get all tasks
        /// </summary>
        List<EmpolyeeTask> Get();
        /// <summary>
        /// Get tasks thats assined to sapcifec empolyee 
        /// </summary>
        List<EmpolyeeTask> GetTaskOfEmpolyee(int Id);
        /// <summary>
        /// Get complate tasks only
        /// </summary>
        List<EmpolyeeTask> GetComplatedTask();
    }
}
