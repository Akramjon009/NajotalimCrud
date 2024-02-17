using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;
using NajotalimCrud.MyPettern;
using NajotalimCrud.Service.Course_Service;

namespace NajotalimCrud.Service.CourseService
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _Co;
        
        public CourseService(ICourseRepository co)
        {
            _Co = co;
        }
        public string CreateCourseService(CourseDTOs course)
        {
            if (course.Course_Name != "" && course.Duration == "" && course.price == null ) 
            {
                _Co.CreateCourse(course);
                return "Create";
            }
            return "Error";
        }
        public string UpdateCourseService(int id,CourseDTOs course) 
        {
            if (id != null  && course.Course_Name != "" && course.Duration == "" && course.price == null)
            {
                _Co.UpdateCourse(id, course);
                return "Update";
            }
            return "Error";
        }

        public IEnumerable<Course> GetAllCourseService() 
        {
            return _Co.GetAllCourse();
        }

        public List<Course> GetByIdCourseService(int id) 
        {
            if (id != null)
            {
                return _Co.GetByIdCourse(id);
            }
            return null;
        }
        public bool DeleteCourseService(int id) 
        {
            if (id != null)
            {
                return _Co.DeleteCourse(id);
            }
            return false;
        }
        
    }
}
