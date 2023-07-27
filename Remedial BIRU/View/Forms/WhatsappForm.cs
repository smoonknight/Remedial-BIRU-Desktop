using Remedial_BIRU.Classes.Controllers;
using System;
using System.Windows.Forms;

namespace Remedial_BIRU.View.Forms
{
    public partial class WhatsappForm : Form
    {
        string textMessage;
        public WhatsappForm(string text)
        {
            InitializeComponent();
            textMessage = text;
        }

        private void whatsappPictureBox_Click(object sender, EventArgs e)
        {
            if (messageTextRichTextBox.Text.Length > 700)
            {
                DialogResult result = MessageBox.Show("Kalimat lebih dari 700 kata, copy ke clipboard saja?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    SetClipboard(messageTextRichTextBox.Text);
                    MessageBox.Show("kalimat telah di copy, silahkan kirim dan pastekan ke petugas (CTRL + V ke whatsapp petugas)");
                }

                return;
            }
            WhatsappController.SendMessageForEmployeeToTravelingRoute(employeeNumberTextBox.Text, messageTextRichTextBox.Text);
        }

        private void SetClipboard(string text)
        {
            Clipboard.SetText(text);
        }

        private void WhatsappForm_Load(object sender, EventArgs e)
        {
            messageTextRichTextBox.Text = textMessage;
        }

        private void messageTextRichTextBox_TextChanged(object sender, EventArgs e)
        {
            counterCommonLabel.Text = $"{messageTextRichTextBox.Text.Length}/700";
        }
    }
}
