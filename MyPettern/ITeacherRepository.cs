using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;

namespace NajotalimCrud.MyPettern
{

    public interface ITeacherRepository
    {
        public string CreateTeacher(TeacherDTOs teacherDTO);
        public IEnumerable<Teacher> GetAllTeacher();
        public List<Teacher> GetByIdTeacher(int id);
        public bool DeleteTeacher(int id);
        public string UpdateTeacher(int id, TeacherDTOs teacherDTO);

    }

}
