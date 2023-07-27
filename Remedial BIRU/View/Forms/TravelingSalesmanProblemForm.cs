using Remedial_BIRU.Classes.Algoritms;
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
using Remedial_BIRU.View.Labels;
using Remedial_BIRU.Classes.Controllers;
using Remedial_BIRU.Properties;

namespace Remedial_BIRU.View.Forms
{
    public partial class TravelingSalesmanProblemForm : Form
    {
        private List<CustomerArrearsData> customerArrearsDatas;
        private List<TravelingSalesmanProblemData> shortestRoute;
        public TravelingSalesmanProblemForm(List<CustomerArrearsData> datas)
        {
            InitializeComponent();
            customerArrearsDatas = datas;
        }

        
        private void StartTravelingSalesmanProblemAlgoritm(List<CustomerArrearsData> customerArrearsData)
        {
            List<TravelingSalesmanProblemData> points = new List<TravelingSalesmanProblemData>();
            CustomerArrearsData bankBiruLocation = new CustomerArrearsData();
            bankBiruLocation.name = "Bank BIRU";
            bankBiruLocation.contactNumber = "0251863972";
            bankBiruLocation.latitude = -6.602252;
            bankBiruLocation.longitude = 106.770706;
            points.Add(new TravelingSalesmanProblemData(bankBiruLocation, bankBiruLocation.latitude, bankBiruLocation.longitude));
            foreach (CustomerArrearsData data in customerArrearsDatas)
            {
                points.Add(new TravelingSalesmanProblemData(data, data.latitude, data.longitude));
            }
            shortestRoute = TravelingSalesmanProblem.NearestNeighborTSP(points);

            routeBeautifyPanel.Controls.Clear();
            int shortestRouteCount = shortestRoute.Count();
            int increment = 0;
            foreach (var point in shortestRoute)
            {
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Top;
                tableLayoutPanel.AutoSize = true;
                routeBeautifyPanel.Controls.Add(tableLayoutPanel);

                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                CommonLabel nameCommonLabel = new CommonLabel(point.customerArrearsData.name);
                nameCommonLabel.TextAlign = ContentAlignment.MiddleLeft;
                nameCommonLabel.Dock = DockStyle.Fill;
                nameCommonLabel.Margin = new Padding(5, 0, 0, 0);
                tableLayoutPanel.Controls.Add(nameCommonLabel, 0, 0);

                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                CommonLabel addressAndLocationPointCommonLabel = new CommonLabel($"({point.Latitude}, {point.Longitude})");
                addressAndLocationPointCommonLabel.TextAlign = ContentAlignment.MiddleRight;
                addressAndLocationPointCommonLabel.Margin = new Padding(0, 0, 5, 0);
                addressAndLocationPointCommonLabel.Dock = DockStyle.Fill;
                tableLayoutPanel.Controls.Add(addressAndLocationPointCommonLabel, 1, 0);

                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
                PictureBox whatsappCustomerPictureBox = new PictureBox();
                whatsappCustomerPictureBox.Image = Resources.whatsapp;
                whatsappCustomerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                whatsappCustomerPictureBox.Margin = new Padding(0);
                whatsappCustomerPictureBox.Size = new Size(20, 20);
                whatsappCustomerPictureBox.Tag = increment;
                whatsappCustomerPictureBox.Click += WhatsappCustomerPictureBox_Click;
                tableLayoutPanel.Controls.Add(whatsappCustomerPictureBox, 2, 0);

                tableLayoutPanel.BringToFront();

                increment++;
                if (increment == shortestRouteCount)
                {
                    break;
                }
                CommonLabel dots = new CommonLabel("⋮", 14);
                dots.Dock = DockStyle.Top;
                dots.TextAlign = ContentAlignment.MiddleCenter;
                routeBeautifyPanel.Controls.Add(dots);
                dots.BringToFront();
            }

            double totalDistance = TravelingSalesmanProblem.CalculateTotalDistance(shortestRoute);
            distanceCommonLabel.Text = $"Perkiraan jarak : {Math.Round(totalDistance)} KM";
        }

        private void WhatsappCustomerPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int index = int.Parse(pictureBox.Tag.ToString());
            string message = TextController.MessageToEmployeeTravelingRoute(shortestRoute[index]);

            Form form = new WhatsappForm(message);
            form.ShowDialog();
        }

        private void TravelingSalesmanProblemForm_Load(object sender, EventArgs e)
        {
            StartTravelingSalesmanProblemAlgoritm(customerArrearsDatas);
        }

        private void whatsappPictureBox_Click(object sender, EventArgs e)
        {
            string message = TextController.MessageToEmployeeTravelingRouteAllCustomer(shortestRoute);

            Form form = new WhatsappForm(message);
            form.ShowDialog();
        }

        private void printPictureBox_Click(object sender, EventArgs e)
        {
            List<CustomerArrearsData> customerArrearsData = new List<CustomerArrearsData>();
            shortestRoute.RemoveAt(0);
            shortestRoute.RemoveAt(shortestRoute.Count - 1);

            foreach (TravelingSalesmanProblemData travelingSalesmanProblemData in shortestRoute)
            {
                customerArrearsData.Add(travelingSalesmanProblemData.customerArrearsData);
            }
            WordController.ConvertCustomerArrearsDataToWord(customerArrearsData);
        }
    }
}
