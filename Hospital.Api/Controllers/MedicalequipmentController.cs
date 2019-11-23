

using Hospital.Entity;
using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MedicalequipmentController: ControllerBase
    {
         private IMedicalequipmentService medicalequipmentService;

        public MedicalequipmentController(IMedicalequipmentService medicalequipmentService)
        {
            this.medicalequipmentService = medicalequipmentService;
        }

         [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                medicalequipmentService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody]Medicalequipment medicalequipment)
        {
            return Ok(
                medicalequipmentService.Save(medicalequipment)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody]Medicalequipment medicalequipment)
        {
            return Ok(
                medicalequipmentService.Update(medicalequipment)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                medicalequipmentService.Delete(id)
            );
        }
    }
}