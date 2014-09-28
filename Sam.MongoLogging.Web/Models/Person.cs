namespace Sam.MongoLogging.Web.Models
{
    using MongoDB.Bson;

    public class Person
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }
    }
}