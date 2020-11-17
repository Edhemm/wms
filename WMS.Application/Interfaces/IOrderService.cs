using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WMS.Application.DTOs;
using WMS.Domain.Entities;

namespace WMS.Application.Interfaces
{
    public interface IOrderService
    {
        public Task AddOrder(OrderDTO orderDto);
        public IList<Order> GetAllOrders();
        public Task<Order> GetOrder(Guid id);
        public Task EditOrder(Order order);
        public Task DeleteOrder(Guid id);
    }
}