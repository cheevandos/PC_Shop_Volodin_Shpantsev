using Microsoft.EntityFrameworkCore;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Enums;
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
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Request request;
                        if (model.ID.HasValue)
                        {
                            request = context.Requests.FirstOrDefault(rec => rec.ID == model.ID);
                            if (request == null)
                            {
                                throw new Exception("Заявка не найдена");
                            }
                            var requestComponents = context.RequestComponents
                                .Where(rec => rec.RequestID == model.ID.Value).ToList();
                            context.RequestComponents.RemoveRange(requestComponents.Where(rec =>
                                !model.Components.ContainsKey(rec.ComponentID)).ToList());
                            foreach (var updComponent in requestComponents)
                            {
                                updComponent.Count = model.Components[updComponent.ComponentID].Item2;
                                updComponent.InReserve = model.Components[updComponent.ComponentID].Item3;
                                model.Components.Remove(updComponent.ComponentID);
                            }
                            context.SaveChanges();
                        }
                        else
                        {
                            request = new Request();
                            context.Requests.Add(request);
                        }
                        request.CompletionDate = model.CompletionDate;
                        request.SupplierID = model.SupplierID;
                        request.Status = model.Status;
                        context.SaveChanges();
                        foreach (var component in model.Components)
                        {
                            context.RequestComponents.Add(new RequestComponent
                            {
                                RequestID = request.ID,
                                ComponentID = component.Key,
                                Count = component.Value.Item2,
                                InReserve = false
                            });
                            context.SaveChanges();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Delete(RequestBindingModel model)
        {
            if (model.Status != RequestStatus.Обрабатывается)
            {
                using (var context = new PCShopDatabase())
                {
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.RequestComponents.RemoveRange(context
                                .RequestComponents.Where(rec => rec.RequestID == model.ID));
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
                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    } 
                }
            } 
            else
            {
                throw new Exception("Невожможно удалить заявку. Заявка в обработке");
            }
        }

        public List<RequestViewModel> Read(RequestBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                return context.Requests
                    .Include(rec => rec.Supplier)
                    .Where(rec => model == null || rec.ID == model.ID
                    || rec.SupplierID == model.SupplierID)
                    .ToList()
                    .Select(rec => new RequestViewModel
                    {
                        ID = rec.ID,
                        SupplierLogin = rec.Supplier.Login,
                        SupplierID = rec.SupplierID,
                        Status = rec.Status,
                        CompletionDate = rec.CompletionDate,
                        Components = context.RequestComponents
                            .Include(recRC => recRC.Component)
                            .Where(recRC => recRC.RequestID == rec.ID)
                            .ToDictionary(recRC => recRC.ComponentID, recPC =>
                            (recPC.Component?.Name, recPC.Count, recPC.InReserve))
                    })
                    .ToList();
            }
        }

        public void Reserve(ReserveComponentsBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                var requestComponents = context.RequestComponents.FirstOrDefault(rec =>
                rec.RequestID == model.RequestID && rec.ComponentID == model.ComponentID);
                if (requestComponents == null)
                {
                    throw new Exception("Комплектующее не найдено в заявке");
                }
                requestComponents.InReserve = true;
                context.SaveChanges();
            }
        }
    }
}
