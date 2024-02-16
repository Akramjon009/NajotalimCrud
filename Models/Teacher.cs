using System.Text.RegularExpressions;

namespace NajotalimCrud.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int age { get; set; }
        public  string Phon_number { get; set; }
        public int  experience { get; set; }
        public int Group_count { get; set; }
    }
}
