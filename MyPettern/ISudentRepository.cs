using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;

namespace NajotalimCrud.MyPettern
{
  
        public interface IStudentRepository
        {
            public string CreateStudent(StudentDTOs studentDTO);
            public IEnumerable<Student> GetAllStudents();
            public List<Student> GetByIdStudent(int id);
            public bool DeleteStudent(int id);
            public string UpdateStudent(int id, StudentDTOs studentDTO);
          
        }
    
}
