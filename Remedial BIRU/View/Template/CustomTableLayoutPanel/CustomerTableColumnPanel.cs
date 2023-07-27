using Remedial_BIRU.DataCollections;
using Remedial_BIRU.View.Forms;
using Remedial_BIRU.View.Labels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remedial_BIRU.View.Template.CustomTableLayoutPanel
{
    class CustomerTableColumnPanel : TableLayoutPanel
    {
        CustomerArrearsData customerArrearsData;
        public CustomerTableColumnPanel(CustomerArrearsData data)
        {
            customerArrearsData = data;
            Dock = DockStyle.Fill;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));

            CommonLabel nameCommonLabel = addCommonLabel(data.name);
            Controls.Add(nameCommonLabel, 0, 0);

            CommonLabel addressCommonLabel = addCommonLabel(data.address);
            Controls.Add(addressCommonLabel, 1, 0);

            CommonLabel contactNumberCommonLabel = addCommonLabel(data.contactNumber);
            Controls.Add(contactNumberCommonLabel, 2, 0);

            CommonLabel totalPaymentCommonLabel = addCommonLabel(data.totalPayment);
            Controls.Add(totalPaymentCommonLabel, 3, 0);

            CommonLabel colCommonLabel = addCommonLabel(data.col);
            Controls.Add(colCommonLabel, 4, 0);

            Button openButton = new Button();
            openButton.FlatStyle = FlatStyle.Flat;
            openButton.AutoSize = false;
            openButton.Dock = DockStyle.Fill;
            openButton.Text = "Buka";
            openButton.Font = new Font("Century", 9, FontStyle.Regular);
            openButton.FlatAppearance.BorderColor = Color.DarkGray;
            openButton.Margin = new Padding(0);
            openButton.BackColor = Color.White;
            openButton.Click += EmployeeTableColumnPanel_Click;
            Controls.Add(openButton, 5, 0);
        }


        private void EmployeeTableColumnPanel_Click (object sender, EventArgs e)
        {
            CustomerDescriptionForm employeeDescriptionForm = new CustomerDescriptionForm(customerArrearsData);
            employeeDescriptionForm.ShowDialog();
        }

        private CommonLabel addCommonLabel(string text)
        {
            CommonLabel commonLabel = new CommonLabel(text, 10);
            commonLabel.TextAlign = ContentAlignment.MiddleLeft;
            commonLabel.Dock = DockStyle.Fill;
            return commonLabel;
        }
    }
}
