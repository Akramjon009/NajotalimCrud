using Microsoft.AspNetCore.Mvc;
using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Service.Teacher_Service;

namespace NajotalimCrud.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _TeacherControllerRepo;

        public  TeacherController(ITeacherService TRepo)
        {
            _TeacherControllerRepo = TRepo;
        }

        [HttpPost]
        public IActionResult CreateTeacher(TeacherDTOs model)
        {
            try
            {
                var response = _TeacherControllerRepo.CreateTeacherService(model);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAllStudentsFromMyDatabse()
        {
            try
            {
                var response = _TeacherControllerRepo.GetAllTeacherService();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                var response = _TeacherControllerRepo.GetByIdTeacherService(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Update(int id, TeacherDTOs student)
        {

            try
            {
                var response = _TeacherControllerRepo.UpdateTeacherService(id, student);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                var response = _TeacherControllerRepo.DeleteTeacherService(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
