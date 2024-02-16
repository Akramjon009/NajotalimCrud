namespace NajotalimCrud.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Course_Name { get; set; }
        public int Teacher_Id { get;set; }
        public string Duration { get; set; }
        public int price { get; set; }
        public int student_count { get; set; }
    }
}
