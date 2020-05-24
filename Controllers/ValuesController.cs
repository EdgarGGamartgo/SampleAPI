using System;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers

{
    [ApiController]
    [Route("api")]

    public class ValuesController: ControllerBase
    {
        private IPaymentService paymentService { get;set;}

        public ValuesController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        // [HttpPost]
        // public IActionResult Post(ValueRequest request)
        // {
        //     if(ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     return Ok();
        // }

        public string Get()
        {
            Console.WriteLine("I am ValuesController Console Statement");
            return paymentService.GetMessage();
        }

        [HttpGet("values")]
        public ActionResult<string> GetAction(
            [FromServices]IPaymentService paymentService
        )
        {
            Console.WriteLine("I am ValuesController Console Statement");

            return paymentService.GetMessage();
        }

    }
}