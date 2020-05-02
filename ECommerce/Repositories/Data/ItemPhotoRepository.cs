using ECommerce.Context;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Data
{
    public class ItemPhotoRepository : GeneralRepository<ItemPhoto, MyContext>
    {
        public ItemPhotoRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
