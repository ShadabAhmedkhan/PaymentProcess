using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.DTO
{
    public class PaymentStateDto
    {
        public PaymentStateEnumDto PaymentStateEnum { get; set; }
        public DateTime PaymentStateDate { get; set; }
    }
}
