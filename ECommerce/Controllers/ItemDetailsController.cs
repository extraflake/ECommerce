using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Base;
using ECommerce.Models;
using ECommerce.Services.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemDetailsController : BaseController<ItemDetail, ItemDetailService>
    {
        public ItemDetailsController(ItemDetailService itemDetailService) : base(itemDetailService)
        {

        }
    }
}