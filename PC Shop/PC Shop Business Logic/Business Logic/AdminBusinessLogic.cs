using System;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.Enums;

namespace PC_Shop_Business_Logic.Business_Logic
{
    public class AdminBusinessLogic
    {
        private readonly IOrderLogic orderLogic;
        private readonly IRequestLogic requestLogic;

        public AdminBusinessLogic(IOrderLogic orderLogic, IRequestLogic requestLogic)
        {
            this.orderLogic = orderLogic;
            this.requestLogic = requestLogic;
        }

        public void CreateOrder(CreateOrderBindingModel model)
        {
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                ComputerID = model.ComputerID,
                Count = model.Count,
                Amount = model.Amount,
                CreationDate = model.CreationDate,
                Status = OrderStatus.Создан
            });
        }

        public void ConfirmOrder(ChangeOrderStatusBindingModel model)
        {
            var order = orderLogic.Read(new OrderBindingModel
            {
                ID = model.OrderID
            })?[0];
            if (order == null)
            {
                throw new Exception("Заказ не найден");
            }
            if (order.Status != OrderStatus.Создан)
            {
                throw new Exception("Заказ не в статусе \"Создан\"");
            }
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                ID = order.ID,
                ComputerID = order.ComputerID,
                Count = order.Count,
                Amount = order.Amount,
                CreationDate = order.CreationDate,
                Status = OrderStatus.Подтвержден
            });
        }

        public void StartPreparingAnOrder(ChangeOrderStatusBindingModel model)
        {
            var order = orderLogic.Read(new OrderBindingModel
            {
                ID = model.OrderID
            })?[0];
            if (order == null)
            {
                throw new Exception("Заказ не найден");
            }
            if (order.Status != OrderStatus.Подтвержден)
            {
                throw new Exception("Заказ не в статусе \"Подтвержден\"");
            }
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                ID = order.ID,
                ComputerID = order.ComputerID,
                Count = order.Count,
                Amount = order.Amount,
                CreationDate = order.CreationDate,
                Status = OrderStatus.Подготавливается
            });
        }

        public void CompleteOrder(ChangeOrderStatusBindingModel model)
        {
            var order = orderLogic.Read(new OrderBindingModel
            {
                ID = model.OrderID
            })?[0];
            if (order == null)
            {
                throw new Exception("Заказ не найден");
            }
            if (order.Status != OrderStatus.Подготавливается)
            {
                throw new Exception("Заказ не в статусе \"Подготавливается\"");
            }
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                ID = order.ID,
                ComputerID = order.ComputerID,
                Count = order.Count,
                Amount = order.Amount,
                CreationDate = order.CreationDate,
                CompletionDate = order.CompletionDate,
                Status = OrderStatus.Готов
            });
        }

        public void PayOrder(ChangeOrderStatusBindingModel model)
        {
            var order = orderLogic.Read(new OrderBindingModel
            {
                ID = model.OrderID
            })?[0];
            if (order == null)
            {
                throw new Exception("Заказ не найден");
            }
            if (order.Status != OrderStatus.Готов)
            {
                throw new Exception("Заказ не в статусе \"Готов\"");
            }
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                ID = order.ID,
                ComputerID = order.ComputerID,
                Count = order.Count,
                Amount = order.Amount,
                CreationDate = order.CreationDate,
                CompletionDate = order.CompletionDate,
                Status = OrderStatus.Оплачен
            });
        }

        public void CreateRequest(CreateRequestBindingModel model)
        {
            requestLogic.CreateOrUpdate(new RequestBindingModel
            {
                SupplierID = model.SupplierID,
                Status = RequestStatus.Создана,
                Components = model.Components
            });
        }
    }
}
