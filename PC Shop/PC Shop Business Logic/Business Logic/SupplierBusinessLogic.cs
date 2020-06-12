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
        private readonly IComponentMovementLogic movementLogic;

        public SupplierBusinessLogic(IRequestLogic requestLogic, IComponentMovementLogic movementLogic)
        {
            this.requestLogic = requestLogic;
            this.movementLogic = movementLogic;
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
            RequestBindingModel requestModel = new RequestBindingModel
            {
                ID = request.ID,
                SupplierID = request.SupplierID,
                Status = RequestStatus.Исполнена,
                Components = request.Components,
                CompletionDate = DateTime.Now
            };
            movementLogic.Delete(requestModel);

            requestLogic.CreateOrUpdate(requestModel);
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

        public void SendReport(RequestReportInfo reportInfo)
        {
            var request = requestLogic.Read(new RequestBindingModel
            {
                ID = reportInfo.RequestID
            })?[0];
            reportInfo.CompletionDate = request.CompletionDate.Value;
            reportInfo.RequestComponents = request.Components;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            switch (reportInfo.ReportType)
            {
                case ReportType.docx:
                    path = Path.Combine(path, "report(request_" + reportInfo.RequestID + ").docx");
                    reportInfo.FileName = path;
                    WordService.CreateDoc(reportInfo);
                    break;
                case ReportType.xlsx:
                    path = Path.Combine(path, "report(request_" + reportInfo.RequestID + ").xlsx");
                    reportInfo.FileName = path;
                    ExcelService.CreatePackage(reportInfo);
                    break;
            }

            string messageText = "Заявка #"
                + reportInfo.RequestID.ToString()
                + " исполнена. Отчет прикреплен к письму.";
            EmailSendingInfo  emailInfo = new EmailSendingInfo
            {
                FilePath = path,
                RecipientMail = "appdata2101@protonmail.com",
                RecipientName = "",
                ReportType = reportInfo.ReportType,
                SenderMail = "dmitrij.volodin2020@gmail.com",
                SenderName = "Дмитрий Володин",
                SenderPassword = "",
                SendingDate = DateTime.Now,
                MessageSubject = "Отчет по заявке #" + reportInfo.RequestID.ToString(),
                MessageText = messageText,
            };
            EmailService.SendEmail(emailInfo);
        }
    }
}
