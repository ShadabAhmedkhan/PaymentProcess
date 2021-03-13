using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Mapper
{
    public class PaymentRequestMapper
    {
        public static ProcessPayment requestPayment(DTO.PaymentRequestDto paymentRequest) {
            var model =new ProcessPayment() {
                Amount = paymentRequest.Amount,
                CardHolder = paymentRequest.CardHolder,
                CreditCardNumber = paymentRequest.CreditCardNumber,
                ExpirationDate = paymentRequest.ExpirationDate,
                SecurityCode = paymentRequest.SecurityCode,
            };
            return model;
        }
    }
}
