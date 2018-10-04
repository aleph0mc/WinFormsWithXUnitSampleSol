using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerBll
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public EquipmentBundle Bundle { get; set; }
    }
}
