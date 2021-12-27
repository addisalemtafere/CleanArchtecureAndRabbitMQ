using System;
using Microrabbit.Domain.Core.Events;

namespace Microrabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

        private DateTime TimeStamp { get; }
    }
}