using Microsoft.AspNetCore.Mvc;
using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.MyPettern;

namespace NajotalimCrud.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Course : ControllerBase
    {
        private readonly ICourseRepository _courseRepo;

        public Course(ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
        }

        [HttpPost]
        public IActionResult CreateCourses(CourseDTOs model)
        {
            try
            {
                var response = _courseRepo.CreateCourse(model);

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
                var response = _courseRepo.GetAllCourse();

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
                var response = _courseRepo.GetByIdCourse(id);
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
                var response = _courseRepo.UpdateCourse(id, student);
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
                var response = _courseRepo.DeleteCourse(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
