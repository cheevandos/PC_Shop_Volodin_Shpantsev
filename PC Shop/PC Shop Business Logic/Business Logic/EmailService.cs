using MailKit.Net.Smtp;
using MimeKit;
using PC_Shop_Business_Logic.Helpers;
using System.IO;
using PC_Shop_Business_Logic.Enums;

namespace PC_Shop_Business_Logic.Business_Logic
{
    public class EmailService
    {
        public static void SendEmail(EmailSendingInfo sendingInfo)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(sendingInfo.SenderName, sendingInfo.SenderMail));
            message.To.Add(new MailboxAddress(sendingInfo.RecipientName, sendingInfo.RecipientMail));
            message.Subject = sendingInfo.MessageSubject;

            var body = new TextPart("plain")
            {
                Text = sendingInfo.MessageText
            };

            string mediaType = "";
            string mediaSubtype = "";

            switch(sendingInfo.ReportType)
            {
                case ReportType.docx:
                    mediaType = "application";
                    mediaSubtype = "msword";
                    break;
                case ReportType.pdf:
                    mediaType = "application";
                    mediaSubtype = "pdf";
                    break;
                case ReportType.xlsx:
                    mediaType = "application";
                    mediaSubtype = "vnd.ms-excel";
                    break;
            }

            string path = sendingInfo.FilePath;

            var attachment = new MimePart(mediaType, mediaSubtype)
            {
                Content = new MimeContent(File.OpenRead(path), ContentEncoding.Default),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(path)
            };

            var multipart = new Multipart("mixed")
            {
                body,
                attachment
            };

            message.Body = multipart;

            string host = "";
            int port = 0;
            bool useSSL = false;
            string mailServer = sendingInfo.SenderMail.Split('@')[1];

            switch(mailServer)
            {
                case "gmail.com":
                    host = "smtp.gmail.com";
                    port = 465;
                    useSSL = true;
                    break;
                case "yandex.ru":
                    host = "smtp.yandex.ru";
                    port = 465;
                    useSSL = true;
                    break;
            }

            using (var client = new SmtpClient())
            {
                client.Connect(host, port , useSSL);
                client.Authenticate(sendingInfo.SenderMail, sendingInfo.SenderPassword);
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
