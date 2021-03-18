using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace YaYoBe_mvc.Models
{
    public class FacultyRepository : IFacultyRepository
    {
        Yayobe _yb = new Yayobe();
        public void DeleteFaculty(int facultyId)
        {
            throw new NotImplementedException();
        }

        public List<Faculty> GetAllFaculty()
        {
            var result = _yb.Faculties.ToList();
            return result;
            //var result = _yb.Students.ToList();
            //return result;
        }

        public Faculty GetFacultyById(int FacultyId)
        {
            Faculty result = new Faculty();
            result = _yb.Faculties.FirstOrDefault(x => x.FacultyId == FacultyId);
            return result;
        }

        public void UpSertFaculty(Faculty s)
        {
            throw new NotImplementedException();
        }

        Student IFacultyRepository.GetFacultyById(int FacultyId)
        {
            throw new NotImplementedException();
        }
    }
}