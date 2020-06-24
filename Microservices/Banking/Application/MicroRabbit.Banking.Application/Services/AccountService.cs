using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;
namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accoutRepository;

        public AccountService(IAccountRepository accoutRepository)
        {
            _accoutRepository = accoutRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accoutRepository.GetAccounts();
        }
    }
}