using Payment.ErrorHandling;
using Payment.Interfaces;
using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Repository
{
    public class PaymentRepository : PaymentGateway
    {
        private readonly PaymentDbContext _context;

        public PaymentRepository(PaymentDbContext context)
        {
            _context = context;

        }
        public DTO.ProcessPayment makePayment(DTO.ProcessPayment input)
        {
            return input;
        }
        public ApiException ICheapPaymentGateway(DTO.ProcessPayment input)
        {
            throw new NotImplementedException();
        }

        public ApiException IExpensivePaymentGateway(DTO.ProcessPayment input)
        {
            throw new NotImplementedException();
        }
    }
}
