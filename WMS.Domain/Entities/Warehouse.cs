using System;
using System.Collections.Generic;
using System.Text;

namespace WMS.Domain.Entities
{
    public class Warehouse
    {
        public Guid Id { get; set; }
        public int GlobalLocationNumber { get; set; }
        public string Adress { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }
        public List<User> Users { get; set; }
        public List<Order> Orders { get; set; }
        public List<WarehouseLocation> WarehouseLocations { get; set; }
    }
}