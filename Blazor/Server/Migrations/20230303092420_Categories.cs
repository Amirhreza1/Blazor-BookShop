using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class Categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Books", "books" },
                    { 2, "children's Books", "childrens-books" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "William Shakespeare", 1, "The Tragedy of Hamlet, Prince of Denmark, often shortened to Hamlet (/ˈhæmlɪt/), is a tragedy written by William Shakespeare sometime between 1599 and 1601. It is Shakespeare's longest play, with 29,551 words. Set in Denmark, the play depicts Prince Hamlet and his attempts to exact revenge against his uncle, Claudius, who has murdered Hamlet's father in order to seize his throne and marry Hamlet's mother.", "9780064400558", "https://upload.wikimedia.org/wikipedia/commons/1/1f/Hamlet_Q3_TP_1611.jpg", 320, "1623-05-05", "Hamlet" },
                    { 2, "William H. McRaven", 1, "In Make Your Bed, Admiral William H. McRaven shares 10 life lessons he learned during his Navy Seal training that helped him overcome challenges not only in his long Naval career, but also throughout his life.", "9780718188863", "https://i2.wp.com/www.samuelthomasdavies.com/wp-content/uploads/2017/10/Make-Your-Bed-Summary.png?resize=162%2C225&ssl=1", 350, "2017-06-15", "Make Your Bed" },
                    { 3, "Neville Astley and Mark Baker", 2, "Familjen Gris är på utflykt i skogen, men de är så upptagna av att följa olika spår att de går vilse. Hur ska de hitta tillbaka till picknickkorgen med all mat när magarna kurrar?\r\n", "9789177838807", "https://www.bestories.se/static/files/14/9789177836582.jpg", 350, "2020-03-16", "Greta går vilse" },
                    { 4, " Samantha Shannon", 2, "THE INTERNATIONAL BESTSELLER A world divided. A queendom without an heir. An ancient enemy awakens. 'Epic' Guardian 'Majestic' Daily Mail 'Escapism at its finest - Shannon, we salute you' Stylist An enthralling, epic fantasy about a world on the brink of war with dragons - and the women who must lead the fight to save it.The House of Berethnet has ruled Inys for a thousand years. Still unwed, Queen Sabran the Ninth must conceive a daughter to protect her realm from destruction - but assassins are getting closer to her door. Ead Duryan is an outsider at court. Though she has risen to the position of lady-in-waiting, she is loyal to a hidden society of mages. Ead keeps a watchful eye on Sabran, secretly protecting her with forbidden magic. Across the dark sea, Tane has trained to be a dragonrider since she was a child, but is forced to make a choice that could see her life unravel.", "9781408883358", "https://m.media-amazon.com/images/I/51kzLv7CwTL.jpg", 350, "2020-02-06", "The Priory of the Orange Tree" },
                    { 5, "Robert Greene", 1, "Originally developed for the professional coaches at Coach University for use with their tens of thousands of clients worldwide, Leonard's set of strategies draws on wisdom from psychology, career counselling, management consulting, personal growth programmes, motivational training, and good old common sense. These principles have been proven to work, consistently, with virtually every type of personality, situation, or problem. Now, for the first time, they are available in book form as THE 28 LAWS OF ATTRACTION.", "9781416571032", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQjmKrk4zP357SbDIZvcIz3gNUHLymZed6dSZsVNa-Yqf3YEawB", 230, "2008-08-18", "The 28 Laws of Attraction" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
