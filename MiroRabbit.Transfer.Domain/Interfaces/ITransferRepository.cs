using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiroRabbit.Transfer.Domain.Model;

namespace MicroRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        public IEnumerable<TransferLog> GetTransferLogs();
        public Task SaveTransferLog(TransferLog transferLog);
    }
}