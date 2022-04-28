using Microsoft.EntityFrameworkCore;
using elsBlog.Models;

namespace elsBlog.Context
{
    public class AuthorContext
        : DbContext
    {
        public AuthorContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
    }
}