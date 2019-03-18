using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace CoffeShop.Repository
{
    public interface IRepository<T, TContext> where T : IRepoEntity where TContext : DbContext
    {
        List<string> CoughtConstraints { get; set; }
        IEnumerable<T> GetAll();
        T GetByID(int id);
        IQueryable<T> GetByQuery(Func<T, bool> query);
        bool Add(T item);
        void Update(T item);
        void Remove(T item);
    }
}