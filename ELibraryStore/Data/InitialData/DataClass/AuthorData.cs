using ELibraryStore.Models;

namespace ELibraryStore.Data.InitialData
{
    public class AuthorData 
    {
        public List<Author> GetAuthors()
        {
            List<Author> author = new List<Author>()
            {
                new Author()
                {
                    FullName = "Matthew N Sadiku",
                    Biography = "Dr. Sadiku is a professor of Electrical Engineering at Prairie View A&M University (Prairie View, Texas), and Fellow of IEEE.",
                    ProfilePictureUrl = "https://images.gr-assets.com/authors/1489877027p8/390238.jpg"

                },
                new Author()
                {
                    FullName = "Chinua Achebe",
                    Biography = "Nigerian novelist, poet, and critic who is regarded as the dominant figure of modern African literature",
                    ProfilePictureUrl = "https://www.thoughtco.com/thmb/8S4Jyj0UIaDrPzj2YO3nXJVW6io=/1667x1667/smart/filters:no_upscale()/ChinuaAchebe-5bb4b3cdc9e77c0026d2927e.jpg"
                },
                new Author()
                {
                    FullName = "R.K Rajput",
                    Biography = "R K Rajput is the author of books such as Strength Of Materials.",
                    ProfilePictureUrl = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxAQEBUQEBIPFQ8VDw8PEA8PDw8PEA8QFRUWFhURFRUYHSggGBolGxUVITEhJSkrLi4uFx8zODMtNygtLisBCgoKDg0OGhAQGi0lHSUtLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0rLS0tLS0tLf/AABEIAQMAwgMBIgACEQEDEQH/xAAcAAACAwEBAQEAAAAAAAAAAAAAAgEDBAUGBwj/xAA3EAACAgECBQIEBAQFBQAAAAAAAQIRAwQhBRIxQVFhcQYigaETkbHRIzLB8BQzQlJiB3KDkqL/xAAZAQEBAQEBAQAAAAAAAAAAAAAAAQIDBAX/xAAiEQEAAwACAgICAwAAAAAAAAAAAQIRAyESMRNBBGEUMlH/2gAMAwEAAhEDEQA/APkrIQzFObX2ujJCSe5KoiRl0OmJMeJMugXNhncA5GX86FeQdteFfuVPKHKTKZW5s1jhOGkiFQnMybHpJWCtEJjGkI0K0WMWiYK2AwrIoYEAUQyUgBIiIYJEk0BABTAdjZEGicYTDSYsHsQtiGTGtWRZMpbUJF0TY8TyxEipseTsVmohLW0jQtFvKJJBglE0Ook8owQkSSFmgrEHZBJCNCjtCtEWEENEgARHFiORCtEkkEE0QMAwXQCYRQSLjRAADTIJsEiaAgIxsaMTdo9Ne/5GbWyHTjpNpxRHBsZ5wpnplw/5fU5Ws0fK6OVOXZenl4MjpzaBl7wMR46O+w8k0mFTFLGhQyUGhqCgK2KPJCtECgSQFShkKiSImwIJYAAABcDYzoRlhZQSkBKKhgEHgtyjTpsPMzvaXB0Rj4djOxhjR4ea+zj6n43HEV1sx4kV6vSqS2W5fjY8sbZw16up6efyaPwtjPn0FrdHoli8iZdPfQsckwfHWfbx2fRtGWWNnq9To6Ry82FI9HHz/wCvHy/i1+nG5WMovwbtieVHX5P04xwftzcsWU2b9XEwyRus7GvPyV8bYVkMYWjTmIkggIAkgkCAJAC6UWQh3NglZdazSgh1AhxGwTWYRQ0WNHGX6PDb3VpEm0Q1WkzMQ6PCJ9Tbn1fJ7mLQYXGbXZ9CzVYLds8d4ibvo0m0cefZsXGZLr+5rwcfd7x2707o5ThCtoyaXV06V+X2K443fyq0t3XzUvWjc1pMOUWvE+3rNProz9yc+rUP6HM4Rj5nuW8TaWx5bRk491ZnxYOJcSldKvVnGnlnLya8kJSlSTb7JdyM3PhlyONS22rd30ryevjiIjqO3h5dme5YXGRbikyzNKV1KO/0Y6hsatbrtmlMnqWbVdDC42b88bQunwqrfsbrOVc+Sk2vjnyQpo1cal+TKDcTsa89oycSQSQwyAAAJAgANSdlsYFMNy2K3/clnanpE35RZHHtbYmU04q5fL9jEzkN1jZ7KsbravoX6DZ0++y9WLhlHo1KvKrYu00IJ3J97ttI5zPUw7U/tEw34G3PfsqOlGCkqaRkWNWpLvuzrabGqPPaY17aVlStGkmkuqqSX8sl4a6MxR4fy7R2Xo3+p2FGXbcvwad9WieUxCzSHO0+mcWYOKR8+TuJ29jl8ZxdzET3265kZDkQw31W3kv/AMN9ug2idujVLA0dJtLlFInty8+Ey5LqjrZMXkxaiJa2YtTHOmrJxbRHa3EyfLFt972O+9Y82ZMy5ueVyb9StjMU9OY+fM7OgCSAiAACAAKAaNsHTHhlSd0VS3IRM123PS7LJPdX7MvgnWxkUR4TfRszNeumq377aYSS6pmrTuPeLf0Rn0spLozSpyv19jlZ6OPvt2NMvk26J9PB0sL2RxdJqZR+WXR0ro6+Dwea8PbSXW09UJq8tqkV4p0t+gmp12OMWnXTfoYjZbm0Qt0OJXuzFxfEmm00cJcWljk3H+Vt/K5Pp79mU67i85qkkk+u7bXodPhvrl/IpkymMakmvJ2scrW55XTamnudfR8RT+Xv29TXJS0M8XNWWjVs5mQ3ap9zBMxRvklmq2Z+Jy5Vy93+nkfWSaja6+Tlzk27bbflu2evjpvbwc3J4xNfuSsgYg9DxIIGIoCAACAAAA3QxjSxgpbjzZz2deqMxTQJblimqoWJqNc5xfh23R0tGuZ7nPxbdTpaW6uPX1OXJD0cNsaZ46OpjeyfociOeXddOpt4dqOe4+N17HGaTj115I0/E9W4wpdTzmTK2+56HXYHNbdTHp+E95I6cXjWvbhzRa9uvTmx0smr7e+5Zl0dR67nosWixVuqdbU+pn1Wkxpbda82J5Jda/j18XlZ4JIMEmpXv1OxLAr/AGIejXVr6Gvlj7eeeDvYS8ja3KGWTFa2OMVeibOXxJ9EYDRq580m+3RFFHspGQ+Zy28raVkDNEUbc0ASQBDAkCYFAkCDoqAZG+4qmP1GNzYsY2adPhuWxVCJ6/4Zw8kFkS3v80LdQVnXKwaWKadL36lsVUrXQ7/xNoVyrPjjSf8AmJLp/wAq/U5GjxcyruYmNjXbinsuXCnv3rqh+D8MnkzQhj/nlKl4S/1N+iVnX4VwaWR3L+Tst7Z9B+DuBRxyeXkUXXLG4pNLv9/0Fa/TXJyvn2p0rhJxkvmi3FrruhVE9B8VYEtXlro5J/XlX7HHUPHU43p278d+omWWehb8oyajRe/3OxHO4mPLnbvY49+ndypYKKciNmWTb6GaeNlyZSZxinGyrNHavp6GyS8FGph8r9mdIcbetcGeOm01um014aKWj0/xLwiWOGHPW2TFjjk26ZVFb/VfoeclE9kPnSoaILXEWghCKHaIoBSBgoBSSaADowxGnBpXJ0k2/Y6/CuCZc8+TFFyl3f8ApivLf9D6L8PfA34avM1fhfuaxHgeHfDc5bz2Xp/e56zhvC1GKhBNr03Pc4eB4I/6U/c2fgRgvljFL2JMasTjzeDg8543jlGotVUjNw74Cxwd5Mk5f8YpQTXr3+57NqTSew0IuyxEQvlLl4tLDCuWGOKivC3O7oYrkVGRx+bdbGvRtLYso8r8ZcGk5PUQTcWksqW7jXSft58HisuOtz7Q0ec4v8JYstyxP8Kb3aS5sbf/AG9vocbU3uHo4ubxjJfM5ZDLlyrz9jv8c4Bm01PLFcrfKskJc0G+yfdfkcPLpDhbp6qZaOmKeZf2jPO5dfyRvemNGl4Xly/5WOc/WEW4/wDt0+5N3014xHtyViN3BuDPVZaa/gwalll2dbrGvV9/T3R6XQ/Bk5U88lCPfHjfNN+jl0j9L9z0um0MMUFjxxUYLol9233b8s3Tjn3Lhy80ZkOJxLQRy45QlGLT7NJr02PE8T+Cm1zYNn1eJ219H1X3Po+rjSpdXsjlrT37p7Puju8kw+Q63huXE/4kHH16xf1McsZ9szaWMlWRWu8quS/c85xP4Lxzt4/lfaWPp9YftRWZh8zcRXE9HxD4X1OK6jzx/wB2Pr9Yvf8AKziywtOmmn3TVNfRlRkaIL5QK3AgSiBuUAP1LwvhOHTQ5MMFFfd+vubOQu5CGjQrSEyR2LuUnkKKcfQsxhy0NFECzhvY2NDtEJAXYslrcczJ1IuIryv/AFHv/Cxrp+NC/Tx9zwKybH2HXaOGbHLHkVwapo8rrvgzE3/BySxvxJPLF/m01+ZzvTyejh5vDpwPhLQ48uXI8kFJQhBxUlcVKTlvXRv5T2+JfLRj4TwRaSEvn55Tkm5cvLSS2VX5b/M2c1LoK08WeS/lOocTPLb38Fkptgse1m3Jzniblb/v0M+bCk9vJ15QSRj/AArYNYnjEWm8nQljBQKjE8CfVJ+/X8zBr+AabOqyY0/Wt16p9ju/hC/hAfO+Kf8AT2O70+Rp/wCyfzJ/1+55HiHw5qcV82NtLq4b/Wup9vy4Dn6nTpqpJNfdfUJj4S8f9vYD7G+D4nvb/JAE7fUaIaAlIKKJoCShaDlJQMCKFaHICq8q7kxkN2EgBY3aMmri+dNdNjbBbCTxWQZ8sbrwYs3zSqPT+9zVq7SpdXsL+Byr9WBTHFQmRluSdFHVgVZBEi7KuwjQFcYDcg6QSARRFou5aRGOIRW4GfLgNkyqTA5z03p9iDo8gBXokOhYoayoGCCwsAIZIMBUwICwpolOaNbotsjKrQFmF2rHaM+DZFyZBRnx3JPwinPKkasjObqZ2wKZMlKlY+PGGbwBTXcOXYeERpoIpSIjG2PKJNUgKsj3osiqQuKNux8zpFFDZSnbGk9iqD/SyCZZ0nXqBlcb3AD2FjCElAQPQtACGZWx0wIaFQ4rAVssXQqZbi3AiMAiq39C+ivLsmRWXU5aRijG2PkfMy3FAASpGeTNGVmddSoeCFY5CQCqJVmZdkdFeONsB8cKRm1Et6NWaVIwt27IK5vcpcuv5DJ7v2KL292BfHHsvZAWqL8MgDvwnbLzFj632o2RZRIAAENCjisAIZJACFuAqkizAwNBVqP5X7FllGrfysisGKNmiIiVJId7IqM+di449wnu6LGqQC0D2GoqySArm7LoKkJCJOWVIDPqZmfI6Q83uZs8yCrm2Yq6JepE3sRhdziuy3YHZWVLbxsBgeV+QA7Oklao2Y2cvS5Kl6HUiUWABFgS2KySAIZBLIABsXcQtxrYB0yrVPYuiijV9CDNjVsbM9h4RpFOZ3sUV4Y9yxjRjSohgVyZVRZIWig6GfNMtnIy5JEFc2Y8j3Ls0jLNkUs5FOLLeVRXZOcvZdPu4/kRqMqinJ9Em/yM/Anzc+V/zOXL7RSTS/8AqyDq8wFYFTXU07Ozp3svYAKLkSAAQyGAAKAAAIvxdCAAdFGq7ABAkuhQuoAUWMqmAFgIxJABBRMzZAASMmbqZpgBByePP+HXZzin69X+qRd8NRrB/wCSf9CAA69AAAf/2Q=="
                },
                new Author()
                {
                    FullName = "John C Maxwell",
                    Biography = "John Calvin Maxwell is an American author, speaker," +
                    "and pastor who has written many books, primarily focusing on leadership",
                    ProfilePictureUrl = "https://images.gr-assets.com/authors/1492314822p8/68.jpg"
                },
                new Author()
                {
                    FullName = "William Stallings",
                    Biography = "William Stallings is an American author. He has written computer science " +
                    "textbooks on operating systems, computer networks, computer organization, and cryptography",
                    ProfilePictureUrl = "https://www.computerhope.com/people/pictures/william_stallings.jpg"
                }
            };
            return author;
        }
    }
}
