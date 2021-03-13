using Payment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Services
{
    public interface IPaymentRequestService
    {
        Task<PaymentStateDto> Pay(PaymentRequestDto paymentRequestDto);
    }
}
