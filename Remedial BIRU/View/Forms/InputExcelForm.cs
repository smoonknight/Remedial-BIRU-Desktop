using Newtonsoft.Json;
using OfficeOpenXml;
using Remedial_BIRU.Classes.Controllers;
using Remedial_BIRU.DataCollections;
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
        List<string> dataTableList = new List<string>();

        struct customerArrearsAndComboBoxes
        {
            public List<string> customerArrearData;
            public ComboBox comboBoxData;

            public customerArrearsAndComboBoxes(List<string> customerArrear, ComboBox comboBox)
            {
                this.customerArrearData = customerArrear;
                this.comboBoxData = comboBox;
            }
        }
        
        string path;

        public InputExcelForm(string directory = @"D:\debug.xlsx")
        {
            InitializeComponent();
            path = directory;
        }

        private async void InputExcelForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = await DataTableController.ExcelToDataTable(path);
            customerDataGridView.DataSource = dataTable;

            foreach (DataColumn dataColumn in dataTable.Columns)
            {
                dataTableList.Add(dataColumn.ColumnName);
            }

            SetComboBoxValue();
            await StartAutomaticMatchData();
        }

        private async void automaticMatchDataButton_Click(object sender, EventArgs e)
        {
            await StartAutomaticMatchData();
        }

        private async Task StartAutomaticMatchData()
        {
            string json = File.ReadAllText("Data/automatic-match.json");
            AutomaticMatchData automaticMatchData = JsonConvert.DeserializeObject<AutomaticMatchData>(json);

            List<customerArrearsAndComboBoxes> properties = new List<customerArrearsAndComboBoxes>
            {
                new customerArrearsAndComboBoxes(automaticMatchData.name, nameComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.address, addressComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.contactNumber, contactNumberComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.information, informationComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.status, statusComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.ceiling, ceilingComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.totalPayment, totalPaymentComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.col, colComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.latitude, latitudeComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.longitude, longitudeComboBox)
            };

            foreach (customerArrearsAndComboBoxes property in properties)
            {
                foreach (string value in property.customerArrearData)
                {
                    foreach (string data in dataTableList)
                    {
                        if (value == data)
                        {
                            property.comboBoxData.SelectedItem = data;
                            break;
                        }
                    }
                }
            }
        }

        private void SetComboBoxValue()
        {
            List<ComboBox> comboBoxes = new List<ComboBox>()
            {
                nameComboBox,
                addressComboBox,
                contactNumberComboBox,
                informationComboBox,
                statusComboBox,
                ceilingComboBox,
                totalPaymentComboBox,
                colComboBox,
                latitudeComboBox,
                longitudeComboBox
            };

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.Items.Clear();
                comboBox.Items.AddRange(dataTableList.ToArray());
                comboBox.SelectedIndex = 0;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SetComboBoxValue();
        }
    }
}
