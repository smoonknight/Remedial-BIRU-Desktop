using Attendance_Management.Classes.CustomColor;
using Attendance_Management.Template.CustomPanel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management.View.Template.CustomPanel
{
    class AttendanceDateBoxPanel : BeautifyPanel
    {
        public AttendanceDateBoxPanel(DateTime dateOfAttendance, string status)
        {
            string shortDate = dateOfAttendance.Date.ToString("dd");
            string fullDate = dateOfAttendance.ToString("dddd, dd/MM/yyyy HH:mm", new CultureInfo("id-ID")); 
            string dateTemplateText = $"{fullDate}\n{status}";

            Size = new Size(25, 25);
            Margin = new Padding(5, 5, 5, 5);
            BackColor = Pallete.BlueColor;
            BorderRadius = 5;

            Label dateLabel = new Label();
            dateLabel.Font = new Font("Century Schoolbook", 9, FontStyle.Bold);
            dateLabel.Dock = DockStyle.Fill;
            dateLabel.ForeColor = Color.White;
            dateLabel.BackColor = Color.Transparent;
            dateLabel.Text = shortDate;
            dateLabel.TextAlign = ContentAlignment.MiddleCenter;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(dateLabel, dateTemplateText);
            Controls.Add(dateLabel);
        }
    }
}
