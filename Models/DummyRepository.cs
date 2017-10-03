using System.Linq;

namespace AspDotNetCoreMvcDocker.Models
{
    public class DummyRepository : IRepository
    {
        private static Book[] DummyData = new Book[] {
        new Book { Name = "Book1", Category = "Cat1", Price = 103 },
        new Book { Name = "Book2", Category = "Cat1", Price = 104 },
        new Book { Name = "Book3", Category = "Cat2", Price = 99 },
        new Book { Name = "Book4", Category = "Cat2", Price = 48 },
        };
        public IQueryable<Book> Books => DummyData.AsQueryable();
    }
}