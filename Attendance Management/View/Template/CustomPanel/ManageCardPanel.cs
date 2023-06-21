using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management.Classes.CustomColor;
using Attendance_Management.Properties;
using Attendance_Management.View.Labels;
using Attendance_Management.Template.CustomPanel;

namespace Attendance_Management.View.Template.CustomPanel
{
    class ManageCardPanel : BeautifyPanel
    {
        public ManageCardPanel()
        {
            Margin = new Padding(0, 0, 20, 20);
            Size = new Size(275, 185);
            BackColor = Pallete.ThirdColor;
            BorderRadius = 30;

            TableLayoutPanel mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.Controls.Clear();
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 75));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));

            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.BackColor = Color.Red;
            mainTableLayoutPanel.Controls.Add(headerPanel, 0, 0);

            Panel emailPanel = ManageDescriptionPanel(Resources.mail, "scw.satriacandrawinata@gmail.com", false);
            mainTableLayoutPanel.Controls.Add(emailPanel, 0, 1);

            Panel numberPanel = ManageDescriptionPanel(Resources.mail, "0821-2345-6789");
            mainTableLayoutPanel.Controls.Add(numberPanel, 0, 2);

            Panel conditionLabel = ManageDescriptionPanel(Resources.mail, "active");
            mainTableLayoutPanel.Controls.Add(conditionLabel, 0, 3);

            this.Controls.Add(mainTableLayoutPanel);
        }

        private Panel ManageDescriptionPanel(Image image, string text, bool addBeutifyline = true)
        {
            Panel managePanel = new Panel();
            managePanel.Dock = DockStyle.Fill;

            TableLayoutPanel manageTableLayoutPanel = new TableLayoutPanel();
            manageTableLayoutPanel.Controls.Clear();
            manageTableLayoutPanel.Dock = DockStyle.Fill;

            PictureBox managePictureBox = new PictureBox();
            managePictureBox.Image = image;
            managePictureBox.Size = new Size(19, 24);
            managePictureBox.Margin = new Padding(10, 7, 0, 0);
            managePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            manageTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35));
            manageTableLayoutPanel.Controls.Add(managePictureBox, 0, 0);

            CommonLabel ManageLabel = new CommonLabel(text, 8);
            ManageLabel.Dock = DockStyle.Top;
            ManageLabel.Size = new Size(194, 18);
            ManageLabel.AutoEllipsis = true;
            ManageLabel.TextAlign = ContentAlignment.MiddleLeft;
            ManageLabel.Margin = new Padding(0, 9, 0, 0);
            manageTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            manageTableLayoutPanel.Controls.Add(ManageLabel, 1, 0);

            BeautifyLinePanel beautifyLinePanel = new BeautifyLinePanel();
            beautifyLinePanel.Dock = DockStyle.Top;
            beautifyLinePanel.Size = new Size(2, 2);
            beautifyLinePanel.linePanel.BackColor = Color.DarkGray;
            
            if (addBeutifyline)
            {
                managePanel.Controls.Add(beautifyLinePanel);
            }
            managePanel.Controls.Add(manageTableLayoutPanel);

            return managePanel;
        }
    }
}
