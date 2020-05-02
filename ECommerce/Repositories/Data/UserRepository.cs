using ECommerce.Context;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Data
{
    public class UserRepository : GeneralRepository<User, MyContext>
    {
        public UserRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
