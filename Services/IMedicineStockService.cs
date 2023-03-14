using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IMedicineStockService
    {
        public Task<IEnumerable<MedicineStock>> getMedicineStocks(int userId);
        public Task<MedicineStock> addMedicineStock(MedicineStock ms);
        public Task updateMedicineStock(MedicineStock ms);
    }
}
