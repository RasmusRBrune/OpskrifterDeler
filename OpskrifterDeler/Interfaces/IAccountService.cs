using OpskrifterDeler.Models;

namespace OpskrifterDeler.Interfaces
{
    public interface IAccountService : IEntityService<Account,Guid>
    {
        Task<Account> GetAccountByUserId(Guid guid);
    }
}
