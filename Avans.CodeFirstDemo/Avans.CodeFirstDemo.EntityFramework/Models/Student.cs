using System.ComponentModel.DataAnnotations;

namespace Avans.CodeFirstDemo.EntityFramework.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IList<Course> Courses { get; set; }
    }
}
