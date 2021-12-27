using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using Microrabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public static class InfrastructureRegistration
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Domain bus 
            services.AddTransient<IEventBus, RabbitMQBus>();


            //Application Layer
            services.AddTransient<IAccountServices, AccountService>();
            //Data

            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
           
        }
    }
}