using ECommerce.Models;
using ECommerce.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services.Data
{
    public class ItemDetailService : GeneralService<ItemDetail, ItemDetailRepository>
    {
        public ItemDetailService(ItemDetailRepository itemDetailRepository) : base(itemDetailRepository)
        {

        }
    }
}
