using ECommerce.Models;
using ECommerce.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services.Data
{
    public class ItemPhotoService : GeneralService<ItemPhoto, ItemPhotoRepository>
    {
        public ItemPhotoService(ItemPhotoRepository itemPhotoRepository) : base(itemPhotoRepository)
        {

        }
    }
}
