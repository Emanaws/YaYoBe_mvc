using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YaYoBe_mvc.Models
{
    public class StudentRepository : IStudentRepository
    {
        Yayobe _yb = new Yayobe();
          
        public void DeleteStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudents()
        {
            var result = _yb.Students.ToList();
            return result;
        }

        public Student GetStudentById(int studentId)
        {
            Student result = new Student();
            result = _yb.Students.FirstOrDefault(x => x.StudentId == studentId);
            return result;
        }

        public void UpSertSudent(Student s)
        {
            throw new NotImplementedException();
        }
    }
}