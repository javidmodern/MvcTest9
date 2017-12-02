using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcTest9.Domain.Entities;
namespace MvcTest9.Domain.Abstract
{
    public interface ICustomerRepository
    {
        IEnumerable<tvCustomer> tvCustomers { get; }
    }
}
