using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace Service
{
    public class MeterService : IMeterService
    {
        private IRepository<Consumption> consumptionRepository;
        private IRepository<Meter> meterRepository;
        public MeterService(IRepository<Consumption> consumptionRepository, IRepository<Meter> meterRepository)
        {
            this.consumptionRepository = consumptionRepository;
            this.meterRepository = meterRepository;
        }
        public MeterService GetMeter(string id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Meter> GetMeters()
        {
            return meterRepository.Table;
        }
    }
}
