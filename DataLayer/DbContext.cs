using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DbContext
    {
        public DbContext(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);

            Maths = database.GetCollection<Math>(nameof(Maths));
        }

        public readonly IMongoCollection<Math> Maths;
    }
}
