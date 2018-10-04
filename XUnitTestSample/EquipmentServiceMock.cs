using System;
using System.Collections.Generic;
using System.Text;
using ServiceManagerBll;

namespace XUnitTestSample
{
    public class EquipmentServiceMock : IEmployeeService
    {
        public Employee Connect(Guid EmployeeId, EquipmentBundle Bundle) => new Employee { EmployeeId = EmployeeId, Bundle = Bundle };
    }
}
