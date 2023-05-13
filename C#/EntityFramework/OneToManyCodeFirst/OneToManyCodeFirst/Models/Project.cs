using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyCodeFirst.Models
{
    [Table("Project")]
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Display(Name ="Project Name")]
        [Required(ErrorMessage = "Project name must be required")]
        [StringLength(40, ErrorMessage = "Can not accept more then 40 aplhabets")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Invalid Name")]
        [MinLength(3, ErrorMessage = "Name should contain atlist 3 character")]
        public string ProjectName { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Project starting date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "Project ending date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public ICollection<Student>? Students { get; set; }
    }
}
