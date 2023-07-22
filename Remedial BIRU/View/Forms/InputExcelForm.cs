using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remedial_BIRU.View.Forms
{
    public partial class InputExcelForm : Form
    {
        string path;
        public InputExcelForm(string directory = @"D:\Tungakan Nasabah.xlsx")
        {
            InitializeComponent();
            path = directory;
        }

        private void InputExcelForm_Load(object sender, EventArgs e)
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
                        dataTable.Columns.Add(cellValue.ToString());
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

                // Set DataGridView's DataSource ke DataTable yang telah dibuat
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
