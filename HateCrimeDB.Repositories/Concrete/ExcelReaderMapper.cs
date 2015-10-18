using HateCrimeDB.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HateCrimeDB.Data
{
    public class ExcelReaderMapper : IExcelReaderMapper
    {
        public IEnumerable<Incident> HydrateIncidents(DataTable dataTable)
        {
            return from DataRow row in dataTable.Rows
                   select new Incident
                   {
                        VictimName = row["Name"].ToString(),
                        PostCode = row["Address"].ToString(),
                        //VictimDoB = row["Code"].ToDateTime(),
                        //IncidentDate = row["Code"].ToDateTime(),
                        //IncidentType = row["Code"]
                   };            
        }
    }
}
