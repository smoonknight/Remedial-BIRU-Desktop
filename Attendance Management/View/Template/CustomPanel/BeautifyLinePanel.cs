using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management.Classes.CustomColor;

namespace Attendance_Management.View.Template.CustomPanel
{
    class BeautifyLinePanel : Panel
    {
        public LinePanel linePanel = new LinePanel();

        public BeautifyLinePanel()
        {
            TableLayoutPanel mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));
            mainTableLayoutPanel.Margin = new Padding(0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;

            linePanel.Margin = new Padding(0);
            linePanel.Dock = DockStyle.Fill;

            mainTableLayoutPanel.Controls.Add(new Panel(), 0, 0);
            mainTableLayoutPanel.Controls.Add(linePanel, 1, 0);
            mainTableLayoutPanel.Controls.Add(new Panel(), 2, 0);

            Controls.Add(mainTableLayoutPanel);
        }
    }
}
