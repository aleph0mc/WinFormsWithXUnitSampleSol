using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerBll
{
    public interface IAuditService
    {
        void WriteEmployeeInfo(Employee Empl);
    }
}
