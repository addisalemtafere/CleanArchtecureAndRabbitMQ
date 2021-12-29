using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Domain.Interfaces;
using MiroRabbit.Transfer.Data.Context;
using MiroRabbit.Transfer.Domain.Model;


namespace MicroRabbit.Banking.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }

        public async Task SaveTransferLog(TransferLog transferLog)
        {
            _ctx.TransferLogs.Add(transferLog);
            _ctx.SaveChangesAsync();
        }
    }
}