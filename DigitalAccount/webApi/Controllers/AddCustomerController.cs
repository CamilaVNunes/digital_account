using Microsoft.AspNetCore.Mvc;
using DigitalAccount.webApi.Models.AddCustomer;
using DigitalAccount.Domain.UseCases.AddCustomer;
using DigitalAccount.Domain.Entities;

namespace DigitalAccount.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        private readonly IAddCustomerUseCase _addCustomerUseCase;

        public AddCustomerController(IAddCustomerUseCase addCustomerUseCase)
        {
            _addCustomerUseCase = addCustomerUseCase;
        }

        [HttpPost]
        public IActionResult AddCustomer(AddCustomerInput input)
        {
            var customer = new Customer(
                                    input.Name, 
                                    input.Email, 
                                    input.Document
                               );

            _addCustomerUseCase.AddCustomer(customer);
            return Created("", customer);
        }
    }
}
