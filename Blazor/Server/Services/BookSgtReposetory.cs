using Blazor.Server.Services.Model;
using MongoDB.Driver;

namespace Blazor.Server.Services
{
    public class BookSgtReposetory : IReposetory<BookSegesstion>
    {
        private readonly IMongoCollection<BookSgtModel> _chatCollection;

        public BookSgtReposetory()
        {

            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://amirhrezai8:M9mpr3Jpraj5EVNO@cluster0.mu2p4bs.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("BookSegesstion");


            //var host = "localhost";
            //var databaseName = "BookSegesstion";
            //var connectionString = $"mongodb://{host}:27017";

            //var client = new MongoClient(connectionString);
            //var database = client.GetDatabase(databaseName);
            _chatCollection = database.GetCollection<BookSgtModel>
                ("Messages", new() { AssignIdOnInsert = true });
        }

        public async Task AddAsync(BookSegesstion entity)
        {
            await _chatCollection.InsertOneAsync(new BookSgtModel()
            {
                Sender = entity.Name,
                Message = entity.Message,
                TimeSent = entity.TimeSent
            });
        }

        public async Task DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<BookSegesstion> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookSegesstion>> GetAllAsync()
        {
            var filter = Builders<BookSgtModel>.Filter.Empty;
            var allMessages = await _chatCollection.FindAsync(filter);

            return allMessages.ToEnumerable()
                .Select(m => new BookSegesstion()
                {
                    Name = m.Sender,
                    Message = m.Message,
                    TimeSent = m.TimeSent
                });
        }

        public async Task<BookSegesstion> UpdateAsync(BookSegesstion entity)
        {
            throw new NotImplementedException();
        }
    }
}
