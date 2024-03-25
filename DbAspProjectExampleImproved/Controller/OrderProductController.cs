using DbAspProjectExampleImproved.Service;
using Microsoft.AspNetCore.Mvc;

namespace DbAspProjectExampleImproved.Controller
{
    // ClientController - контроллер, включающий в себя операции
    // для работы с многие ко многим  товар-заказ
    [Route("api/orderproduct")]
    [ApiController]
    public class OrderProductController:ControllerBase
    {
        private readonly IOrderProductService _ordererProductService;
        public OrderProductController(IOrderProductService orderProductService)
        {
            // IoC-контейнер при создании контроллера
            // автоматически добавит нужную зависимость (если она есть)
            _ordererProductService = orderProductService;
        }
    }
}
