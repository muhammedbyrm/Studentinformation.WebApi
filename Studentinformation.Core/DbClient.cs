using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentinformation.Core
{
    public class DbClient : IDbClient
    {

        private readonly IMongoCollection<Student> _students;

        public DbClient(IOptions<StudentinformationDbConfig> studentinformationDbConfig)
        {
            var client = new MongoClient(studentinformationDbConfig.Value.Connection_String);
            var database = client.GetDatabase(studentinformationDbConfig.Value.Database_Name);
            _students = database.GetCollection<Student>(studentinformationDbConfig.Value.Students_Collection_Name);
        }


        public IMongoCollection<Student> GetStudentsCollection() => _students;

       
    }
}
