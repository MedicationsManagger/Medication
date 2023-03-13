using Entites;
using Medication;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MeasurementService : IMeasurementService
    {

        private IMeasurementRepository _measurementRepository;

        public MeasurementService(IMeasurementRepository measurementRepository)
        {
            _measurementRepository = measurementRepository;
        }


        public async Task<Measurement> addMeasurement(Measurement measurementForAdd)
        {
            return await _measurementRepository.addMeasurement(measurementForAdd);
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
