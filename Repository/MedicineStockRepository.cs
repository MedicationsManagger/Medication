using DTO;
using Entites;
using Medication;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Repository
{
    public class MedicineStockRepository: IMedicineStockRepository
    {
        MedicationsContext _medicationsContext;
        public MedicineStockRepository(MedicationsContext medicationsContext)

        {
            _medicationsContext = medicationsContext;
        }

        public async Task<MedicineStock> AddMedicineStock(MedicineStock ms)
        {
            await _medicationsContext.MedicineStocks.AddAsync(ms);
            await _medicationsContext.SaveChangesAsync();
            return ms;
        }

        public async Task<IEnumerable<MedicineStockDTO>> GetMedicineStocks(int userId)
        {
            var ms = (from m in _medicationsContext.MedicineStocks
                      where m.UserId == userId
                      select m);

            List<MedicineStockDTO> MedicineStocks = await ms.ToListAsync();
            return MedicineStocks;

         }
       



        public async Task UpdateMedicineStock(MedicineStock ms)
        {
            var medicineStockToUpdate = await _medicationsContext.MedicineStocks.FindAsync(ms.Id);
            if (medicineStockToUpdate == null)
            {
                return;
            }
            _medicationsContext.Entry(medicineStockToUpdate).CurrentValues.SetValues(ms);
            await _medicationsContext.SaveChangesAsync();
            return;
        }
    }

    
}
