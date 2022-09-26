using System.ComponentModel.DataAnnotations;

namespace Avans.CodeFirstDemo.EntityFramework.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IList<Student> Students { get; set; }

    }
}
