using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosDbPocInfra.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IList<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> DeleteAsync(int id);
        Task<T> UpdateAsync(T entity);
    }
}
