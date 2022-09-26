using System.ComponentModel.DataAnnotations;

namespace Avans.CodeFirstDemo.EntityFramework.Models
{
    public class Bike
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
