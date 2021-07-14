using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentinformation.Core
{
    public class Student
    {
        [BsonId] //pk for mongo
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)] 

        public string Id { get; set; }
        public string Student_Name { get; set; }

        public string Student_Year { get; set; }

        public string Student_Id { get; set; }

        public string Student_Department { get; set; }

        public string Course_Name { get; set; }

        public int Course_Credit { get; set; }

        public string Course_Grade { get; set; }

        public double GPA { get; set; }

        public double CGPA { get; set; }
    }
}
