using ClientRegistration.DbContext;
using ClientRegistration.Models;
using ClientRegistration.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClientRegistration.Controllers;

public class ClientController : Controller
{
    private readonly ILogger<ClientController> _logger;
    private readonly IClientRepository _clientRepository;

    public ClientController(ILogger<ClientController> logger, IClientRepository clientRepository)
    {
        _logger = logger;
        _clientRepository = clientRepository;
    }

    
    public async Task<IActionResult> Index([FromServices] Context context)
    {
        List<Client> clients =  await _clientRepository.GetClient(context);
        return View(clients);
    }
}