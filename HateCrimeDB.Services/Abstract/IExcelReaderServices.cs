using HateCrimeDB.Domain;
using System.Collections.Generic;

namespace HateCrimeDB.Services
{
    public interface IExcelReaderServices
    {
        IEnumerable<Incident> GetIncidents();
    }
}
