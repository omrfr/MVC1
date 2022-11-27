using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
}
