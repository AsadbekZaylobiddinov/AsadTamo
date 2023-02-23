using System.ComponentModel.DataAnnotations;

namespace BeautySalon.BackEnd.Domain.Entities
{
    public class Note
    {
        [Required] public string Oy { get; set; }
        [Required] public string Kun { get; set; }
        [Required] public string Vaqt { get; set; }
        [Required] public string Comment { get; set; }
        [Required] public Client clt { get; set; }
    }
}
