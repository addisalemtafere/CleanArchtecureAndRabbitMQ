using System.Collections;
using System.Collections.Generic;
using MiroRabbit.Transfer.Domain.Model;

namespace MiroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        public IEnumerable<TransferLog> GetTransferLogs();
    }
}