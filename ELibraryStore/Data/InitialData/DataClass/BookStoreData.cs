using ELibraryStore.Models;

namespace ELibraryStore.Data.InitialData
{
    public class BookStoreData
    {
        public List<BookStore> GetBookStores()
        {
            List<BookStore> bookStores = new List<BookStore>()
            {
                new BookStore()
                {
                    Name = "Jumia",
                    Logo = "https://play-lh.googleusercontent.com/2FK9EDMZ7d_nWqptzILVekr_HHU9Oylx9r-R8KNrMCK5J1mpPpyoE95Jsf-eFPWVadc",
                    Description = "Jumia is a Pan-African technology company that is " +
                    "built around a marketplace, logistics service and payment service. " +
                    "The logistics service enables the delivery of packages through a network " +
                    "of local partners while the payment services facilitate the payments of online" +
                    " transactions within Jumia’s ecosystem."
                },
                new BookStore()
                { 
                    Name = "Konga",
                    Logo = "https://nairametrics.com/wp-content/uploads/2021/09/Konga-logo-1-1.jpg?w=900",
                    Description = "Does Konga sell books? Explore our huge selection of books " +
                    "from children's books, fiction, educational books, comics and magazines, " +
                    "non-fiction books, religious and motivational books, business and management, " +
                    "African books, best sellers and more on Konga."
                },
                new BookStore()
                {
                    Name = "Oreily",
                    Logo = "https://www.oreilly.com/content/wp-content/uploads/sites/2/2020/03/orm_logo_1400x950_gray.png",
                    Description = "O'Reilly Media (formerly O'Reilly & Associates) is an American learning company " +
                    "established by Tim O'Reilly that publishes books, produces tech conferences, and provides an " +
                    "online learning platform. Its distinctive brand features a woodcut of an animal on many of its book covers."
                },
                new BookStore()
                {
                    Name = "Amazon",
                    Logo = "https://images-na.ssl-images-amazon.com/images/G/01/gc/designs/livepreview/a_generic_white_10_us_noto_email_v2016_us-main._CB627448186_.png",
                    Description = "Amazon.com, Inc. is an American multinational technology company which" +
                    " focuses on e-commerce, cloud computing, digital streaming, and artificial intelligence. "
                },

                
            };

            return bookStores;
        }
    }
}
