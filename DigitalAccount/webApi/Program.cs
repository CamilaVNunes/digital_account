using DigitalAccount.Application.UseCases.AddCustomer;
using DigitalAccount.Domain.Contracts.AddCustomer;
using DigitalAccount.Domain.UseCases.AddCustomer;
using DigitalAccount.Infra.Repository.Repositories.AddCustomer;

namespace DigitalAccount.webApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IAddCustomerRepository, AddCustomerRepository>();
            builder.Services.AddScoped<IAddCustomerUseCase, AddCustomerUseCase>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}