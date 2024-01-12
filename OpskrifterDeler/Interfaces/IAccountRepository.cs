using OpskrifterDeler.Models;

namespace OpskrifterDeler.Interfaces
{
    public interface IAccountRepository : IEntityRepository<Account>
    {
        Task<Account> GetAccountByUserId(Guid guid);
    }
}
