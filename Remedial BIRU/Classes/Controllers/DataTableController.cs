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
        public static async Task<DataTable> ExcelToDataTable(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            DataTable dataTable = new DataTable();

            using (var package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                string worksheetName = package.Workbook.Worksheets[0].Name;

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
