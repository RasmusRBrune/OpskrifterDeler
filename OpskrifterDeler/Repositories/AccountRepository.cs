using Microsoft.EntityFrameworkCore;
using OpskrifterDeler.Data;
using OpskrifterDeler.DBContext;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;
using System.Linq.Expressions;
using System.Security.Principal;

namespace OpskrifterDeler.Repositories
{
    public class AccountRepository : BaseEntityRepository<Account>, IAccountRepository
    {

        private readonly OpskrifterDelerContext _dbContext;

        public AccountRepository(OpskrifterDelerContext context) : base(context)
        {
            _dbContext = context;
        }
        public override Task<IEnumerable<Account>> GetAllWithIncludeAsync(Expression<Func<Account, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public override  Task<Account> GetSingleWithIncludeAsync(Expression<Func<Account, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<Account> GetAccountByUserId(Guid guid)
        {
            var holder = await _dbContext.Accounts.FirstOrDefaultAsync(x => x.AccountId == guid);
            return holder;
        }
    }
}
