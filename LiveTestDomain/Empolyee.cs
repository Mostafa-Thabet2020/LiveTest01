using LiveTestDomain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTestDomain
{
    public class Empolyee: BaseEntity
    {
        public string FirstName { get; set; }
        public string SecoundName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department department { get; set; }
    }
}
