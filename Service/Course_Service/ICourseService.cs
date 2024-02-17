using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;

namespace NajotalimCrud.Service.Course_Service
{
    public interface ICourseService
    {
        public string CreateCourseService(CourseDTOs CourseDTO);
        public IEnumerable<Course> GetAllCourseService();
        public List<Course> GetByIdCourseService(int id);
        public bool DeleteCourseService(int id);
        public string UpdateCourseService(int id, CourseDTOs CourseDTO);
    }
}
