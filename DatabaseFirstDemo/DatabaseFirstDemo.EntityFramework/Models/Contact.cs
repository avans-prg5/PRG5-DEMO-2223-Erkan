using System;
using System.Collections.Generic;

namespace DatabaseFirstDemo.EntityFramework.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Voornaam { get; set; } = null!;
        public string Achternaam { get; set; } = null!;
        public string? Telefoonnummer { get; set; }
        public DateTime? Geboortedatum { get; set; }
    }
}
