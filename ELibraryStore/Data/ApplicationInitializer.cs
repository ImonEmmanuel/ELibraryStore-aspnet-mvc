using ELibraryStore.Data.InitialData;
using ELibraryStore.Data.InitialData.Static;
using ELibraryStore.Data.Repository;
using ELibraryStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ELibraryStore.Data
{
    public class ApplicationInitializer 
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
                var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>(); 

                context.Database.EnsureCreated();

                //Actor 
                if (!context.Authors.Any())
                {
                    AuthorData authorData = new AuthorData();
                    foreach (var author in authorData.GetAuthors())
                    {
                        context.Authors.Add(author);
                    }
                    context.SaveChanges();
                }

                //Book Publisher
                if (!context.Publishers.Any())
                {
                    PublisherData publisher = new PublisherData();
                    foreach (var pub in publisher.GetData())
                    {
                        context.Publishers.Add(pub);
                    }
                    context.SaveChanges();
                }

                //BookStore
                if (!context.BookStores.Any())
                {
                    BookStoreData bookStoreData = new BookStoreData();
                    foreach (var booksStore in bookStoreData.GetBookStores())
                    {
                        context.BookStores.Add(booksStore);
                    }
                    context.SaveChanges();
                }

                //Book
                if (!context.Books.Any())
                {
                    BookData bookData = new BookData();
                    foreach (var books in bookData.GetBooks())
                    {
                        context.Books.Add(books);
                    }
                    context.SaveChanges();
                }

                //Book Author
                if (!context.Book_Authors.Any())
                {
                    Book_AuthorData book_AuthorData = new Book_AuthorData();
                    foreach (var book_Author in book_AuthorData.GetBook_Authors())
                    {
                        context.Book_Authors.Add(book_Author);
                    }
                    context.SaveChanges();
                }
        }

        public static async Task SeedUserAndRoleAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                
                //Role
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if(!await roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                }

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                }

                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var adminUser = await userManager.FindByEmailAsync("admin@elibrary.com");

                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = "admin@elibrary.com",
                        EmailConfirmed = true
                    };

                    await userManager.CreateAsync(newAdminUser, "1234567890");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string userEmail = "user@elibrary.com";

                var appUser = await userManager.FindByEmailAsync(userEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "App User",
                        UserName = "app-user",
                        Email = userEmail,
                        EmailConfirmed = true
                    };

                    await userManager.CreateAsync(newAppUser, "1234567890");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }

        }
    }
}
