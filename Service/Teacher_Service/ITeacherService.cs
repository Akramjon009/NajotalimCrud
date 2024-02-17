using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;

namespace NajotalimCrud.Service.Teacher_Service
{
    public interface ITeacherService
    {
        public string CreateTeacherService(TeacherDTOs teacherDTO);
        public IEnumerable<Teacher> GetAllTeacherService();
        public List<Teacher> GetByIdTeacherService(int id);
        public bool DeleteTeacherService(int id);
        public string UpdateTeacherService(int id, TeacherDTOs teacherDTO);

    }
}
