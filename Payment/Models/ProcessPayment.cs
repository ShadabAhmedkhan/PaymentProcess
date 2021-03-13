using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Models
{
    public class ProcessPayment
    {
        [Key]
        [Column("PaymentId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PaymentId { get; set; }
        [Column("CreditCardNumber")]
        public string CreditCardNumber { get; set; }
        [Column("CardHolder")]
        public string CardHolder { get; set; }
        [Column("ExpirationDate")]
        public DateTime ExpirationDate { get; set; }
        [Column("SecurityCode")]
        public string SecurityCode { get; set; }
        [Column("Amount")]
        public decimal Amount { get; set; }
    }
}
