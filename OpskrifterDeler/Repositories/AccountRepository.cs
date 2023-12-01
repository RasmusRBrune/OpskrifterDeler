using Microsoft.EntityFrameworkCore;
using OpskrifterDeler.DBContext;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;
using System.Linq.Expressions;
using System.Security.Principal;

namespace OpskrifterDeler.Repositories
{
    public class AccountRepository : BaseEntityRepository<Account>, IAccountRepository
    {
        public AccountRepository(DBDataContext context) : base(context)
        {
        }
        //public override Task<IEnumerable<Account>> GetAllWithIncludeAsync(Expression<Func<Account, bool>> expression = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public override async Task<Account> GetSingleWithIncludeAsync(Expression<Func<Account, bool>> expression)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
