using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerBll
{
    public class EquipmentBundle
    {
        public List<EquipmentItem> Items { get; private set; } = new List<EquipmentItem>();

        public void Add(EquipmentItem Item)
        {
            Items.Add(Item);
        }
    }
}
