using System.Threading.Tasks;
using Microrabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Event;
using MicroRabbit.Transfer.Domain.Interfaces;
using MiroRabbit.Transfer.Domain.Model;

namespace MiroRabbit.Transfer.Domain.EventHandler
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        // private readonly ITransferRepository _transferRepository;
        //
        // public TransferEventHandler(ITransferRepository transferRepository)
        // {
        //     _transferRepository = transferRepository;
        // }

        public Task Handle(TransferCreatedEvent @event)
        {
            // var transferLog = new TransferLog
            // {
            //     FromAccount = @event.FromAccount,
            //     ToAccount = @event.ToAccount,
            //     TransferAmount = @event.Amount
            // };
            // _transferRepository.SaveTransferLog(transferLog);
            return Task.CompletedTask;
        }
    }
}