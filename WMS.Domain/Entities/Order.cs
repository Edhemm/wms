using System;
using System.Collections.Generic;
using System.Text;

namespace WMS.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public DateTime OrderedOn { get; set; }
        public Boolean Incoming { get; set; }

        public Order()
        {
            OrderedOn = DateTime.Now;
        }
    }
}
