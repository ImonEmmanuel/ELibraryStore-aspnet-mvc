using ELibraryStore.Data.Repository;
using ELibraryStore.Models;

namespace ELibraryStore.Data.InitialData
{
    public class PublisherData
    {
        public List<Publisher> GetData()
        {
            List<Publisher> publisher = new List<Publisher>()
            {
                new Publisher()
                {
                    FullName = "University of Ibadan Press",
                    ProfilePictureUrl = "https://images.africanfinancials.com/ng-upl-logo.png",
                    Description = "University Press PLC (UPPLC) was founded in 1949 under the name of " +
                    "Oxford University Press Nigeria, and has grown to become one of the oldest, most experienced " +
                    "and the Nation’s Foremost Publishers of materials for educational and for general reading."
                },

                new Publisher()
                {
                    FullName = "Cambridge University Press",
                    ProfilePictureUrl = "https://landportal.org/sites/landportal.org/files/styles/220heightmax/public/Cambridge20University20Press20Logo_01.png?itok=3rIxR1Hh",
                    Description = "Cambridge University Press is the publishing business of the University of " +
                    "Cambridge. Granted letters patent by King Henry VIII in 1534, it is the oldest university " +
                    "press in the world. It is also the Queen's Printer."
                },

                new Publisher()
                {
                    FullName = "MC Graw Hill",
                    ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/McGraw-Hill_Education_wordmark.svg/1200px-McGraw-Hill_Education_wordmark.svg.png",
                    Description = "McGraw Hill is an American educational publishing company and one " +
                    "of the big three educational publishers that publishes educational content, software" +
                    ", and services for pre-K through postgraduate education"
                },

                new Publisher()
                {
                    FullName = "S Chand Group",
                    ProfilePictureUrl = "https://png.pngitem.com/pimgs/s/195-1953352_s-chand-and-company-background-information-s-chand.png",
                    Description = "S. Chand Group is one of India's oldest and largest publishing and education" +
                    " services companies, founded in 1939 and based in New Delhi. The publishing house prints " +
                    "books for primary, secondary and higher education sectors. It was the first company in " +
                    "India to get the ISO 9001:2000 certification."
                },
            };

            return publisher;
        }
    }
}
