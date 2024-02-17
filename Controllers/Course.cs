using Microsoft.AspNetCore.Mvc;
using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Service.Course_Service;

namespace NajotalimCrud.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Course : ControllerBase
    {
        private readonly ICourseService _course;

        public Course(ICourseService course)
        {
            _course = course;
        }

        [HttpPost]
        public IActionResult CreateCourses(CourseDTOs model)
        {
            try
            {
                var response = _course.CreateCourseService(model);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAllCourses()
        {
            try
            {
                var response = _course.GetAllCourseService();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetCourseByIds(int id)
        {
            try
            {
                var response = _course.GetByIdCourseService(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Updates(int id, CourseDTOs student)
        {

            try
            {
                var response = _course.UpdateCourseService(id, student);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteCourses(int id)
        {
            try
            {
                var response = _course.DeleteCourseService(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
