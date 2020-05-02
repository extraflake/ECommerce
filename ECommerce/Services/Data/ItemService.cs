using ECommerce.Models;
using ECommerce.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services.Data
{
    public class ItemService : GeneralService<Item, ItemRepository>
    {
        public ItemService(ItemRepository itemRepository) : base(itemRepository)
        {

        }
    }
}
