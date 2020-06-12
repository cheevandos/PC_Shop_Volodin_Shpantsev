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
    public class ComponentMovementLogic : IComponentMovementLogic
    {
        public void Delete(RequestBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                if (model.ID.HasValue)
                {
                    foreach(var requestComponent in model.Components)
                    {
                        context.ComponentMovements.Add(new ComponentMovement
                        {
                            SupplierID = model.SupplierID,
                            ComponentID = requestComponent.Key,
                            Count = requestComponent.Value.Item2,
                            Date = model.CompletionDate.Value,
                            Status = ComponentStatus.Расход
                        });
                    }
                } else
                {
                    throw new Exception("Заявка не имеет ID");
                }
                context.SaveChanges();
            }
        }

        public void Insert(ResupplyWarehouseBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                context.ComponentMovements.Add(new ComponentMovement
                {
                    SupplierID = model.SupplierID,
                    ComponentID = model.ComponentID,
                    Count = model.Count,
                    Date = model.Date,
                    Status = ComponentStatus.Приход
                });
                context.SaveChanges();
            }
        }

        public List<ComponentMovementViewModel> Read(ComponentMovementBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                return context.ComponentMovements
                .Include(move => move.Component)
                .Where(move => move.SupplierID == model.SupplierID 
                && move.Date >= model.StartDate
                && move.Date <= model.EndDate)
                .Select(move => new ComponentMovementViewModel
                {
                    ID = move.ID,
                    ComponentName = move.Component.Name,
                    Count = move.Count,
                    Date = move.Date,
                    Status = move.Status
                })
                .ToList();
            }
        }
    }
}
