using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DbAspProjectExampleImproved.Controller.BasicApiMessages;

namespace DbAspProjectExampleImproved.Controller
{
    // MainController - контроллер, включающий в себя базовые обработчики программы
    [Route("api")]
    [ApiController]
    public class MainController : ControllerBase
    {
        // 1. обработчик корня API
        [HttpGet]
        public StringMessage Index()
        {
            int? port = HttpContext.Request.Host.Port;
            return new StringMessage(message: $"server is running on port {port}");
        }

        // 2. обработчик ping
        [HttpGet("ping")]
        public StringMessage Ping()
        {
            return new StringMessage(message: "pong");
        }
    }
}
