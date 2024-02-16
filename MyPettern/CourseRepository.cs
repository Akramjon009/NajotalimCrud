using Dapper;
using NajotalimCrud.Entities.DTOs;
using NajotalimCrud.Models;
using Npgsql;

namespace NajotalimCrud.MyPettern
{
    public class CourseRepository:ICourseRepository
    {
        public IConfiguration _configuration;

        public CourseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateCourse(CourseDTOs courseDTO)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    string query = "insert into course(course_name, teacher_id, duration,price,student_count ) VALUES (@Course_Name, @TeacherID,@Duration, @price,@Student_count)";

                    var parameters = new CourseDTOs
                    {
                       Course_Name = courseDTO.Course_Name,
                       Teacher_Id = courseDTO.Teacher_Id,
                       Duration = courseDTO.Duration,
                       price = courseDTO.price,
                       student_count = courseDTO.student_count

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



        public IEnumerable<Course> GetAllStudents()
        {

            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from course";

                var result = connection.Query<Course>(query);

                return result;
            }

        }

        public List<Course> GetByIdStudent(int id)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from course where id = @isd";


                List<Course> result = connection.Query<Course>(query, new { isd = id }).ToList();

                return result;
            }
        }

        public string UpdateStudent(int id,CourseDTOs courseDTO)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "Update from course set course_name = @Course_Name, teacher_id = @teacherid, duration = @Duration,price = @prices,student_count = @studentcount  where id = @id";
                var parameters = new Course
                {
                    Course_Name = courseDTO.Course_Name,
                    Teacher_Id = te,

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
