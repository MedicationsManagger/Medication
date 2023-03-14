using AutoMapper;
using Entites;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Medication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementController : ControllerBase
    {

        private readonly IMeasurementService _measurementService;
        private readonly IMapper _mapper;

        public MeasurementController(IMeasurementService measurementService, IMapper mapper)
        {
            _measurementService = measurementService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<Measurement>> Get([FromQuery]int userId)
        {
            Measurement lastMesurment = await _measurementService.getLastMeasurement(userId);
            if (lastMesurment ==null)
            {
                return NoContent();
            }
            return Ok(lastMesurment);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Measurement>>> Get([FromQuery]int userId, DateTime start, DateTime end)
        {
            IEnumerable<Measurement> measurementRes = await _measurementService.getMeasurementsByDate(userId, start, end);

            if (measurementRes == null)
            {
                return NoContent();
            }
            return Ok(measurementRes);

        }

       
        [HttpPost]
        public void Post([FromBody] string value)

        {

        }

     
    }
}
