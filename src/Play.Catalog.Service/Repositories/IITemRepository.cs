using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Play.Catalog.Service.Entities;

namespace Play.Catalog.Service.Repositories
{
    public interface IItemRepository
    {
        Task<IReadOnlyCollection<Item>> GetAllAsync();
        Task<Item> GetAsync(Guid id);
        Task CreateAsync(Item entity);
        Task UpdateAsync(Item entity);
        Task RemoveAsync(Guid id);
    }
}