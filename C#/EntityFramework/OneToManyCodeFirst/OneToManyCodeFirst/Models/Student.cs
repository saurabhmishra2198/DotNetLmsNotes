using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyCodeFirst.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Display(Name = "Teacher Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(40, ErrorMessage = "Can not accept more then 40 aplhabets")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Invalid Name")]
        [MinLength(3, ErrorMessage = "Name should contain atlist 3 character")]
        public string StudentName { get; set;}

        [Display(Name = "Student Email")]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email")]
        public string StudentEmail { get; set; }

        [Display(Name = "Branch")]
        [Required(ErrorMessage = "Branch is required")]
        [StringLength(10,ErrorMessage = "Can not accept more then 10 aplhabets")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Invalid Name")]
        public string StudentBranch { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of birth required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set;}

        public int? ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}
