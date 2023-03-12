using Medication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MeasurementRepository : IMeasurementRepository
    {

        MedicationsContext _medicationsContext;
        public MeasurementRepository(MedicationsContext medicationsContext)
        {
            _medicationsContext = medicationsContext;
        }

        public async Task<Measurement> addMeasurement(Measurement measurementForAdd)
        {
            await _medicationsContext.Measurements.AddAsync(measurementForAdd);
            await _medicationsContext.SaveChangesAsync();
            return measurementForAdd;
        }

        public Task<Measurement> getLastMeasurement(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Measurement>> getMeasurementsByDate(int userId, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
