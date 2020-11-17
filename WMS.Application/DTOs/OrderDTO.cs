using System;
using System.Collections.Generic;
using WMS.Domain.Entities;

namespace WMS.Application.DTOs
{
    public class OrderDTO
    {
        public List<ItemDTO> Items { get; set; }
        public Boolean Type { get; set; } //ulazna ili izlazna
        
    }
}