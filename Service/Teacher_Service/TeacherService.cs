using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;
using NajotalimCrud.MyPettern;

namespace NajotalimCrud.Service.Teacher_Service
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _cs;
        public TeacherService(ITeacherRepository cs)
        {
            _cs = cs;   
        }

        public string CreateTeacherService(TeacherDTOs teacherDTO)
        {
            if (teacherDTO.FullName != "" && teacherDTO.experience > 1) 
            {
                _cs.CreateTeacher(teacherDTO);
                return "Create";
            }
            return "error";
        }
        public IEnumerable<Teacher> GetAllTeacherService() 
        {
            return _cs.GetAllTeacher();
        }
        public List<Teacher> GetByIdTeacherService(int id) 
        {
            if (id != null) 
            {
                _cs.GetByIdTeacher(id);
            }
            return null;
        }
        public bool DeleteTeacherService(int id) 
        {
            if (id != null) 
            {
                return _cs.DeleteTeacher(id);
            }
            return false;
        }
        public string UpdateTeacherService(int id, TeacherDTOs teacherDTO) 
        {
            if (id != null && teacherDTO.FullName != "" && teacherDTO.experience > 1) 
            {
                _cs.UpdateTeacher(id, teacherDTO);
                return "Update";
            }
            return "error";
        }
    }
}
