using Microsoft.EntityFrameworkCore;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.View_Models;
using PC_Shop_Database_Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PC_Shop_Database_Implementation.Implenetations
{
    public class OrderLogic : IOrderLogic
    {
        public void CreateOrUpdate(OrderBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                Order order;
                if (model.ID.HasValue)
                {
                    order = context.Orders.FirstOrDefault(rec => rec.ID == model.ID);
                    if (order == null)
                    {
                        throw new Exception("Заказ не найден");
                    }
                }
                else
                {
                    order = new Order();
                    context.Orders.Add(order);
                }
                order.ComputerID = model.ComputerID;
                order.Count = model.Count;
                order.Amount = model.Amount;
                order.Status = model.Status;
                order.CreationDate = model.CreationDate;
                order.CompletionDate = model.CompletionDate;
                context.SaveChanges();
            }
        }

        public void Delete(OrderBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                Order order = context.Orders.FirstOrDefault(rec => rec.ID == model.ID);
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Заказ не найден");
                }
            }
        }

        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                return context.Orders
                .Include(rec => rec.Computer)
                .Where(rec => model == null || rec.ID == model.ID
                || model.StartDate.HasValue && model.EndDate.HasValue
                && rec.CreationDate >= model.StartDate.Value
                && rec.CreationDate <= model.EndDate.Value)
                .Select(rec => new OrderViewModel
                {
                    ID = rec.ID,
                    ComputerID = rec.ComputerID,
                    ComputerName = rec.Computer.Name,
                    Count = rec.Count,
                    Amount = rec.Amount,
                    Status = rec.Status,
                    CreationDate = rec.CreationDate,
                    CompletionDate = rec.CompletionDate
                })
                .ToList();
            }
        }

        public List<ReportOrderViewModel> ReadForReport(OrderBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                return context.Orders
                .Include(rec => rec.Computer)
                .Where(rec => model.StartDate.HasValue && model.EndDate.HasValue
                && rec.CreationDate >= model.StartDate.Value
                && rec.CreationDate <= model.EndDate.Value)
                .Select(rec => new ReportOrderViewModel
                {
                    ComputerName = rec.Computer.Name,
                    Count = rec.Count,
                    Amount = rec.Amount,
                    Status = rec.Status,
                    CreationDate = rec.CreationDate,
                    CompletionDate = rec.CompletionDate
                })
                .ToList();
            }
        }
    }
}
