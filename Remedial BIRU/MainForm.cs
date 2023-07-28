using Remedial_BIRU.View.Forms;
using Remedial_BIRU.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileDirectory = openFileDialog1.FileName;

                Form form = new SelectWorksheetExcelForm(fileDirectory);
                form.Show();
            }
            
        }
    }
}
