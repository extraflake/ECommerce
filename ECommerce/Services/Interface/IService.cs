using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services.Interface
{
    public interface IService<T> where T : class
    {
        Task<List<T>> Get();
        Task<T> Get(int id);
        Task<int> Post(T entity);
        Task<int> Put(T entity);
        Task<int> Delete(int id);
    }
}
