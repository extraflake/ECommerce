using ECommerce.Models;
using ECommerce.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services.Data
{
    public class RoleService : GeneralService<Role, RoleRepository>
    {
        public RoleService(RoleRepository roleRepository) : base(roleRepository)
        {

        }
    }
}
