using FluentValidation;

namespace DigitalAccount.webApi.Models.AddCustomer
{
    public class AddCustomerInputValidator : AbstractValidator<AddCustomerInput>
    {
        public AddCustomerInputValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("'Nome' não é um nome válido ou está vazio.");
            RuleFor(c => c.Email).EmailAddress().WithMessage("'Email' não é um email válido.");
            RuleFor(c => c.Document).IsValidCPF().WithMessage("'Documento' não é um CPF válido.");
        }
    }
}
