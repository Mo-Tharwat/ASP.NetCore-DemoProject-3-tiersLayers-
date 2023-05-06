using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositors
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {

        //use Dependance Injection DbContext
        public DepartmentRepository(MVCAppDbContext dbContext):base(dbContext)
        {

        }

    }
}
