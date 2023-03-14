using AutoMapper;
using Entites;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Medication.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MeasurementController : ControllerBase
//    {

//        private readonly IMeasurementService _measurementService;
//        private readonly IMapper _mapper;

//        public MeasurementController(IMeasurementService measurementService, IMapper mapper)
//        {
//            _measurementService = measurementService;
//            _mapper = mapper;
//        }



//        [HttpGet]
//        public async Task<ActionResult<Measurement>> Get([FromQuery]int userId)
//        {
//            Measurement lastMesurment = await _measurementService.getLastMeasurement(userId);
//            if (lastMesurment ==null)
//            {
//                return NoContent();
//            }
//            return Ok(lastMesurment);
//        }
        


//        // GET: api/<MeasurementController>
//        [HttpGet]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

        



//        // POST api/<MeasurementController>
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

     
//    }
//}
