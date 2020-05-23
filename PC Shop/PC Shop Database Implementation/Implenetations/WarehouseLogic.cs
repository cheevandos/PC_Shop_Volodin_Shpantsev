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
    public class WarehouseLogic : IWarehouseLogic
    {
        public void CreateOrUpdate(WarehouseBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                Warehouse warehouse = context.Warehouses.FirstOrDefault(rec =>
                rec.Name == model.Name && rec.ID != model.ID);
                if (warehouse != null)
                {
                    throw new Exception("Уже есть склад с таким названием");
                }
                if (model.ID.HasValue)
                {
                    warehouse = context.Warehouses.FirstOrDefault(rec => rec.ID == model.ID);
                    if (warehouse == null)
                    {
                        throw new Exception("Склад не найден");
                    }
                }
                else
                {
                    warehouse = new Warehouse();
                    context.Warehouses.Add(warehouse);
                }
                warehouse.Name = model.Name;
                warehouse.Capacity = model.Capacity;
                context.SaveChanges();
            }
        }

        public void Delete(WarehouseBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.WarehouseComponents.RemoveRange(context.WarehouseComponents.Where(rec =>
                        rec.WarehouseID == model.ID));
                        Warehouse warehouse = context.Warehouses.FirstOrDefault(rec => rec.ID == model.ID);
                        if (warehouse != null)
                        {
                            context.Warehouses.Remove(warehouse);
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Склад не найден");
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

        public List<WarehouseViewModel> Read(WarehouseBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                return context.Warehouses
                    .Where(rec => model == null || rec.ID == model.ID)
                    .ToList()
                    .Select(rec => new WarehouseViewModel
                    {
                        ID = rec.ID,
                        Name = rec.Name,
                        Capacity = rec.Capacity,
                        Components = context.WarehouseComponents
                            .Include(recCC => recCC.Component)
                            .Where(recCC => recCC.WarehouseID == rec.ID)
                            .ToDictionary(recCC => recCC.ComponentID, recCC =>
                            (recCC.Component?.Name, recCC.Free, recCC.Reserved))
                    })
                    .ToList();
            }
        }
    }
}