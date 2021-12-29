using Microsoft.EntityFrameworkCore;
using MiroRabbit.Transfer.Domain.Model;

namespace MiroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public DbSet<TransferLog> TransferLogs { get; set; }

        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}