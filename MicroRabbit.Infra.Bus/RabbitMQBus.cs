using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microrabbit.Domain.Core.Bus;
using Microrabbit.Domain.Core.Commands;
using Microrabbit.Domain.Core.Events;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace MicroRabbit.Infra.Bus
{
    public abstract class RabbitMQBus : IEventBus
    {
        private readonly IMediator _mediator;
        private readonly Dictionary<string, List<string>> _handlers;
        private readonly List<Type> _eventTypes;

        protected RabbitMQBus(IMediator mediator)
        {
            _mediator = mediator;
            _handlers = new Dictionary<string, List<string>>();
            _eventTypes = new List<Type>();
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

        public void Publish<T>(T @event) where T : Event
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using (var channel = connection.CreateModel())
            {
                var eventName = @event.GetType().Name;
                channel.QueueDeclare(eventName, false, false, false, null);
                var message = JsonConvert.SerializeObject(@event);
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish("", eventName, null, body);
            }
        }

        public void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T>
        {
            throw new System.NotImplementedException();
        }
    }
}