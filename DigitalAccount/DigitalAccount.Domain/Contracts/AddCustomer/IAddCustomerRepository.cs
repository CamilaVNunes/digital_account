using DigitalAccount.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAccount.Domain.Contracts.AddCustomer
{
    public interface IAddCustomerRepository
    {
        void AddCustomer(Customer customer);
    }
}
