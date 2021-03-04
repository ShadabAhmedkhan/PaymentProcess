using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Repository
{
    public class RepositoryWrapper
    {
        private PaymentDbContext _repoContext;
        private PaymentRepository _paymentRepositoryRepo;

        public PaymentRepository paymentRepository
        {
            get
            {
                if (_paymentRepositoryRepo == null)
                {
                    _paymentRepositoryRepo = new PaymentRepository(_repoContext);
                }

                return _paymentRepositoryRepo;
            }
        }
        public RepositoryWrapper(PaymentDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
