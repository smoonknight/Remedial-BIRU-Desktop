using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remedial_BIRU.Classes.Controllers
{
    class DataTableController
    {

        public static List<string> ExcelToListString(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            List<string> listString = new List<string>();
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(path, false))
            {
                // Dapatkan koleksi worksheet dari workbook
                var workbookPart = spreadsheetDocument.WorkbookPart;
                var sheets = workbookPart.Workbook.Sheets.Elements<Sheet>();

                // Loop melalui semua worksheet dan ambil nama worksheet-nya
                foreach (Sheet sheet in sheets)
                {
                    string namaWorksheet = sheet.Name;
                    listString.Add(namaWorksheet);
                }
            }
            return listString;
        }
        
        public static async Task<DataTable> ExcelToDataTable(string path, string nameOfWorksheet)
        {
            FileInfo fileInfo = new FileInfo(path);
            DataTable dataTable = new DataTable();

            using (var package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[nameOfWorksheet];
                string worksheetName = package.Workbook.Worksheets[nameOfWorksheet].Name;

                int rowCount = worksheet.Dimension.Rows;
                int columnCount = worksheet.Dimension.Columns;

                for (int col = 1; col <= columnCount; col++)
                {
                    object cellValue = worksheet.Cells[1, col].Value;
                    if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                    {
                        dataTable.Columns.Add(cellValue.ToString().ToLower());
                    }
                }

                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow dataRow = dataTable.NewRow();

                    for (int col = 1; col <= columnCount; col++)
                    {
                        object cellValue = worksheet.Cells[row, col].Value;
                        if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                        {
                            dataRow[col - 1] = cellValue;
                        }
                    }

                    dataTable.Rows.Add(dataRow);
                }

                return dataTable;
            }
        }
    }
}
