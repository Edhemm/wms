using System;

namespace WMS.Domain.Entities
{
    public class OrderDetails
    {
        public Guid Id { get; set; }
        public double Quantity { get; set; }
    }
}