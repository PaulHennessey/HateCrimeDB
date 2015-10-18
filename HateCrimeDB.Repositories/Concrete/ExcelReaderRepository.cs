using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HateCrimeDB.Data  
{
    public class ExcelReaderRepository : IExcelReaderRepository
    {
        public DataTable UploadExcel(string filename)
        {
            FileInfo file = new FileInfo(filename);
            ExcelPackage package = new ExcelPackage(file);

            DataTable dt = ToDataTable(package);

            return dt;
        }

        public DataTable ToDataTable(ExcelPackage pck)
        {
            bool hasHeader = true;

            var ws = pck.Workbook.Worksheets.First();
            DataTable tbl = new DataTable();
            foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
            {
                tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
            }
            var startRow = hasHeader ? 2 : 1;
            for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
            {
                var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                DataRow row = tbl.Rows.Add();
                foreach (var cell in wsRow)
                {
                    row[cell.Start.Column - 1] = cell.Text;
                }
            }
            return tbl;
        }

    }
}
