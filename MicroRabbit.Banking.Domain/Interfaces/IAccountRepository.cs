using System.Collections;
using System.Collections.Generic;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        public IEnumerable<Account> GetAccounts();
    }
}