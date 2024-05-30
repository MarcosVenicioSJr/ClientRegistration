using ClientRegistration.DbContext;
using ClientRegistration.Models;
using ClientRegistration.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClientRegistration.Repository;

public class ClientRepository : IClientRepository
{
    public async Task<Client> GetClientById(int id, Context context)
    {
        Client? client = await context.Client.FirstOrDefaultAsync(x => x.Id == id);
        return client;
    }

    public async Task<List<Client>> GetClient(Context context)
    {
        List<Client> result = await context.Client.AsNoTracking().ToListAsync();
        return result;
    }

    public Task DeleteClientById(int id, Context context)
    {
        throw new NotImplementedException();
    }

    public Task UpdateClient(int id, Client client, Context context)
    {
        throw new NotImplementedException();
    }
}