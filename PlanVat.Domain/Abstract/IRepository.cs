using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanVat.Domain.Abstract
{
    interface IRepository<TEntity>
    {
        IQueryable<TEntity> Table { get;}
    }
}
