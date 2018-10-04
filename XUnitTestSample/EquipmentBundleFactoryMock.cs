using System;
using System.Collections.Generic;
using System.Text;
using ServiceManagerBll;

namespace XUnitTestSample
{
    public class EquipmentBundleFactoryMock : IEquipmentBundleFactory
    {
        public EquipmentBundle CreateStandardBundle()
        {
            var testItem = new EquipmentItem { Name = "Test" };

            var testBundle = new EquipmentBundle();
            testBundle.Add(testItem);

            return testBundle;
        }
    }
}
