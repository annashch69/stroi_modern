using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stroi_modern
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void cart_btn_Click(object sender, EventArgs e)
        {
            dobavakk form = new dobavakk();
            this.Hide();
            form.Show();
        }

        private void Admin_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void goods_btn_Click(object sender, EventArgs e)
        {
            Admintov form = new Admintov();
            this.Hide();
            form.Show();
        }
        private void SendMessage()
        {
            // Настройки SMTP-сервера Mail.ru
            string smtpServer = "smtp.mail.ru"; //smpt сервер(зависит от почты отправителя)
            int smtpPort = 587; // Обычно используется порт 587 для TLS
            string smtpUsername = "shchitilina@mail.ru"; //твоя почта, с которой отправляется сообщение
            string smtpPassword = "LqbqJC6ew2Wcn554haWm";//пароль приложения (от почты)

            // Создаем объект клиента SMTP
            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                // Настройки аутентификации
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.To.Add("shchitilina@yandex.ru"); // Укажите адрес получателя
                    mailMessage.Subject = "Компания СТРОЙМОДЕРН";
                    mailMessage.Body = $"Уважаемый клиент! Только 24 февраля вся продукция будет со скидкой" +
                        $" – 20%, при указании кодового слова «Дэмоэкзамен 2023».";

                    try
                    {
                        // Отправляем сообщение
                        smtpClient.Send(mailMessage);
                        Console.WriteLine("Сообщение успешно отправлено.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка отправки сообщения: {ex.Message}");
                    }
                }
            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
    }
}
