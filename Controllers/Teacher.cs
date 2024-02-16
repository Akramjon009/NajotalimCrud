using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.MyPettern;

namespace NajotalimCrud.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository _TeacherControllerRepo;

        public  TeacherController(ITeacherRepository TRepo)
        {
            _TeacherControllerRepo = TRepo;
        }

        [HttpPost]
        public IActionResult CreateTeacher(TeacherDTOs model)
        {
            try
            {
                var response = _TeacherControllerRepo.CreateTeacher(model);
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
                var response = _TeacherControllerRepo.GetAllTeacher();

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
                var response = _TeacherControllerRepo.GetByIdTeacher(id);
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
                var response = _TeacherControllerRepo.UpdateTeacher(id, student);
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
                var response = _TeacherControllerRepo.DeleteTeacher(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
