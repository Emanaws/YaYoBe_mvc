using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaYoBe_mvc.Models
{
    public interface IFacultyRepository
    {
        List<Faculty> GetAllFaculty();
        Student GetFacultyById(int FacultyId);
        void DeleteFaculty(int facultyId);
        void UpSertFaculty(Faculty s);

    }
}
