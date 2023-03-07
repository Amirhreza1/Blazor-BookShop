﻿// <auto-generated />
using Blazor.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blazor.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blazor.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "children's Books",
                            Url = "childrens-books"
                        });
                });

            modelBuilder.Entity("Blazor.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "William Shakespeare",
                            CategoryId = 1,
                            Description = "The Tragedy of Hamlet, Prince of Denmark, often shortened to Hamlet (/ˈhæmlɪt/), is a tragedy written by William Shakespeare sometime between 1599 and 1601. It is Shakespeare's longest play, with 29,551 words. Set in Denmark, the play depicts Prince Hamlet and his attempts to exact revenge against his uncle, Claudius, who has murdered Hamlet's father in order to seize his throne and marry Hamlet's mother.",
                            ISBN = "9780064400558",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1f/Hamlet_Q3_TP_1611.jpg",
                            Price = 320,
                            ReleaseDate = "1623-05-05",
                            Title = "Hamlet"
                        },
                        new
                        {
                            Id = 2,
                            Author = "William H. McRaven",
                            CategoryId = 1,
                            Description = "In Make Your Bed, Admiral William H. McRaven shares 10 life lessons he learned during his Navy Seal training that helped him overcome challenges not only in his long Naval career, but also throughout his life.",
                            ISBN = "9780718188863",
                            ImageUrl = "https://i2.wp.com/www.samuelthomasdavies.com/wp-content/uploads/2017/10/Make-Your-Bed-Summary.png?resize=162%2C225&ssl=1",
                            Price = 350,
                            ReleaseDate = "2017-06-15",
                            Title = "Make Your Bed"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Neville Astley and Mark Baker",
                            CategoryId = 2,
                            Description = "Familjen Gris är på utflykt i skogen, men de är så upptagna av att följa olika spår att de går vilse. Hur ska de hitta tillbaka till picknickkorgen med all mat när magarna kurrar?\r\n",
                            ISBN = "9789177838807",
                            ImageUrl = "https://www.bestories.se/static/files/14/9789177836582.jpg",
                            Price = 350,
                            ReleaseDate = "2020-03-16",
                            Title = "Greta går vilse"
                        },
                        new
                        {
                            Id = 4,
                            Author = " Samantha Shannon",
                            CategoryId = 2,
                            Description = "THE INTERNATIONAL BESTSELLER A world divided. A queendom without an heir. An ancient enemy awakens. 'Epic' Guardian 'Majestic' Daily Mail 'Escapism at its finest - Shannon, we salute you' Stylist An enthralling, epic fantasy about a world on the brink of war with dragons - and the women who must lead the fight to save it.The House of Berethnet has ruled Inys for a thousand years. Still unwed, Queen Sabran the Ninth must conceive a daughter to protect her realm from destruction - but assassins are getting closer to her door. Ead Duryan is an outsider at court. Though she has risen to the position of lady-in-waiting, she is loyal to a hidden society of mages. Ead keeps a watchful eye on Sabran, secretly protecting her with forbidden magic. Across the dark sea, Tane has trained to be a dragonrider since she was a child, but is forced to make a choice that could see her life unravel.",
                            ISBN = "9781408883358",
                            ImageUrl = "https://m.media-amazon.com/images/I/51kzLv7CwTL.jpg",
                            Price = 350,
                            ReleaseDate = "2020-02-06",
                            Title = "The Priory of the Orange Tree"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Robert Greene",
                            CategoryId = 1,
                            Description = "Originally developed for the professional coaches at Coach University for use with their tens of thousands of clients worldwide, Leonard's set of strategies draws on wisdom from psychology, career counselling, management consulting, personal growth programmes, motivational training, and good old common sense. These principles have been proven to work, consistently, with virtually every type of personality, situation, or problem. Now, for the first time, they are available in book form as THE 28 LAWS OF ATTRACTION.",
                            ISBN = "9781416571032",
                            ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQjmKrk4zP357SbDIZvcIz3gNUHLymZed6dSZsVNa-Yqf3YEawB",
                            Price = 230,
                            ReleaseDate = "2008-08-18",
                            Title = "The 28 Laws of Attraction"
                        });
                });

            modelBuilder.Entity("Blazor.Shared.Product", b =>
                {
                    b.HasOne("Blazor.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}