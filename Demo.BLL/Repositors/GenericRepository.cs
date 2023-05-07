using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositors
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //Attribute for DBContext
        private protected readonly MVCAppDbContext _dbContext;

        //use Dependance Injection DbContext
        public GenericRepository(MVCAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(T item) => _dbContext.Set<T>().Add(item);


        public void Delete(T item) => _dbContext.Set<T>().Remove(item);


        public IEnumerable<T> GetAll()
        {
            if(typeof(T) == typeof(Employee))
                return (IEnumerable<T>) _dbContext.Employees.Include(E => E.Department).ToList();
            else
                return _dbContext.Set<T>().ToList();
        }
            //=> _dbContext.Set<T>().Distinct().ToList();

        public T GetById(int id) => _dbContext.Set<T>().Find(id);

        public void Update(T item) => _dbContext.Set<T>().Update(item);
    }
}
