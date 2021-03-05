using Microsoft.AspNetCore.Mvc;
using Payment.DTO;
using Payment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Payment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProcessPaymentController : ControllerBase
    {
        private readonly RepositoryWrapper _repository;
        public ProcessPaymentController(RepositoryWrapper repository)
        {
            _repository = repository;
        }
        // POST api/<ProcessPaymentController>
        [HttpPost]
        public IActionResult Post([FromBody] ProcessPayment value)
        {
            return StatusCode(201, _repository.paymentRepository.makePayment(value));
        }
    }
}
