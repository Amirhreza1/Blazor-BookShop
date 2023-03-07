using Microsoft.EntityFrameworkCore;

namespace Blazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Category>().HasData(
        new Category
        {
            Id = 1,
            Name = "Books",
            Url = "books"
        },
        new Category
        {
            Id = 2,
            Name = "children's Books",
            Url = "childrens-books"
        });
            modelbuilder.Entity<Product>().HasData(
        new Product
        {
            Id = 1,
            Title = "Hamlet",
            Author = "William Shakespeare",
            Description = "The Tragedy of Hamlet, Prince of Denmark, often shortened to Hamlet (/ˈhæmlɪt/), is a tragedy written by William Shakespeare sometime between 1599 and 1601. It is Shakespeare's longest play, with 29,551 words. Set in Denmark, the play depicts Prince Hamlet and his attempts to exact revenge against his uncle, Claudius, who has murdered Hamlet's father in order to seize his throne and marry Hamlet's mother.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1f/Hamlet_Q3_TP_1611.jpg",
            ReleaseDate = "1623-05-05",
            ISBN = "9780064400558",
            Price = 320,
            CategoryId = 1
        },
        new Product
        {
            Id = 2,
            Title = "Make Your Bed",
            Author = "William H. McRaven",
            Description = "In Make Your Bed, Admiral William H. McRaven shares 10 life lessons he learned during his Navy Seal training that helped him overcome challenges not only in his long Naval career, but also throughout his life.",
            ImageUrl = "https://i2.wp.com/www.samuelthomasdavies.com/wp-content/uploads/2017/10/Make-Your-Bed-Summary.png?resize=162%2C225&ssl=1",
            ReleaseDate = "2017-06-15",
            ISBN = "9780718188863",
            Price = 350,
            CategoryId = 1

        },
        new Product
        {
            Id = 3,
            Title = "Greta går vilse",
            Author = "Neville Astley and Mark Baker",
            Description = "Familjen Gris är på utflykt i skogen, men de är så upptagna av att följa olika spår att de går vilse. Hur ska de hitta tillbaka till picknickkorgen med all mat när magarna kurrar?\r\n",
            ImageUrl = "https://www.bestories.se/static/files/14/9789177836582.jpg",
            ReleaseDate = "2020-03-16",
            ISBN = "9789177838807",
            Price = 350,
            CategoryId = 2

        },
        new Product
        {
            Id = 4,
            Title = "The Priory of the Orange Tree",
            Author = " Samantha Shannon",
            Description = "THE INTERNATIONAL BESTSELLER A world divided. A queendom without an heir. An ancient enemy awakens. 'Epic' Guardian 'Majestic' Daily Mail 'Escapism at its finest - Shannon, we salute you' Stylist An enthralling, epic fantasy about a world on the brink of war with dragons - and the women who must lead the fight to save it.The House of Berethnet has ruled Inys for a thousand years. Still unwed, Queen Sabran the Ninth must conceive a daughter to protect her realm from destruction - but assassins are getting closer to her door. Ead Duryan is an outsider at court. Though she has risen to the position of lady-in-waiting, she is loyal to a hidden society of mages. Ead keeps a watchful eye on Sabran, secretly protecting her with forbidden magic. Across the dark sea, Tane has trained to be a dragonrider since she was a child, but is forced to make a choice that could see her life unravel.",
            ImageUrl = "https://m.media-amazon.com/images/I/51kzLv7CwTL.jpg",
            ReleaseDate = "2020-02-06",
            ISBN = "9781408883358",
            Price = 350,
            CategoryId = 2

        },
        new Product
        {
            Id = 5,
            Title = "The 28 Laws of Attraction",
            Author = "Robert Greene",
            Description = "Originally developed for the professional coaches at Coach University for use with their tens of thousands of clients worldwide, Leonard's set of strategies draws on wisdom from psychology, career counselling, management consulting, personal growth programmes, motivational training, and good old common sense. These principles have been proven to work, consistently, with virtually every type of personality, situation, or problem. Now, for the first time, they are available in book form as THE 28 LAWS OF ATTRACTION.",
            ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQjmKrk4zP357SbDIZvcIz3gNUHLymZed6dSZsVNa-Yqf3YEawB",
            ReleaseDate = "2008-08-18",
            ISBN = "9781416571032",
            Price = 230,
            CategoryId = 1

        });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
