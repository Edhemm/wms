using System;
using System.Collections.Generic;
using System.Text;

namespace WMS.Domain.Entities
{
    public class WarehouseLocation
    {
        public Guid Id { get; set; }
        public List<StorageBin> StorageBins { get; set; }
    }
}
