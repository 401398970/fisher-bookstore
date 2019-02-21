using Microsoft.EntityFrameworkCore;

namespace Fisher.Bookstore.Models
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstroeContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    }
    
}