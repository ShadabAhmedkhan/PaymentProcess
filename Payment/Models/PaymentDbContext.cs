using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Models
{
    public class PaymentDbContext :  DbContext
    {
        public PaymentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ProcessPayment> ProcessPayment { get; set; }
        public  DbSet<PaymentState> PaymentState { get; set; }
        

    }
}
