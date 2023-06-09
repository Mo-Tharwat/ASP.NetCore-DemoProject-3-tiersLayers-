﻿using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositors
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        //private readonly MVCAppDbContext _dbContext;

        public EmployeeRepository(MVCAppDbContext dbContext) : base(dbContext)
        {
            ///Becaue this class inherent from Genaraic repositry (private protected)_dbcontex
            ///_dbContext = dbContext;
        }
        public IQueryable<Employee> GetEmployeesByAddress(string address)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employee> SearchEmployeesByName(string name)
            => _dbContext.Employees.Where(E => E.Name.ToLower().Contains(name.ToLower()));
    }
}
