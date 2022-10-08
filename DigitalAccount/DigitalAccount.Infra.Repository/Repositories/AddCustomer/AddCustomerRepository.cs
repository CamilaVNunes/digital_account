using DigitalAccount.Domain.Contracts.AddCustomer;
using DigitalAccount.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAccount.Infra.Repository.Repositories.AddCustomer
{
    public class AddCustomerRepository : IAddCustomerRepository
    {
        private readonly IList<Customer> _customerList = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            _customerList.Add(customer);
        }
    }
}
