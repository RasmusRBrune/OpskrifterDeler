using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;

namespace OpskrifterDeler.Services
{
    public class AccountService : BaseEntityService<Account, Guid>, IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository repository) : base(repository)
        {
            _accountRepository = repository;
        }
        public async Task<Account> GetAccountByUserId(Guid guid)
        {
            return await _accountRepository.GetAccountByUserId(guid);
        }
        
    }
}
