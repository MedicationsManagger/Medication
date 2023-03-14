using DTO;
using Entites;
using Medication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task<IEnumerable<MedicineStockDTO>> GetMedicineStocks(int userId)
        {
            var ms = (from u in _medicationsContext.MedicineStocks
                      where u.Id == userId
                      select u);
            return (Task<IEnumerable<MedicineStock>>)ms;
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
