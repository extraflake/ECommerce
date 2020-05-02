using ECommerce.Context;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Data
{
    public class RoleRepository : GeneralRepository<Role, MyContext>
    {
        public RoleRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
