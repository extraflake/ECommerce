using ECommerce.Context;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Data
{
    public class CategoryRepository : GeneralRepository<Category, MyContext>
    {
        public CategoryRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
