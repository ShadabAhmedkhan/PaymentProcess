﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Payment.Models
{
    public class PaymentState
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Column("State")]
        public string State { get; set; }
        [Column("PPID")]
        public Guid PPID { get; set; }
        public ProcessPayment ProcessPayment { get; set; }
    }
}
