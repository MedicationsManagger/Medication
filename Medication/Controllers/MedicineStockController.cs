using AutoMapper;
using DTO;
using Entites;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Medication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MedicineStockController : ControllerBase
        {
            private readonly IMedicineStockService _medicineStockService;
            private readonly IMapper _mapper;
            public MedicineStockController(IMedicineStockService medicineStockService, IMapper mapper)
            {
                _medicineStockService = medicineStockService;
                _mapper = mapper;
            }
            // GET: api/<UserController>
            [HttpGet,]
            public async Task<ActionResult<IEnumerable<MedicineStock>>> Get([FromQuery] int userId)
            {

                if (_medicineStockService.GetMedicineStocks(userId) != null)
                {
                    IEnumerable<MedicineStockDTO> ms = await _medicineStockService.GetMedicineStocks(userId);
                    IEnumerable<MedicineStock> msDTO = (IEnumerable<MedicineStockDTO>)_mapper.Map<MedicineStockDTO>(ms);
                
                    return Ok(msDTO);
                }

                return NotFound();
            }

       

        //[HttpPost]
        //public async Task<ActionResult<MedicineStock>> Post([FromBody] MedicineStockDTO medicineStockDTO)
        //{
        //    MedicineStock ms = _mapper.Map<MedicineStockDTO, MedicineStock>(medicineStockDTO);
        //    MedicineStock medicineStock = await _medicineStockService.addMedicineStock(ms);
        //    return medicineStock;
        //}


        //[HttpPut("{id}")]
        //public async Task Put([FromBody] MedicineStockDTO medicineStockDTO)
        //{
        //    var medicineStock = _mapper.Map<MedicineStockDTO, MedicineStock>(medicineStockDTO);
        //    if (medicineStock != null)
        //        await _medicineStockService.updateMedicineStock(medicineStock);
        //    return;
        //}
    }

    }

