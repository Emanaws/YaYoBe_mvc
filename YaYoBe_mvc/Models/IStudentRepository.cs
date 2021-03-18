using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaYoBe_mvc.Models
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int studentId);
        void DeleteStudent(int studentId);
        void UpSertSudent(Student s);

    }
}
