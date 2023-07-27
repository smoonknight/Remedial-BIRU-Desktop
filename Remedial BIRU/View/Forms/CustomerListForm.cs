using Remedial_BIRU.DataCollections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remedial_BIRU.View.Forms
{
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void visitButton_Click(object sender, EventArgs e)
        {
            Form form = new TravelingSalesmanProblemForm(CustomerArrearsDataCollection.customerArrearsDatas);
            form.Show();
        }
    }
}
