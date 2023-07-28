using Remedial_BIRU.Classes.Controllers;
using Remedial_BIRU.DataCollections;
using Remedial_BIRU.View.Template.CustomPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remedial_BIRU.View.Forms
{
    public partial class CustomerDescriptionForm : Form
    {
        CustomerArrearsData customerArrearsData;
        public CustomerDescriptionForm(CustomerArrearsData data)
        {
            InitializeComponent();
            customerArrearsData = data;
        }

        private void EmployeeDescriptionForm_Load(object sender, EventArgs e)
        {
            if (customerArrearsData == null)
            {
                return;
            }
            NameCommonLabel.Text = customerArrearsData.name;
            uidCommonLabel.Text = customerArrearsData.uid;
            addressCommonLabel.Text = customerArrearsData.address;
            contactNumberCommonLabel.Text = customerArrearsData.contactNumber;
            informationCommonLabel.Text = customerArrearsData.daysInArrears;
            statusCommonLabel.Text = customerArrearsData.dueDate;
            ceilingCommonLabel.Text = TextController.FormatRupiah(customerArrearsData.ceiling);
            totalPaymentCommonLabel.Text = TextController.FormatRupiah(customerArrearsData.totalPayment);
            colCommonLabel.Text = customerArrearsData.col;
            latitudeCommonLabel.Text = customerArrearsData.latitude.ToString();
            longitudeCommonLabel.Text = customerArrearsData.longitude.ToString();
            googleMapsCommonLabel.Text = customerArrearsData.linkGoogleMaps;
        }

        private void openMapsButton_Click(object sender, EventArgs e)
        {
            Process.Start(googleMapsCommonLabel.Text);
        }
    }
}
