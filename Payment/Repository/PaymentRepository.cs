using Microsoft.EntityFrameworkCore;
using Payment.ErrorHandling;
using Payment.Interfaces;
using Payment.Mapper;
using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Repository
{
    public class PaymentRepository : GenericRepository<ProcessPayment>, IPaymentRepository
    {
        public PaymentRepository(PaymentDbContext dbContext) : base(dbContext)
        {

        }
        public override async Task<ProcessPayment> GetById(Guid id)
        {
            return await _dbContext.Set<ProcessPayment>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.PaymentId ==  id );
        }
    }
}
