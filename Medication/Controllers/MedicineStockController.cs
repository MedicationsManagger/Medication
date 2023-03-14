using AutoMapper;
using DTO;
using Entites;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Medication.Controllers
{
    
    
        public class MedicineStockController : ControllerBase
        {
            private readonly IMedicineStockService _medicineStockService;
            private readonly IMapper _mapper;
            public MedicineStockController(IMedicineStockService medicineStockService, IMapper mapper)
            {
                _medicineStockService = medicineStockService;
                _mapper = mapper;
            }
            [HttpGet]
            public async Task<ActionResult<IEnumerable<MedicineStockDTO>>> Get([FromQuery] int userId)
            {

                if (_medicineStockService.getMedicineStocks(userId) != null)
                {
                    IEnumerable<MedicineStock> ms = await _medicineStockService.getMedicineStocks(userId);
                IEnumerable<MedicineStockDTO> msDTO = _mapper.Map<IEnumerable<MedicineStock>, IEnumerable<MedicineStockDTO>>(ms);
                    return Ok(msDTO);
                }
                return NotFound();
            }




            [HttpPost]
            public async Task<ActionResult<MedicineStock>> Post([FromBody] MedicineStockDTO medicineStockDTO)
            {
                MedicineStock ms = _mapper.Map<MedicineStockDTO, MedicineStock>(medicineStockDTO);
                MedicineStock medicineStock = await _medicineStockService.addMedicineStock(ms);
                return medicineStock;
            }


            [HttpPut("{id}")]
            public async Task Put([FromBody] MedicineStockDTO medicineStockDTO)
            {
                var medicineStock = _mapper.Map<MedicineStockDTO, MedicineStock>(medicineStockDTO);
                if (medicineStock != null)
                    await _medicineStockService.updateMedicineStock(medicineStock);
                return;
            }
        }

    }

