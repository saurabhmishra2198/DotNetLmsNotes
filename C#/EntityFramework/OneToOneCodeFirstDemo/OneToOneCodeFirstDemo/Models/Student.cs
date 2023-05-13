using System.ComponentModel.DataAnnotations;

namespace OneToOneCodeFirstDemo.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set;}
        public string StudentEmail { get; set;}
        public StudentAddress StudentAddress { get; set; }

    }
}
