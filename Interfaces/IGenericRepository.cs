﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tessa.Entities;
using Tessa.Specifications;

namespace Tessa.Interfaces
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
    }
}
