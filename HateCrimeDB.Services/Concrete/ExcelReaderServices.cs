using HateCrimeDB.Domain;
using HateCrimeDB.Data;
using System;
using System.Collections.Generic;
using System.Data;

namespace HateCrimeDB.Services
{
    public class ExcelReaderServices : IExcelReaderServices
    {
        private readonly IExcelReaderRepository _excelReaderRepository;
        private readonly IExcelReaderMapper _excelReaderMapper;

        public ExcelReaderServices()
        {}

        public ExcelReaderServices(IExcelReaderRepository repo, IExcelReaderMapper mapper)
        {
            _excelReaderRepository = repo;
            _excelReaderMapper = mapper;
        }

        public IEnumerable<Incident> GetIncidents()
        {
            DataTable table = _excelReaderRepository.UploadExcel("C:\\Users\\Paul\\Desktop\\Merlin.xlsx");
            return _excelReaderMapper.HydrateIncidents(table);
        }
    }
}
