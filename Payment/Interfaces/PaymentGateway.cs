using Payment.DTO;
using Payment.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Interfaces
{
    interface PaymentGateway
    {
        ApiException IExpensivePaymentGateway(PaymentRequestDto input);
        ApiException ICheapPaymentGateway(PaymentRequestDto input);
    }
}
