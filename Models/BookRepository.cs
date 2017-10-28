using System.Linq;
namespace AspDotNetCoreMvcDocker.Models
{
    public class BookRepository : IRepository
    {
        private BookDbContext context;
        public BookRepository(BookDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Book> Books => context.Books;
    }
}