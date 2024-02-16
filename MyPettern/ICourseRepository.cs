using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;

namespace NajotalimCrud.MyPettern
{
    public class ICourseRepository
    {
        public interface ISudentRepository
        {

            public string CreateStudent(CourseDTOs CourseDTO);
            public IEnumerable<Course> GetAllStudents();
            public List<Course> GetByIdStudent(int id);
            public bool DeleteStudent(int id);
            public string UpdateStudent(int id, CourseDTOs CourseDTO);


        }
    }
}
