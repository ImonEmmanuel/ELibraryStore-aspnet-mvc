using ELibraryStore.Models;
using ELibraryStore.Models.PaymentData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ELibraryStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>().HasKey(bm => new
            {
                bm.AuthorId,
                bm.BookId
            });

            modelBuilder.Entity<Book_Author>().HasOne(m => m.Book).WithMany(
                bm => bm.Book_Authors).HasForeignKey(m => m.BookId);

            modelBuilder.Entity<Book_Author>().HasOne(m => m.Author).WithMany(
                bm => bm.Book_Authors).HasForeignKey(m => m.AuthorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookStore> BookStores { get; set; }
        public DbSet<Book_Author> Book_Authors { get; set; }

        //Order Set
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set;  }
        public DbSet<ShopingCartItem> ShopingCartItems { get; set; }

        //Transactions
        public DbSet<Transaction> Transactions { get; set;  }
    }
}
