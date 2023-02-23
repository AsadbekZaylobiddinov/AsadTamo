using System.ComponentModel.DataAnnotations;

namespace BeautySalon.BackEnd.Domain.Entities
{
    public class Client : Auditable
    {
      [Required]
      public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Phone { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
