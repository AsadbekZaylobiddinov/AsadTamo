using BeautySalon.BackEnd.Domain.Entities;

namespace BeautySalon.BackEnd.Domain.Interfaces
{
    public interface IClient
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public List<Message> Messages { get; set; }
    }
}
