using OfficeOpenXml;
using Remedial_BIRU.Classes.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remedial_BIRU.View.Forms
{
    public partial class SelectWorksheetExcelForm : Form
    {
        string filePath;
        public SelectWorksheetExcelForm(string path)
        {
            InitializeComponent();
            filePath = path;
        }

        private void SelectWorksheetExcelForm_Load(object sender, EventArgs e)
        {
            List<string> excelToListString = DataTableController.ExcelToListString(filePath);

            foreach (string excelToString in excelToListString)
            {
                worksheetComboBox.Items.Add(excelToString);
            }
        }

        private void processAutomaticMatchDataButton_Click(object sender, EventArgs e)
        {
            Form form = new InputExcelForm(filePath, worksheetComboBox.SelectedItem.ToString());
            form.Show();
            this.Dispose();
        }
    }
}
