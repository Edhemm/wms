using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WMS.Application.Interfaces;
using WMS.Domain.Entities;

namespace WMS.Controllers
{
    [Route("item")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public List<Item> GetAllItems()
        {
            return _itemService.GetAllItems().ToList();
        }

        [HttpGet("{id}")]
        public Item GetItem(int id)
        {
            return _itemService.GetItem(id).Result;
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(Item newItem)
        {
            _itemService.AddItem(newItem);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(Guid id)
        {
            _itemService.DeleteItem(id);
            return Ok();
        }
        
        [HttpPut]
        public async Task<IActionResult> EditItem(Item item)
        {
            _itemService.EditItem(item);
            return Ok();
        }
    }
}