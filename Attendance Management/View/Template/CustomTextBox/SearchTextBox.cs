using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remedial_BIRU.View.Template.CustomTextBox
{
    class SearchTextBox : TextBox
    {
        public SearchTextBox()
        {
            BorderStyle = BorderStyle.None;
            Font = new Font("Century", 12, FontStyle.Regular);
            DefaultText();
        }

        private void DefaultText()
        {
            ForeColor = Color.DarkGray;
            Text = "Search...";
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            ForeColor = Color.Black;
            if (Text == "Search...")
            {
                Text = "";
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            if (Text == "")
            {
                ForeColor = Color.DarkGray;
                Text = "Search...";
            }
        }
    }
}
