using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandler;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Event;
using MicroRabbit.Banking.Domain.Interfaces;
using Microrabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Transfer.Application.Services;
using MicroRabbit.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using MiroRabbit.Transfer.Application.Interfaces;
using MiroRabbit.Transfer.Data.Context;
using MiroRabbit.Transfer.Domain.EventHandler;

namespace MicroRabbit.Infra.IoC
{
    public static class InfrastructureRegistration
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Domain bus 
            services.AddTransient<IEventBus, RabbitMQBus>();


            //Domain transfer event 
            services
                .AddTransient<IEventHandler<MicroRabbit.Transfer.Domain.Event.TransferCreatedEvent>,
                    TransferEventHandler>();

            //Domain banking command 
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Application Layer
            services.AddTransient<IAccountServices, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Data

            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}