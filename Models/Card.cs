using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api_magicTheGathering.Models 
{
    public class Ruling
    {
        public string date { get; set; }
        public string text { get; set; }
    }

    public class Legality
    {
        public string format { get; set; }
        public string legality { get; set; }
    }

    public class Card
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string layout { get; set; }
        public string name { get; set; }
        public decimal cmc { get; set; }
        public string manaCost { get; set; }
        public string[] colors { get; set; }
        public string type { get; set; }
        public string[] types { get; set; }
        public string[] subtypes { get; set; }
        public string text { get; set; }
        public string power { get; set; }
        public string toughness { get; set; }
        public string imageName { get; set; }
        public string[] printings { get; set; }
        public Legality[] legalities { get; set; }
        public string[] colorIdentity { get; set; }
        public Ruling[] rulings { get; set; }
        public string source { get; set; }
        public string[] supertypes { get; set; }
        public bool? starter { get; set; }
        public int? loyalty { get; set; }
        public int? hand { get; set; }
        public int? life { get; set; }
        public string[] names { get; set; }
    }
}