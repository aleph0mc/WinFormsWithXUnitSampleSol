using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerBll
{
    public class EmployeeService : IEmployeeService
    {
        public Employee Connect(Guid EmployeeId, EquipmentBundle Bundle) => new Employee { EmployeeId = EmployeeId, Bundle = Bundle };
    }
}
