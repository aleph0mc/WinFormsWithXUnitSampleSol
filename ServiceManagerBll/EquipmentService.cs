using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerBll
{
    public class EquipmentService
    {
        private readonly IEquipmentBundleFactory _bundleFactory;
        private readonly IEmployeeService _employeeService;
        private readonly IAuditService _auditService;

        public EquipmentService(IEquipmentBundleFactory BundleFactory, IEmployeeService EmployeeService, IAuditService AuditService)
        {
            _bundleFactory = BundleFactory;
            _employeeService = EmployeeService;
            _auditService = AuditService;
        }

        public Employee AssignStandardBundleToEmployee(Guid EmployeeId)
        {
            var returnValue = _employeeService.Connect(EmployeeId, _bundleFactory.CreateStandardBundle());
            _auditService.WriteEmployeeInfo(returnValue);

            return returnValue;
        }
    }
}
