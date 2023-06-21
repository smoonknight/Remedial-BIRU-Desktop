using Attendance_Management.Classes.Controllers;
using Attendance_Management.View.Template.CustomPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management.View.Forms
{
    public partial class EmployeeDescriptionForm : Form
    {
        private int year;
        private int month;

        int Month
        {
            get => month;
            set
            {
                if (value > 12)
                {
                    year++;
                    value = 1;
                }
                else if (value < 1)
                {
                    year--;
                    value = 12;
                }

                string monthInIndonesian = DateTimeController.GetIndonesianMonth(value);
                dateCommonLabel.Text = $"{monthInIndonesian} {year}";

                month = value;

                SetMonthlyAttendanceEmployee();
            }
        }

        public EmployeeDescriptionForm()
        {
            InitializeComponent();
        }

        private void EmployeeDescriptionForm_Load(object sender, EventArgs e)
        {
            year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
        }

        private void SetMonthlyAttendanceEmployee()
        {
            monthlyAttendanceEmployeeFlowLayoutPanel.Controls.Clear();
            List<DateTime> dateTimes = DateTimeController.GetDates(year, Month);

            foreach (DateTime dateTime in dateTimes)
            {
                AttendanceDateBoxPanel attendanceDateBoxPanel = new AttendanceDateBoxPanel(dateTime, "liburnjir");
                monthlyAttendanceEmployeeFlowLayoutPanel.Controls.Add(attendanceDateBoxPanel);
            }
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            Month++;
        }

        private void prevMonthButton_Click(object sender, EventArgs e)
        {
            Month--;
        }
    }
}
