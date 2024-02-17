using Dapper;
using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;
using Npgsql;

namespace NajotalimCrud.MyPettern
{
    public class TeacherRepository : ITeacherRepository
    {

        public IConfiguration _configuration;

        public TeacherRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateTeacher(TeacherDTOs teacherDTO)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    string query = "insert into course(fullname, age,phone_number,experience,group_count) VALUES (@FullName, @age, @phone_number,@Experience,@GroupCount)";

                    var parameters = new TeacherDTOs
                    {
                        FullName = teacherDTO.FullName,
                        age = teacherDTO.age,
                        Phon_number = teacherDTO.Phon_number,
                        experience = teacherDTO.experience,
                        Group_count = teacherDTO.Group_count,


                    };


                    connection.Execute(query, parameters);

                }

                return "malumot yaratildi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



        public IEnumerable<Teacher> GetAllTeacher()
        {

            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from teacher";

                var result = connection.Query<Teacher>(query);

                return result;
            }

        }

        public List<Teacher> GetByIdTeacher(int id)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from teacher where id = @isd";


                List<Teacher> result = connection.Query<Teacher>(query, new { isd = id }).ToList();

                return result;
            }
        }

        public string UpdateTeacher(int id, TeacherDTOs teacherDTO)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "Update from teacher set fullname = @Fullname, age = @age,phone_number = @Phone_number,experience = @experience,group_count=@Group where id = @id";
                var parameters = new TeacherDTOs
                {
                    FullName = teacherDTO.FullName,
                    age = teacherDTO.age,
                    Phon_number = teacherDTO.Phon_number,
                    experience = teacherDTO.experience,
                    Group_count = teacherDTO.Group_count

                };

                connection.Execute(query, parameters);

                return "Update ";
            }
        }


        public bool DeleteTeacher(int id)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "Delete from teacher where Id = @id";


                connection.Execute(query, new { Id = id });

                return true;
            }
        }
    }
}
