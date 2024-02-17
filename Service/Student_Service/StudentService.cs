using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;
using NajotalimCrud.MyPettern;

namespace NajotalimCrud.Service.Student_Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _cs;
        public StudentService(IStudentRepository cs)
        {
            _cs = cs;
        }
        public string CreateStudentService(StudentDTOs studentDTO)
        {
            if (studentDTO.FullName != "" && studentDTO.phone_number != null && studentDTO.age != null)
            {
                return _cs.CreateStudent(studentDTO);
            }
            return "erro";
        }
        public IEnumerable<Student> GetAllStudentsService()
        {
            return _cs.GetAllStudents();
        }
        public List<Student> GetByIdStudentService(int id)
        {
            if (id != null)
            {
                return _cs.GetByIdStudent(id);
            }
            return null;

        }
        public bool DeleteStudentService(int id)
        {
            if (id != null)
            {
                return _cs.DeleteStudent(id);
            }
            return false;
        }
        public string UpdateStudentService(int id, StudentDTOs studentDTO) 
        {
            if (id != null && studentDTO.FullName != "" && studentDTO.phone_number != "") 
            {
                return _cs.UpdateStudent(id, studentDTO);
            }
            return "error";
        }
    }
}
