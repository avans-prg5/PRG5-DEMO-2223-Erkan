using DatabaseFirstDemo.EntityFramework.Models;

namespace DatabaseFirstDemo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // Maak verbinding met de database
            using (var dbContext = new TelefoonboekDBContext())
            {
                // Geef mij de eerste contact record vanuit mijn DB Context.
                var contact = dbContext.Contacts.First();
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Contact: {contact.Id}, name: {contact.Voornaam}");
            }
        }
    }
}