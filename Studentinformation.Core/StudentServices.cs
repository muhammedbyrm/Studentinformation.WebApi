using MongoDB.Driver;
using System.Collections.Generic;

namespace Studentinformation.Core
{
    public class StudentServices : IStudentServices
    {


        private readonly IMongoCollection<Student> _students;

        public StudentServices(IDbClient dbClient)
        {
            _students = dbClient.GetStudentsCollection();
        }

        /* public Student AddStudent(Student student)
         {
             _students.InsertOne(student);
             return student;
         }
        */

        public Student GetStudent(string id) => _students.Find(student => student.Student_Id == id).First();

        public List<Student> GetStudents() => _students.Find(student => true).ToList();
    }
}
