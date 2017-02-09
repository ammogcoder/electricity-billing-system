using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace Service
{
    public class ConsumptionService : IConsumptionService
    {
        private IRepository<Consumption> consumptionRepository;
        private IRepository<Meter> meterRepository;

        public ConsumptionService(IRepository<Consumption> consumptionRepository, IRepository<Meter> meterRepository)
        {
            this.consumptionRepository = consumptionRepository;
            this.meterRepository = meterRepository;
        }
        public void DeleteConsumption(Consumption consumption)
        {
            throw new NotImplementedException();
        }

        public Consumption GetConsumption(int id)
        {
            return consumptionRepository.GetById(id);
        }

        public IQueryable<Consumption> GetConsumptions()
        {
            return consumptionRepository.Table;
        }

        public void InsertConsumption(Consumption consumption)
        {
            consumptionRepository.Insert(consumption);
        }

        public void UpdateConsumption(Consumption consumption)
        {
            consumptionRepository.Update(consumption);
        }
    }
}
