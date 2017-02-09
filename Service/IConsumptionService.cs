using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Service
{
    public interface IConsumptionService
    {
        IQueryable<Consumption> GetConsumptions();
        Consumption GetConsumption(int id);
        void InsertConsumption(Consumption consumption);
        void UpdateConsumption(Consumption consumption);
        void DeleteConsumption(Consumption consumption);

    }
}
