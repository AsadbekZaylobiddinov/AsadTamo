using BeautySalon.BackEnd.Domain.Entities;
using BeautySalon.BackEnd.Domain.Interfaces;
using Newtonsoft.Json;
using BeautySalon.BackEnd.Data.Configurations;
using BeautySalon.BackEnd.Data.Repository.Interfaces;

namespace BeautySalon.BackEnd.Data.Repository
{
    public class Repository
    {
        static public async Task CreateClient(Client client)
        {
            var clients = await File.ReadAllTextAsync(Configurations.Configurations.clients);
            if(clients == "")
            {
                List<Client> cls = new List<Client>();
                cls.Add(client);
                await File.WriteAllTextAsync(Configurations.Configurations.clients, JsonConvert.SerializeObject(cls));
            }
            else
            {
            List<Client>? users = JsonConvert.DeserializeObject<List<Client>>(clients);
            users.Add(client);
            await File.WriteAllTextAsync(Configurations.Configurations.clients, JsonConvert.SerializeObject(users));
            }
           
        }


        static public async Task<Client> GetByIdClient(int id)
        {
            var clients = await File.ReadAllTextAsync(Configurations.Configurations.clients);
            List<Client>? users = JsonConvert.DeserializeObject<List<Client>>(clients);
            Client client = users.First(client => client.Id == id);
            return client;
        }
        static public async Task<List<Client>> GetAllClients()
        {
            var clients = await File.ReadAllTextAsync(Configurations.Configurations.clients);
            List<Client>? users = JsonConvert.DeserializeObject<List<Client>>(clients);
            return users;
        }
        static public async Task DeleteClient(int id)
        {
            var clients = await File.ReadAllTextAsync(Configurations.Configurations.clients);
            List<Client>? users = JsonConvert.DeserializeObject<List<Client>>(clients);
            users.RemoveAll(user => user.Id == id);
            await File.WriteAllTextAsync(Configurations.Configurations.clients, JsonConvert.SerializeObject(users));
        }
        static public async Task<int> IfExists(AuthModel logged)
        {
            int result = 0;
            var clients = await File.ReadAllTextAsync(Configurations.Configurations.clients);
            List<Client>? users = JsonConvert.DeserializeObject<List<Client>>(clients);
            if(users == null)
            {
                return result;
            }
            else
            {
 foreach (Client i in users)
            {
                if (i.Phone == logged.Phone)
                {
                    if (i.Password == logged.Password)
                    {
                        result = 1;
                         break;
                    }
                    
                }
            }
            }
           
            return result;   
        }
        static public async Task<Client> GetByPhoneClient(string phone)
        {
            var clients = await File.ReadAllTextAsync(Configurations.Configurations.clients);
            List<Client>? users = JsonConvert.DeserializeObject<List<Client>>(clients);
            Client client = users.First(client => client.Phone == phone);
            return client;
        }
        static public async Task<int> GetId(string phone)
        {
            int id = 0;
            var clients = await File.ReadAllTextAsync(Configurations.Configurations.clients);
            if(clients == ""){
                id = 1;
                return id;
            }
            List<Client>? users = JsonConvert.DeserializeObject<List<Client>>(clients);
            foreach (Client i in users)
            {
                if (i.Phone == phone)
                {
                    id = i.Id;
                    break;
                }
            }
            return id;
        }
        static public async Task<int> GetLastId()
        {
            int id = 0;
            var clients = await File.ReadAllTextAsync(Configurations.Configurations.clients);
            if (clients == "[]" || clients == "")
            {
                id = 1;
                return id;
            }
            else
            {
                List<Client>? users = JsonConvert.DeserializeObject<List<Client>>(clients);

                id = users.Last().Id + 1;
            }
            return id;
        }
    }
}
