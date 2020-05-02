using ECommerce.Models;
using ECommerce.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services.Data
{
    public class UserService : GeneralService<User, UserRepository>
    {
        public UserService(UserRepository userRepository) : base(userRepository)
        {

        }
    }
}
