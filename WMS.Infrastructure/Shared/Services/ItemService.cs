using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Application.Interfaces;
using WMS.Application.Interfaces.GenericRepository;
using WMS.Domain.Entities;

namespace WMS.Infrastructure.Shared.Services
{
    public class ItemService : IItemService
    {
        private readonly IGenericRepository<Item> _itemRepository;

        public ItemService(IGenericRepository<Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task AddItem(Item newItem)
        {
            if (newItem != null)
            {
                await _itemRepository.AddAsync(newItem);
            }
        }

        public IList<Item> GetAllItems()
        {
            return _itemRepository.GetAllAsync().Result.ToList();
        }

        public Task<Item> GetItem(int id)
        {
            return _itemRepository.GetByIdAsync(id);
        }

        public async Task EditItem(Item item)
        {
            await _itemRepository.UpdateAsync(item);
        }

        public async Task DeleteItem(Guid id)
        {
            var itemToDelete = _itemRepository.GetByGuidAsync(id).Result;
            await _itemRepository.DeleteAsync(itemToDelete);
        }
    }
}