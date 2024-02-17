using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;

namespace NajotalimCrud.MyPettern
{

    public interface ICourseRepository
    {

        public string CreateCourse(CourseDTOs CourseDTO);
        public IEnumerable<Course> GetAllCourse();
        public List<Course> GetByIdCourse(int id);
        public bool DeleteCourse(int id);
        public string UpdateCourse(int id, CourseDTOs CourseDTO);


    }

}
