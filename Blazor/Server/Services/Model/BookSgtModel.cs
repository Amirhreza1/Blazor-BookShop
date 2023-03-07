using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Blazor.Server.Services.Model
{
    public class BookSgtModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement]
        public string Sender { get; set; }
        [BsonElement]
        public string Message { get; set; }
        [BsonElement]
        public DateTime TimeSent { get; set; }
    }
}
