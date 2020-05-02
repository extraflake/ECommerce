using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TService> : ControllerBase
        where TEntity : class
        where TService : IService<TEntity>
    {
        private readonly TService _service;

        public BaseController(TService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<TEntity>> Get() => await _service.Get();

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var get = await _service.Get(id);
            if (get == null)
            {
                return NotFound();
            }
            return Ok(get);
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            var post = await _service.Post(entity);
            return Ok(post);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, TEntity entity)
        {
            await _service.Put(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> Delete(int id)
        {
            var delete = await _service.Delete(id);
            if (delete.Equals(0))
            {
                return NotFound();
            }
            return delete;
        }
    }
}