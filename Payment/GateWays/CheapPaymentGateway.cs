using Payment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.GateWays
{
    public class CheapPaymentGateway : ICheapPaymentGateway
    {
        public PaymentStateDto ProcessPayment(PaymentRequestDto paymentRequest)
        {
            Random rnd = new Random();
            var num = rnd.Next(1, 12);
            if (num % 4 == 0 || num % 6 == 0)
                throw new Exception("Call failed");
            if (num % 2 == 0)
                return new PaymentStateDto() { PaymentStateEnum = PaymentStateEnumDto.Failed, PaymentStateDate = DateTime.UtcNow };
            else return new PaymentStateDto() { PaymentStateEnum = PaymentStateEnumDto.Processed, PaymentStateDate = DateTime.UtcNow };
        }

       
    }
}
