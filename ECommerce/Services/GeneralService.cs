using ECommerce.Context;
using ECommerce.Repositories;
using ECommerce.Repositories.Interface;
using ECommerce.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class GeneralService<TEntity, TService> : IService<TEntity>
        where TEntity : class
        where TService : IRepository<TEntity>
    {
        private readonly GeneralRepository<TEntity, MyContext> _generalRepository;

        public GeneralService(GeneralRepository<TEntity, MyContext> generalRepository)
        {
            _generalRepository = generalRepository;
        }

        public Task<int> Delete(int id)
        {
            return _generalRepository.Delete(id);
        }

        public Task<List<TEntity>> Get()
        {
            return _generalRepository.Get();
        }

        public Task<TEntity> Get(int id)
        {
            return _generalRepository.Get(id);
        }

        public Task<int> Post(TEntity entity)
        {
            return _generalRepository.Post(entity);
        }

        public Task<int> Put(TEntity entity)
        {
            return _generalRepository.Put(entity);
        }
    }
}
