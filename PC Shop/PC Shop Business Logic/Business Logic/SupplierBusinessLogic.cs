using System;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.Enums;

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

        public void ResupplyWarehouse()
        {

        }
    }
}
