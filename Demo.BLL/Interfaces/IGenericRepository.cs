using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        //Get all Department
        IEnumerable<T> GetAll();

        //Get one Department
        T GetById(int id);

        //Insert a new Department
        int Add(T item);

        //Update a Department
        int Update(T item);

        //Delete a Department
        int Delete(T item);
    }
}
