using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Models;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountServices
    {
        public IEnumerable<Account> GetAccounts();

        public void Transfer(AccountTransfer accountTransfer);
    }
}