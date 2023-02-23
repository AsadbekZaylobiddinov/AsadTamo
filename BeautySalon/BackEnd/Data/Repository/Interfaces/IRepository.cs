using BeautySalon.BackEnd.Domain.Entities;
using Newtonsoft.Json;

namespace BeautySalon.BackEnd.Data.Repository.Interfaces
{
    public interface IRepository
    {
      Task CreateClient(Client client);
     Task<Client> GetByIdClient(int id);
        Task<List<Client>> GetAllClients();
        Task DeleteClient(int id);
        Task<int> IfExists(AuthModel logged);

        Task<Client> GetByPhoneClient(string phone);
        Task<int> GetId(string phone);
        Task<int> GetLastId();
    }
}
