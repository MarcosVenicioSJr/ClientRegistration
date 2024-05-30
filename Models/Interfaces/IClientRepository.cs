using ClientRegistration.DbContext;
using Microsoft.AspNetCore.Mvc;

namespace ClientRegistration.Models.Interfaces;

public interface IClientRepository
{
    Task<Client> GetClientById(int id, [FromServices]Context context);
    Task<List<Client>> GetClient([FromServices]Context context);
    Task DeleteClientById(int id, [FromServices]Context context);
    Task UpdateClient(int id, Client client, [FromServices]Context context);
}