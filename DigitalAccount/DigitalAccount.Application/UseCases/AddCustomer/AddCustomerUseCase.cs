using DigitalAccount.Domain.Contracts.AddCustomer;
using DigitalAccount.Domain.Entities;
using DigitalAccount.Domain.UseCases.AddCustomer;

namespace DigitalAccount.Application.UseCases.AddCustomer
{
    public class AddCustomerUseCase : IAddCustomerUseCase
    {
        private readonly IAddCustomerRepository _addCustomerRepository;

        public AddCustomerUseCase(IAddCustomerRepository addCustomerRepository)
        {
            _addCustomerRepository = addCustomerRepository;
        }

        public void AddCustomer(Customer customer)
        {
            _addCustomerRepository.AddCustomer(customer);
        }
    }
}
