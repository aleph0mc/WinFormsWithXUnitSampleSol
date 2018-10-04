using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ServiceManagerBll;
using Moq;

namespace XUnitTestSample
{
    public class UnitTest2 : IDisposable
    {

        public UnitTest2()
        {
            // Ccode to initialize the test class
        }

        [Fact]
        public void AssignStandardBundleToEmployee_EmployeeId_ReturnsCorrectEmployee()
        {
            var es = new EquipmentServiceMock();
            var bf = new EquipmentBundleFactoryMock();
            var auditService = new AuditServiceMock();

            var employeeId = Guid.NewGuid();
            var service = new ServiceManagerBll.EquipmentService(bf, es, auditService);

            var result = service.AssignStandardBundleToEmployee(employeeId);

            Assert.Equal(employeeId, result.EmployeeId);
            Assert.Single(result.Bundle.Items);
            Assert.True(auditService.WriteFunctionCalled);
        }

        [Fact]
        public void AssignStandardBundleToEmployeeUsingMoq_EmployeeId_ReturnsCorrectEmployee()
        {
            var employeeId = Guid.NewGuid();

            var testItem = new EquipmentItem { Name = "Test" };

            var testBundle = new EquipmentBundle();
            testBundle.Add(testItem);

            var bundleFactoryMock = new Mock<IEquipmentBundleFactory>();
            bundleFactoryMock.Setup(x => x.CreateStandardBundle()).Returns(testBundle);

            var testEmployee = new Employee { EmployeeId = employeeId, Bundle = testBundle };

            var employeeServiceMock = new Mock<IEmployeeService>();
            employeeServiceMock.Setup(x => x.Connect(It.IsAny<Guid>(), It.IsAny<EquipmentBundle>())).Returns(testEmployee);

            var auditServiceMock = new Mock<IAuditService>();

            var service = new EquipmentService(bundleFactoryMock.Object, employeeServiceMock.Object, auditServiceMock.Object);

            var result = service.AssignStandardBundleToEmployee(employeeId);

            Assert.Equal(employeeId, result.EmployeeId);
            Assert.Single(result.Bundle.Items);
            auditServiceMock.Verify(v => v.WriteEmployeeInfo(It.Is<Employee>(e => e == testEmployee)));

        }

        public void Dispose()
        {
            // code to clean up the test class.
        }
    }
}
