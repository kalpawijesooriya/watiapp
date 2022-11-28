using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Math
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("number1")]
        public int Number1 { get; set; }

        [BsonElement("number2")]
        public int Number2 { get; set; }

        [BsonElement("sum")]
        public int Sum{ get; set; }
    }
}
