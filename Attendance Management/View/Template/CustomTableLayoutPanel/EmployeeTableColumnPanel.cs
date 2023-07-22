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
    class EmployeeTableColumnPanel : TableLayoutPanel
    {
        public EmployeeTableColumnPanel(string name = "", string numberContact = "", string jobPosition = "", string departement = "", string employeeStatus = "")
        {
            Dock = DockStyle.Fill;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.01f));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.01f));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.01f));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.01f));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.63f));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.33f));

            CommonLabel nameCommonLabel = addCommonLabel(name);
            Controls.Add(nameCommonLabel, 0, 0);

            CommonLabel numberContactCommonLabel = addCommonLabel(numberContact);
            Controls.Add(numberContactCommonLabel, 1, 0);

            CommonLabel jobPositionCommonLabel = addCommonLabel(jobPosition);
            Controls.Add(jobPositionCommonLabel, 2, 0);

            CommonLabel departementCommonLabel = addCommonLabel(departement);
            Controls.Add(departementCommonLabel, 3, 0);

            CommonLabel employeeStatusCommonLabel = addCommonLabel(employeeStatus);
            Controls.Add(employeeStatusCommonLabel, 4, 0);

            Button openButton = new Button();
            openButton.FlatStyle = FlatStyle.Flat;
            openButton.AutoSize = false;
            openButton.Dock = DockStyle.Fill;
            openButton.Text = "Buka";
            openButton.Font = new Font("Century", 9, FontStyle.Regular);
            openButton.FlatAppearance.BorderColor = Color.DarkGray;
            openButton.Margin = new Padding(0);
            openButton.BackColor = Color.White;
            openButton.Margin = new Padding(5);
            openButton.Click += EmployeeTableColumnPanel_Click;
            Controls.Add(openButton, 5, 0);
        }


        private void EmployeeTableColumnPanel_Click (object sender, EventArgs e)
        {
            EmployeeDescriptionForm employeeDescriptionForm = new EmployeeDescriptionForm();
            employeeDescriptionForm.ShowDialog();
        }

        private CommonLabel addCommonLabel(string text)
        {
            CommonLabel commonLabel = new CommonLabel(text, 10);
            commonLabel.TextAlign = ContentAlignment.MiddleLeft;
            return commonLabel;
        }
    }
}
