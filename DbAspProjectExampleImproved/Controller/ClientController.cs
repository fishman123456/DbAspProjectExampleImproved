using DbAspProjectExampleImproved.Entity;
using DbAspProjectExampleImproved.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DbAspProjectExampleImproved.Controller
{
    // ClientController - контроллер, включающий в себя операции для работы с клиентом
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        // сервис для работы с клиентами
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            // IoC-контейнер при создании контроллера
            // автоматически добавит нужную зависимость (если она есть)
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<List<Client>> ListAll()
        {
            return await _clientService.ListAll();
        }

        [HttpGet("{id:int}")]
        public async Task<Client?> GetById(int id)
        {
            Client? client = await _clientService.GetById(id);
            if (client == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            }
            return client;
        }

        [HttpPost]

        //old version
        #region
        public async Task<Client?> Add(Client client)
        {
            Client? result = await _clientService.Add(client);
            if (result == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            return result;
        }
        #endregion

        [HttpDelete("{id:int}")]
        public async Task<Client?> RemoveById(int id)
        {
            Client? client = await _clientService.RemoveById(id);
            if (client == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            }
            return client;
        }

        [HttpPatch("{id:int}")]
        public async Task<Client?> UpdateById(int id, Client client)
        {
            Client? updated = await _clientService.UpdateById(id, client);
            if (updated == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            return updated;
        }
    }
}
