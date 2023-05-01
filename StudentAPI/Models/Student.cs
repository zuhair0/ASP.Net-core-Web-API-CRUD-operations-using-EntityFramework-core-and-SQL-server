using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string? Name { get; set; }
        public int ContactNum { get; set; }
        public int Age { get; set; }
    }
}
