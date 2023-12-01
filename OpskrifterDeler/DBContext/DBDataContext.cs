using Microsoft.EntityFrameworkCore;

namespace OpskrifterDeler.DBContext
{
    public class DBDataContext : DbContext
    {
        public DBDataContext(DbContextOptions<DBDataContext> options) : base(options)
        {
        }
    }
}
