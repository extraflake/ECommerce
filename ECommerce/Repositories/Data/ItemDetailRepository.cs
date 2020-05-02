using ECommerce.Context;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Data
{
    public class ItemDetailRepository : GeneralRepository<ItemDetail, MyContext>
    {
        public ItemDetailRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
