using Attendance_Management.View.Labels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management.View.Template.CustomPanel
{
    class OverviewCardPanel : Panel
    {
        public Image image;

        public string number 
        {
            get 
            {
                return _number;
            }
            set 
            {
                _number = value;
                numberCommonLabel.Text = value;
            }
        }
        string _number;

        public string name
        {
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
                nameCommonLabel.Text = value;
            }
        }
        string _name;

        CommonLabel numberCommonLabel = new CommonLabel();
        CommonLabel nameCommonLabel = new CommonLabel();

        public OverviewCardPanel()
        {
            TableLayoutPanel mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.Dock = DockStyle.Fill;

            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));

            Label label = new Label();

            label.Text = "...";
            label.AutoSize = false;
            label.Dock = DockStyle.Right;
            label.TextAlign = ContentAlignment.MiddleRight;

            mainTableLayoutPanel.Controls.Add(label, 0, 0);

            TableLayoutPanel contentTableLayoutPanel = new TableLayoutPanel();
            contentTableLayoutPanel.Dock = DockStyle.Fill;
            contentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30));
            contentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(50, 50);
            pictureBox.Margin = new Padding(20);
            contentTableLayoutPanel.Controls.Add(pictureBox, 0, 0);

            Panel numberAndNamePanel = new Panel();
            numberAndNamePanel.Dock = DockStyle.Fill;

            numberCommonLabel.Dock = DockStyle.Bottom;
            numberAndNamePanel.Controls.Add(numberCommonLabel);

            nameCommonLabel.Dock = DockStyle.Bottom;
            numberAndNamePanel.Controls.Add(nameCommonLabel);

            contentTableLayoutPanel.Controls.Add(numberAndNamePanel, 1, 0);

            mainTableLayoutPanel.Controls.Add(contentTableLayoutPanel, 0, 1);

            mainTableLayoutPanel.Controls.Add(new Panel(), 0, 2);

            Controls.Add(mainTableLayoutPanel);
        }
    }
}
