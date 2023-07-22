using Remedial_BIRU.View.Forms;
using Remedial_BIRU.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remedial_BIRU
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void inputDataExcelButton_Click(object sender, EventArgs e)
        {
            Form form = new InputExcelForm();
            form.Show();
        }
    }
}
