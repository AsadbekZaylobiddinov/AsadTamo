using BeautySalon.BackEnd.Domain.Interfaces;
namespace BeautySalon.BackEnd.Domain.Entities
{
    public class Auditable : IAuditable
    {
       public int Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;       
    }
}
