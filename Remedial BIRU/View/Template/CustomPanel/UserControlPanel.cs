using Remedial_BIRU.View.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remedial_BIRU.View.Template.CustomPanel
{
    class UserControlPanel : Panel
    {
        public UserControl currentUserControl;

        public UserControlPanel()
        {
            Dock = DockStyle.Fill;
        }

        public void SetCurrentUserControl(UserControl userControl)
        {
            Controls.Remove(currentUserControl);
            currentUserControl = userControl;
            Controls.Add(new LinePanel());
        }
    }
}
