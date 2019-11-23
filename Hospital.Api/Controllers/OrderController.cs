using Hospital.Entity;
using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Astra.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController: ControllerBase
    {
         private IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

           [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                orderService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Order order )
        {
            return Ok(
                orderService.Save(order)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Order order)
        {
            return Ok(
               orderService.Update(order)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                orderService.Delete(id)
            );
        }
    }
}