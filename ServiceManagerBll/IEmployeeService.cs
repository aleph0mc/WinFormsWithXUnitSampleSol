using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerBll
{
    public interface IEmployeeService
    {
        Employee Connect(Guid EmployeeId, EquipmentBundle Bundle);
    }
}
