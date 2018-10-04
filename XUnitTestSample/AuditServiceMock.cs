using System;
using System.Collections.Generic;
using System.Text;
using ServiceManagerBll;

namespace XUnitTestSample
{
    public class AuditServiceMock : IAuditService
    {
        public bool WriteFunctionCalled { get; set; } = true;

        public void WriteEmployeeInfo(Employee Empl)
        {
            WriteFunctionCalled = true;
        }
    }
}
