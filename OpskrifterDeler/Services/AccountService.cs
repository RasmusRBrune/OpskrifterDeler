using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;

namespace OpskrifterDeler.Services
{
    public class AccountService : BaseEntityService<Account, Guid>, IAccountService
    {
        public AccountService(IAccountRepository repository) : base(repository)
        {
        }
    }
}
