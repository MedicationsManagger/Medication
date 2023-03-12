using Medication;

namespace Services
{
    public interface IMeasurementService
    {

        public Task<Measurement> getLastMeasurement(int userId);
        public Task<IEnumerable<Measurement>> getMeasurementsByDate(int userId, DateTime start, DateTime end);
        public Task<Measurement> addMeasurement(Measurement measurementForAdd);
    }
}