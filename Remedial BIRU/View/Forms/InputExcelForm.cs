using Newtonsoft.Json;
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
        DataTable dataTable;
        string worksheetName;

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

        public InputExcelForm(string directory, string nameOfWorksheet)
        {
            InitializeComponent();
            path = directory;
            worksheetName = nameOfWorksheet;
        }

        private async void InputExcelForm_Load(object sender, EventArgs e)
        {
            dataTable = await DataTableController.ExcelToDataTable(path, worksheetName);
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
                new customerArrearsAndComboBoxes(automaticMatchData.daysInArrears, informationComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.dueDate, statusComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.ceiling, ceilingComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.totalPayment, totalPaymentComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.col, colComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.latitude, latitudeComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.longitude, longitudeComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.uid, numberIBAComboBox),
                new customerArrearsAndComboBoxes(automaticMatchData.linkGoogleMaps, linkGooglemapsComboBox)
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
            List<ComboBox> comboBoxes = addComboBoxUsage();

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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            CustomerArrearsDataCollection.customerArrearsDatas.Clear();
            foreach (DataRow data in dataTable.Rows)
            {
                string latitude = (data[latitudeComboBox.Text].ToString() == "" ? "0" : data[latitudeComboBox.Text].ToString());
                string longitude = (data[longitudeComboBox.Text].ToString() == "" ? "0" : data[longitudeComboBox.Text].ToString());
                
                CustomerArrearsData customerArrearsData = new CustomerArrearsData();
                if (data[nameComboBox.Text].ToString() == "")
                {
                    break;
                }
                customerArrearsData.name = data[nameComboBox.Text].ToString();
                customerArrearsData.address = data[addressComboBox.Text].ToString();
                customerArrearsData.contactNumber = data[contactNumberComboBox.Text].ToString();
                customerArrearsData.daysInArrears = data[informationComboBox.Text].ToString();
                customerArrearsData.dueDate = data[statusComboBox.Text].ToString();
                customerArrearsData.ceiling = data[ceilingComboBox.Text].ToString();
                customerArrearsData.totalPayment = data[totalPaymentComboBox.Text].ToString();
                customerArrearsData.col = data[colComboBox.Text].ToString();
                customerArrearsData.latitude = double.Parse(latitude);
                customerArrearsData.longitude = double.Parse(longitude);
                customerArrearsData.uid = data[numberIBAComboBox.Text].ToString();
                customerArrearsData.linkGoogleMaps = data[linkGooglemapsComboBox.Text].ToString();

                CustomerArrearsDataCollection.customerArrearsDatas.Add(customerArrearsData);
            }

            Form form = new CustomerListForm();
            form.Show();
            this.Dispose();
        }

        private List<ComboBox> addComboBoxUsage()
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
                longitudeComboBox,
                numberIBAComboBox,
                linkGooglemapsComboBox
            };

            return comboBoxes;
        }

        private void SetWorksheetComboBox()
        {
            
        }
    }
}
