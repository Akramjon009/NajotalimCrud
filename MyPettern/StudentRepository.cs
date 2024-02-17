using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;
using Npgsql;
using Dapper;


namespace NajotalimCrud.MyPettern
{

    public class StudentRepository : IStudentRepository
    {
        public IConfiguration _configuration;

        public StudentRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateStudent(StudentDTOs studentDTO)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    string query = "insert into student(fullname, age, course_id, phone_number) VALUES (@FullName, @age, @course_id, @phone_number)";

                    var parameters = new StudentDTOs
                    {
                        FullName = studentDTO.FullName,
                        age = studentDTO.age,
                        course_id = studentDTO.course_id,
                        phone_number = studentDTO.phone_number
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



        public IEnumerable<Student> GetAllStudents()
        {

            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from student";

                var result = connection.Query<Student>(query);

                return result;
            }

        }

        public List<Student> GetByIdStudent(int id)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from student where id = @isd";


                List<Student> result = connection.Query<Student>(query, new { isd = id }).ToList();

                return result;
            }
        }

        public string UpdateStudent(int id, StudentDTOs studentDTO)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "Update from student set fullname = @FullName,age = @ages,course_id = @course_id, phone_number=@phone_number where id = @id";
                var parameters = new Student
                {
                    FullName = studentDTO.FullName,
                    age = studentDTO.age,
                    phone_number = studentDTO.phone_number,
                    course_id = studentDTO.course_id
                };

                connection.Execute(query, parameters);

                return "Update ";
            }
        }


        public bool DeleteStudent(int id)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "Delete from student where Id = @id";


                connection.Execute(query, new { Id = id });

                return true;
            }
        }
    }
}

