using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WMS.Domain.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public int GlobalTradeItemNumber { get; set; }
        public string Name { get; set; }
        public double MinimalQuantity { get; set; }
        public double CurrentQuantity { get; set; }
        public string Category { get; set; }
        public DateTime AddedOn { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
