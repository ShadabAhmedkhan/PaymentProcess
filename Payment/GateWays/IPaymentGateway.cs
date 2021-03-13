using Payment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.GateWays
{
    public interface IPaymentGateway
    {
        PaymentStateDto ProcessPayment(PaymentRequestDto paymentRequest);
    }
}
