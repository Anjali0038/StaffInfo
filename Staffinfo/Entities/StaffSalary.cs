using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Staffinfo.Entities
{
    public class StaffSalary
    {
        public int invoiceId { get; set; }
        public int Id { get; set; }
        public long Salary { get; set; }
        [ForeignKey("Id")]
        public Staff staff { get; set; }
    }
}
