using BeautySalon.BackEnd.Domain.Interfaces;
namespace BeautySalon.BackEnd.Domain.Entities
{
public class AuthModel : IAuthModel
    {
       public string Phone { get; set; }
       public string Password { get; set; }
    }
}
    
