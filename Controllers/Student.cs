using Microsoft.AspNetCore.Mvc;
using NajotalimCrud.Entities.DTOs;

using NajotalimCrud.Service.Student_Service;

namespace NajotalimCrud.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _cs;

        public StudentsController(IStudentService student)
        {
            _cs = student;
        }

        [HttpPost]
        public IActionResult CreateStudent(StudentDTOs model)
        {
            try
            {
                var response = _cs.CreateStudentService(model);

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
                var response = _cs.GetAllStudentsService();

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
                var response = _cs.GetByIdStudentService(id);
                return Ok(response);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Update(int id,StudentDTOs student)
        {
            
            try
            {
                var response = _cs.UpdateStudentService(id,student);
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
                var response = _cs.DeleteStudentService(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
       
    }
}
