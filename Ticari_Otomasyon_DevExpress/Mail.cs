using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Ticari_Otomasyon_DevExpress
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }
        public string mail;
        private void Mail_Load(object sender, EventArgs e)
        {
            txtalıcı.Text = mail;
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("legolasgfb431907@outlook.com", "46412121998a");
                istemci.Port = 587;
                istemci.Host = "smtp.live.com";
                istemci.EnableSsl = true;
                mesaj.To.Add(txtalıcı.Text);
                mesaj.From = new MailAddress("legolasgfb431907@outlook.com");
                mesaj.Subject = txtkonu.Text;
                mesaj.Body = txtalıcı.Text;
                istemci.Send(mesaj);
                MessageBox.Show("Mesajınız İletildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Mesajınız İletilemedi Gönderdiğiniz Adresin Doğru Olduğundan Emin Olun Veya Destek Birimimizle İletişime Geçin","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
    }
}
