using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    class EfCustomerDal : EfEntityRepositoryBase<Customer, NortwindContext>,ICustomerDal
    {
        
    }
}
