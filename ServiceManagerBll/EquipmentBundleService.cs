using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerBll
{
    public class EquipmentBundleService
    {
        private readonly IEquipmentBundleFactory _bundleFactory;
        private readonly IEmployeeService _employeeService;
        private readonly IAuditService _auditService;
    }
}
