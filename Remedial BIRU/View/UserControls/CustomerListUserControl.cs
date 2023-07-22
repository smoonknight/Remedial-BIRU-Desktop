using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Remedial_BIRU.View.Template.CustomTableLayoutPanel;
using Remedial_BIRU.DataCollections;

namespace Remedial_BIRU.View.UserControls
{
    public partial class CustomerListUserControl : UserControl
    {
        public CustomerListUserControl()
        {
            InitializeComponent();
        }

        private void EmployeeListUserControl_Load(object sender, EventArgs e)
        {
            tableLayoutPanel4.Controls.Clear();
            tableLayoutPanel4.RowStyles.Clear();
            int increment = 0;
            foreach (CustomerArrearsData customerArrearsData in CustomerArrearsDataCollection.customerArrearsDatas)
            {
                tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                CustomerTableColumnPanel employeeTableColumnPanel = new CustomerTableColumnPanel(customerArrearsData);
                tableLayoutPanel4.Controls.Add(employeeTableColumnPanel, 0, increment);
                increment++;
            }
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 0));
            tableLayoutPanel4.Controls.Add(new Panel(), 0, increment);
        }
    }
}
