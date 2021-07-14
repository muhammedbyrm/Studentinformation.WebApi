using System.Collections.Generic;


namespace Studentinformation.Core
{
    public interface IStudentServices
    {
        List<Student> GetStudents();

        Student GetStudent(string Student_Id);

       //Student AddStudent(Student student);


    }
}
