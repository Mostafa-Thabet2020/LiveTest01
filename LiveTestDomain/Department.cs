using LiveTestDomain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTestDomain
{
    public class Department:BaseEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Empolyee> empolyees { get; set; }
    }
}
