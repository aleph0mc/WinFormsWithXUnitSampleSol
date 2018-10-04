using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerBll
{
    public class AuditService : IAuditService
    {
        public string Path = "auditLog.txt";
        public void WriteEmployeeInfo(Employee Empl)
        {
            using (StreamWriter writer = File.AppendText(Path))
            {
                writer.WriteLine($"Employee {Empl.EmployeeId} has a bundle with {Empl.Bundle}");
            }
        }
    }
}
