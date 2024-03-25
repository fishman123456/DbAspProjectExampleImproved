using DbAspProjectExampleImproved.Entity;
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
        private readonly IOrderProductService _orderProductService;
        public OrderProductController(IOrderProductService orderProductService)
        {
            // IoC-контейнер при создании контроллера
            // автоматически добавит нужную зависимость (если она есть)
            _orderProductService = orderProductService;
        }
        [HttpGet]
        public async Task<List<OrderProduct>> ListAll()
        {
            return await _orderProductService.ListAll();
        }

        [HttpGet("{id:int}")]
        public async Task<OrderProduct?> GetById(int id)
        {
            OrderProduct? orderProduct = await _orderProductService.GetById(id);
            if (orderProduct == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            }
            return orderProduct;
        }
        [HttpPost]
        public async Task<OrderProduct?> Add(OrderProduct orderProduct)
        {
            OrderProduct? result = await _orderProductService.Add(orderProduct);
            if (result == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            return result;
        }

        [HttpDelete("{id:int}")]
        public async Task<OrderProduct?> RemoveById(int id)
        {
            OrderProduct? orderProduct = await _orderProductService.RemoveById(id);
            if (orderProduct == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            }
            return orderProduct;
        }

        [HttpPatch("{id:int}")]
        public async Task<OrderProduct?> UpdateById(int id, OrderProduct orderProduct)
        {
            OrderProduct? updated = await _orderProductService.UpdateById(id, orderProduct);
            if (updated == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            return updated;
        }
    }
}
