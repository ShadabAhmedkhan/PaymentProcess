using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Payment.DTO;
using Payment.Repository;
using Payment.Services;
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
        //private readonly RepositoryWrapper _repository;

        private readonly ILogger<ProcessPaymentController> _logger;
        private readonly IPaymentRequestService _paymentRequestService;
        public ProcessPaymentController(  IPaymentRequestService paymentRequestService, ILogger<ProcessPaymentController> logger)
        {
            _logger = logger;
            _paymentRequestService = paymentRequestService;

        }
        [HttpGet]
        public string Get()
        {
            return "Payment Processor is online";
        }
        // POST api/<ProcessPaymentController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentRequestDto paymentRequest)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var paymentState = await _paymentRequestService.Pay(paymentRequest);
                    var paymentResponse = new PaymentResponseDto()
                    {
                        IsProcessed = paymentState.PaymentStateEnum == PaymentStateEnumDto.Processed
                        ,
                        PaymentState = paymentState
                    };

                    if (!paymentResponse.IsProcessed)
                        return StatusCode(500, new { error = "Payment could not be processed" });
                    return Ok(paymentResponse);
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                return StatusCode(500);
            }
        }
    }
}
