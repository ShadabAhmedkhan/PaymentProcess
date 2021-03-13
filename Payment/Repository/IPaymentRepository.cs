using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Repository
{
    public interface IPaymentRepository : IGenericRepository<ProcessPayment>
    {
    }
}
