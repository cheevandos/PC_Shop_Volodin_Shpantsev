using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Enums;
using PC_Shop_Business_Logic.Helpers;
using PC_Shop_Business_Logic.Interfaces;
using System;
using System.IO;

namespace PC_Shop_Business_Logic.Business_Logic
{
    public class SupplierBusinessLogic
    {
        private readonly IRequestLogic requestLogic;

        public SupplierBusinessLogic(IRequestLogic requestLogic)
        {
            this.requestLogic = requestLogic;
        }

        public void AcceptRequest(ChangeRequestStatusBindingModel model)
        {
            var request = requestLogic.Read(new RequestBindingModel
            {
                ID = model.RequestID
            })?[0];
            if (request == null)
            {
                throw new Exception("Заявка не найдена");
            }
            if (request.Status != RequestStatus.Создана)
            {
                throw new Exception("Заявка не в статусе \"Создана\"");
            }
            requestLogic.CreateOrUpdate(new RequestBindingModel
            {
                ID = request.ID,
                SupplierID = request.SupplierID,
                Status = RequestStatus.Обрабатывается,
                Components = request.Components
            });
        }

        public void CompleteRequest(ChangeRequestStatusBindingModel model)
        {
            var request = requestLogic.Read(new RequestBindingModel
            {
                ID = model.RequestID
            })?[0];
            if (request == null)
            {
                throw new Exception("Заявка не найдена");
            }
            if (request.Status != RequestStatus.Обрабатывается)
            {
                throw new Exception("Заявка не в статусе \"Обрабатывается\"");
            }
            requestLogic.CreateOrUpdate(new RequestBindingModel
            {
                ID = request.ID,
                SupplierID = request.SupplierID,
                Status = RequestStatus.Исполнена,
                Components = request.Components
            });
        }

        public void ReserveComponents(ReserveComponentsBindingModel model)
        {
            var request = requestLogic.Read(new RequestBindingModel
            {
                ID = model.RequestID
            })?[0];
            if (request == null)
            {
                throw new Exception("Заявка не найдена");
            }
            if (request.Status != RequestStatus.Обрабатывается)
            {
                throw new Exception("Заявка не в статусе \"Обрабатывается\"");
            }
            requestLogic.Reserve(model);
        }

        public void SendWordReport(WordInfo wordInfo)
        {
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
                "report(request_" + wordInfo.RequestID + ").docx");
            var request = requestLogic.Read(new RequestBindingModel
            {
                ID = wordInfo.RequestID
            })?[0];
            wordInfo.FileName = path;
            wordInfo.CompletionDate = DateTime.Now;
            wordInfo.RequestComponents = request.Components;
            WordService.CreateDoc(wordInfo);
            string messageText = "Заявка #"
                + wordInfo.RequestID.ToString()
                + " исполнена. Отчет прикреплен к письму.";
            EmailSendingInfo  emailInfo = new EmailSendingInfo
            {
                FilePath = path,
                RecipientMail = "",
                RecipientName = "",
                ReportType = ReportType.docx,
                SenderMail = "",
                SenderName = "",
                SenderPassword = "",
                SendingDate = DateTime.Now,
                MessageSubject = "Отчет по заявке #" + wordInfo.RequestID.ToString(),
                MessageText = messageText,
            };
            EmailService.SendEmail(emailInfo);
        }
    }
}
