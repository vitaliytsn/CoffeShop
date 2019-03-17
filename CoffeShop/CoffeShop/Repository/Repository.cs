using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace CoffeShop.Repository
{
    public class Repository<T, TContext> : IRepository<T, TContext> where T : class where TContext : DbContext
    {
        private const int _constraintErrorNumber = 547;
        protected DbContext _dbContext;

        public List<string> CoughtConstraints { get; set; }

        public Repository(TContext dbContext)
        {
            _dbContext = dbContext;
            CoughtConstraints = new List<string>();
        }

        public bool Add(T item)
        {
            _dbContext.Set<T>().Add(item);
            try
            {
                _dbContext.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                var sqlException = e.InnerException.InnerException as SqlException;
                string tableName = ((TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute))).Name;
                if (sqlException != null && sqlException.Number.Equals(_constraintErrorNumber) && CheckMessageForConstraints(sqlException.Message, CoughtConstraints) && sqlException.Message.Contains(_dbContext.Database.GetDbConnection().Database) && sqlException.Message.Contains(tableName))
                    return false;
                else
                    throw e;
            }
            return true;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IQueryable<T> GetByQuery(Func<T, bool> query)
        {
            //_dbContext.Database.Log = message => Trace.WriteLine(message);
            return _dbContext.Set<T>().Where(query).AsQueryable();
        }

        public void Remove(T item)
        {
            _dbContext.Set<T>().Remove(item);
            _dbContext.SaveChanges();
        }

        public void Update(T item)
        {
            _dbContext.Entry(item).CurrentValues.SetValues(item);
            _dbContext.SaveChanges();
        }

        private bool CheckMessageForConstraints(string message, IEnumerable<string> constraints)
        {
            if (constraints.Where((constraint) => message.Contains(constraint)).Count() > 0)
                return true;
            else
                return false;
        }
    }
}