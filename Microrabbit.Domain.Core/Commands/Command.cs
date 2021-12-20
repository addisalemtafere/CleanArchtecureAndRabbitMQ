using System;
using Microrabbit.Domain.Core.Events;

namespace Microrabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        private DateTime TimeStamp { get; set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}