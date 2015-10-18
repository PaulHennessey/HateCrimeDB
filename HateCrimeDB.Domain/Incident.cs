using System;

namespace HateCrimeDB.Domain
{
    public class Incident
    {
        public string VictimName { get; set; }
        public string PostCode { get; set; }
        public DateTime VictimDoB { get; set; }
        public DateTime IncidentDate { get; set; }
        public IncidentType IncidentType { get; set; }
    }
}
