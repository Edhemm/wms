using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WMS.Domain.Entities;

namespace WMS.Application.Interfaces
{
    public interface IItemService
    {
        public Task AddItem(Item newItem);
        public IList<Item> GetAllItems();
        public Task<Item> GetItem(int id);
        public Task EditItem(Item item);
        public Task DeleteItem(Guid id);
    }
}