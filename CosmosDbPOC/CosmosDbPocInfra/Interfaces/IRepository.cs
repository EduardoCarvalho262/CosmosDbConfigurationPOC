﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosDbPocInfra.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(string id);
        Task<T> AddAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
