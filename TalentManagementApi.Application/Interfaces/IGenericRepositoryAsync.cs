﻿using LinqKit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TalentManagementApi.Application.Interfaces
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task BulkInsertAsync(IEnumerable<T> entities);

        Task<IEnumerable<T>> GetPagedResponseAsync(int pageNumber, int pageSize);

        Task<IEnumerable<T>> GetPagedAdvancedResponseAsync(int pageNumber, int pageSize, string orderBy, string fields, ExpressionStarter<T> predicate);

        Task<IEnumerable<T>> GetAllShapeAsync(string orderBy, string fields);
        Task<IEnumerable<T>> GetAllShapeAsync(string orderBy, string orderType, string fields);
    }
}