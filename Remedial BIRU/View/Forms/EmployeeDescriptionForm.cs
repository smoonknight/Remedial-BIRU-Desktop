using Remedial_BIRU.Classes.Controllers;
using Remedial_BIRU.DataCollections;
using Remedial_BIRU.View.Template.CustomPanel;
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

namespace Remedial_BIRU.View.Forms
{
    public partial class EmployeeDescriptionForm : Form
    {
        CustomerArrearsData customerArrearsData;
        public EmployeeDescriptionForm(CustomerArrearsData data)
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
            nameUnderPhotoCommonLabel.Text = customerArrearsData.name;
            addressCommonLabel.Text = customerArrearsData.address;
            contactNumberCommonLabel.Text = customerArrearsData.contactNumber;
            informationCommonLabel.Text = customerArrearsData.information;
            statusCommonLabel.Text = customerArrearsData.status;
            ceilingCommonLabel.Text = customerArrearsData.ceiling;
            totalPaymentCommonLabel.Text = customerArrearsData.totalPayment;
            colCommonLabel.Text = customerArrearsData.col;
            latitudeCommonLabel.Text = customerArrearsData.latitude;
            longitudeCommonLabel.Text = customerArrearsData.longitude;
        }
    }
}
