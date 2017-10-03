using System.Linq;

namespace AspDotNetCoreMvcDocker.Models
{
    public interface IRepository
    {
        IQueryable<Book> Books { get; }
    }
}