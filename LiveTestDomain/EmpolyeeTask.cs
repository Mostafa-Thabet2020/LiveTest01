using LiveTestDomain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTestDomain
{
    public class EmpolyeeTask:BaseEntity
    {
        public string Title { get; set; }
        public string Descraptation { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsComplate { get; set; } = false;
        public int EmpolyeeId { get; set; }
        [ForeignKey("EmpolyeeId")]
        public Empolyee empolyee { get; set; }
    }
}
