using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;

namespace NajotalimCrud.Service.Student_Service
{
    public interface IStudentService
    {
        public string CreateStudentService(StudentDTOs studentDTO);
        public IEnumerable<Student> GetAllStudentsService();
        public List<Student> GetByIdStudentService(int id);
        public bool DeleteStudentService(int id);
        public string UpdateStudentService(int id, StudentDTOs studentDTO);
    }
}
