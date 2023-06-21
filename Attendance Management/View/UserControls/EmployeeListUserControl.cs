using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management.View.Template.CustomTableLayoutPanel;

namespace Attendance_Management.View.UserControls
{
    public partial class EmployeeListUserControl : UserControl
    {
        public EmployeeListUserControl()
        {
            InitializeComponent();
        }

        private void EmployeeListUserControl_Load(object sender, EventArgs e)
        {
            for (int c = 0; c < 20; c++)
            {
                EmployeeTableColumnPanel employeeTableColumnPanel = new EmployeeTableColumnPanel("satria", "08212345678", "job", "depart", "active");
                tableLayoutPanel4.Controls.Add(employeeTableColumnPanel, c, 0);
            }
        }
    }
}
