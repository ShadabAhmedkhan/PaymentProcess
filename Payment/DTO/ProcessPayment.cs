﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.DTO
{
    public class ProcessPayment
    {
        public string CreditCardNumber { get; set; }
        public string CardHolder { get; set; }
        public DateTime  ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
        public decimal Amount { get; set; }
    }
}
