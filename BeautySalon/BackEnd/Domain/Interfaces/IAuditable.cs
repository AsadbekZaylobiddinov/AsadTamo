namespace BeautySalon.BackEnd.Domain.Interfaces
{
    public interface IAuditable
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
