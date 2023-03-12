using Medication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IMeasurementRepository
    {
        public Task<Measurement> getLastMeasurement(int userId);
        public Task<IEnumerable<Measurement>> getMeasurementsByDate(int userId, DateTime start, DateTime end);
        public Task<Measurement> addMeasurement(Measurement measurementForAdd);
    }
}

