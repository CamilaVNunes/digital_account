using DigitalAccount.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAccount.Domain.UseCases.AddCustomer
{
    public interface IAddCustomerUseCase
    {
        void AddCustomer(Customer customer);
    }
}
