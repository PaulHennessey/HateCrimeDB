using System.Data;

namespace HateCrimeDB.Data
{
    public interface IExcelReaderRepository
    {
        DataTable UploadExcel(string filename);
    }
}
