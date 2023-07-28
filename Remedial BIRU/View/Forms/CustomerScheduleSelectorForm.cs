using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Remedial_BIRU.DataCollections;

namespace Remedial_BIRU.View.Forms
{
    public partial class CustomerScheduleSelectorForm : Form
    {
        List<CheckBox> checkBoxes = new List<CheckBox>();
        List<CustomerArrearsData> customerArrearsDatas = new List<CustomerArrearsData>();

        public CustomerScheduleSelectorForm()
        {
            InitializeComponent();
        }

        private void CustomerScheduleSelectorForm_Load(object sender, EventArgs e)
        {
            customerArrearsDatas = CustomerArrearsDataCollection.customerArrearsDatas;
            int increment = 0;
            foreach (CustomerArrearsData customerArrearsData in customerArrearsDatas)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = $"{customerArrearsData.name}, {customerArrearsData.address}";
                checkBox.Font = new Font("Century", 12, FontStyle.Regular);
                checkBox.Dock = DockStyle.Top;
                checkBox.Tag = increment;
                schedulePanel.Controls.Add(checkBox);
                checkBoxes.Add(checkBox);

                increment++;
            }

        }

        private void createRuteButton_Click(object sender, EventArgs e)
        {
            List<CustomerArrearsData> datas = new List<CustomerArrearsData>();
            
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked == false)
                {
                    continue;
                }
                int index = int.Parse(checkBox.Tag.ToString());
                datas.Add(customerArrearsDatas[index]);
            }

            Form form = new TravelingSalesmanProblemForm(datas);
            form.Show();
            this.Dispose();
        }

        private void checkAllChecklistButton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.Checked = true;
            }
        }

        private void clearAllChecklistButton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.Checked = false;
            }
        }

        private void checklistCoordinationOnlyButton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                int index = int.Parse(checkBox.Tag.ToString());
                if (customerArrearsDatas[index].latitude == 0)
                {
                    continue;
                }
                checkBox.Checked = true;
            }
        }
    }
}
