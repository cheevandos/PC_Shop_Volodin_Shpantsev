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
    public class RequestLogic : IRequestLogic
    {
        public void CreateOrUpdate(RequestBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                Request request;
                if (model.ID.HasValue)
                {
                    request = context.Requests.FirstOrDefault(rec => rec.ID == model.ID);
                    if (request == null)
                    {
                        throw new Exception("Заявка не найдена");
                    }
                }
                else
                {
                    request = new Request();
                    context.Requests.Add(request);
                }
                request.SupplierID = model.SupplierID;
                request.Status = model.Status;
                request.ComponentID = model.ComponentID;
                request.Count = model.Count;
                context.SaveChanges();
            }
        }

        public void Delete(RequestBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                Request request = context.Requests.FirstOrDefault(rec => rec.ID == model.ID);
                if (request != null)
                {
                    context.Requests.Remove(request);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Заявка не найдена");
                }
            }
        }

        public List<RequestViewModel> Read(RequestBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                return context.Requests
                .Include(rec => rec.Component)
                .Include(rec => rec.Supplier)
                .Where(rec => model == null || rec.ID == model.ID)
                .Select(rec => new RequestViewModel
                {
                    ID = rec.ID,
                    SupplierID = rec.SupplierID,
                    SupplierName = rec.Supplier.FullName,
                    ComponentID = rec.ComponentID,
                    ComponentName = rec.Component.Name,
                    Count = rec.Count,
                    Status = rec.Status
                })
                .ToList();
            }
        }
    }
}
