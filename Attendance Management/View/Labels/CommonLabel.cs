using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Attendance_Management.View.Labels
{
    class CommonLabel : Label
    {
        public CommonLabel()
        {
            AutoSize = false;
            Font = new Font("Century", 12, FontStyle.Regular);
        }

        public CommonLabel(string text, int fontSize = 12)
        {
            AutoSize = false;
            Text = text;
            Font = new Font("Century", fontSize, FontStyle.Regular);
        }
    }
}
