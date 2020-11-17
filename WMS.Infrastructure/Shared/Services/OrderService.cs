using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Application.DTOs;
using WMS.Application.Interfaces;
using WMS.Application.Interfaces.GenericRepository;
using WMS.Domain.Entities;

namespace WMS.Infrastructure.Shared.Services
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IGenericRepository<Item> _itemRepository;
        private readonly IGenericRepository<OrderDetails> _orderDetailsRepository;

        public OrderService(IGenericRepository<Order> orderRepository, IGenericRepository<Item> itemRepository,
            IGenericRepository<OrderDetails> orderDetailsRepository)
        {
            _orderRepository = orderRepository;
            _itemRepository = itemRepository;
            _orderDetailsRepository = orderDetailsRepository;
        }

        public async Task AddOrder(OrderDTO orderDto)
        {
            Item item = new Item();
            Order order = new Order();
            List<OrderDetails> orderDetails = new List<OrderDetails>();
            
            foreach (var itemDTO in orderDto.Items)
            {
                OrderDetails orderDetail = new OrderDetails();
                orderDetail.Quantity = itemDTO.Quantity;
                
                item = _itemRepository.GetByGuidAsync(Guid.Parse(itemDTO.Id)).Result;
                
                if (orderDto.Type)
                {
                    item.CurrentQuantity += itemDTO.Quantity;
                }
                else
                {
                    item.CurrentQuantity -= itemDTO.Quantity;
                }
                orderDetails.Add(orderDetail);
                
                await _orderDetailsRepository.AddAsync(orderDetail);
                await _itemRepository.UpdateAsync(item);
            }

            order.OrderDetails = orderDetails;
            item.OrderDetails = orderDetails;

            await _itemRepository.UpdateAsync(item);
            await _orderRepository.AddAsync(order);
        }

        public IList<Order> GetAllOrders()
        {
            return _orderRepository.IncludeAll().ToList();
        }

        public Task<Order> GetOrder(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task EditOrder(Order user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrder(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}