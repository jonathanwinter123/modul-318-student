using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace SwissTransport.WinFormsUI
{
    public partial class sendConnectionsViaMailForm : Form
    {
        private DataGridView dgv;
        public sendConnectionsViaMailForm(DataGridView dgvTripShowFoundTrips)
        {
            InitializeComponent();
            dgv = dgvTripShowFoundTrips;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            string mailBody = "<table width='100%' style='border:Solid 1px Black;'>";

            foreach (DataGridViewRow row in dgv.Rows)
            {
                mailBody += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    mailBody += "<td stlye='color:blue;'>" + cell.Value + "</td>";
                }
                mailBody += "</tr>";
            }
            mailBody += "</table>";

            if (txtFromSmtpServer.Text != String.Empty && txtFromMailCredentialUsername.Text != String.Empty && txtFromMailCredentialPassword.Text != String.Empty && txtSenderMail.Text != String.Empty && txtRecipientMail.Text != String.Empty)
            {

            }
            var client = new SmtpClient(txtFromSmtpServer.Text, Convert.ToInt32(txtFromSmtpPort.Value));
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(txtFromMailCredentialUsername.Text, txtFromMailCredentialPassword.Text);

            var mail = new MailMessage();
            mail.From = new MailAddress(txtSenderMail.Text);
            mail.To.Add(txtRecipientMail.Text);
            mail.Subject = "Public transportation connections sent by 'This Software'";
            mail.Body = mailBody;
            client.Send(mail);
        }
    }
}
