using Microsoft.EntityFrameworkCore;
using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Repository
{
    public class PaymentStateRepository : GenericRepository<PaymentState>, IPaymentStateRepository
    {
        public PaymentStateRepository(PaymentDbContext dbContext) : base(dbContext)
        {

        }
        public override async Task<PaymentState> GetById(Guid id)
        {
            return await _dbContext.Set<PaymentState>()
               .AsNoTracking()
               .FirstOrDefaultAsync(e => e.PaymentId == id);
        }
    }
}
