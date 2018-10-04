using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerBll
{
    public class EquipmentBudleFactory
    {
        public EquipmentBundle CreateStandardBundle()
        {
            var monitor = new EquipmentItem { Name = "Monitor" };
            var keyboard = new EquipmentItem { Name = "Keyboard" };
            var headset = new EquipmentItem { Name = "Headset" };

            var standardBundle = new EquipmentBundle();
            standardBundle.Add(monitor);
            standardBundle.Add(keyboard);
            standardBundle.Add(headset);

            return standardBundle;
        }
    }
}
