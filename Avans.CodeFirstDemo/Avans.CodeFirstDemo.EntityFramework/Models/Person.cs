using System.ComponentModel.DataAnnotations;

namespace Avans.CodeFirstDemo.EntityFramework.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }


        public IList<Bike> Bikes { get; set; }
    }
}
