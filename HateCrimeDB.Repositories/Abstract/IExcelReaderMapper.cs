using HateCrimeDB.Domain;
using System.Collections.Generic;
using System.Data;

namespace HateCrimeDB.Data
{
    public interface IExcelReaderMapper
    {
        IEnumerable<Incident> HydrateIncidents(DataTable dataTable);
    }
}
