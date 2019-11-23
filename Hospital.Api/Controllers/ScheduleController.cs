using Hospital.Entity;
using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController: ControllerBase
    {
          private IScheduleService scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            this.scheduleService = scheduleService;
        }

           [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                scheduleService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody]  Schedule schedule )
        {
            return Ok(
                scheduleService.Save(schedule)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Schedule schedule)
        {
            return Ok(
               scheduleService.Update(schedule)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                scheduleService.Delete(id)
            );
        }
    }
}