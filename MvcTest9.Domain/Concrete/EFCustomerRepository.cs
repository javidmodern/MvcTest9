using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcTest9.Domain.Abstract;
using MvcTest9.Domain.Entities;
namespace MvcTest9.Domain.Concrete
{
    public class EFCustomerRepository : ICustomerRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<tvCustomer> tvCustomers
        {
            get { return context.tvCustomers; }
        }
    }
}
