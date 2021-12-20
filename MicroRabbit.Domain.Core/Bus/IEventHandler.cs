using System.Threading.Tasks;
using Microrabbit.Domain.Core.Events;

namespace Microrabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : Event

    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {
    }
}