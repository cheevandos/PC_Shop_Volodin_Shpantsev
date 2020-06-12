using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
                    int countFree = context.WarehouseComponents.Where(rec =>
                    rec.WarehouseID == model.ID).Sum(rec => rec.Free);
                    int countReserved = context.WarehouseComponents.Where(rec =>
                    rec.WarehouseID == model.ID).Sum(rec => rec.Reserved);
                    if ((countFree + countReserved) > model.Capacity)
                    {
                        throw new Exception("Новая вместимость меньше количества комплектующих на складе");
                    }
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
                warehouse.SupplierID = model.SupplierID;
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
                    .Where(rec => model == null || rec.ID == model.ID
                    || rec.SupplierID == model.SupplierID)
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

        public void Resupply(ResupplyWarehouseBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                var warehouseComponents = context.WarehouseComponents.FirstOrDefault(rec =>
                rec.WarehouseID == model.WarehouseID && rec.ComponentID == model.ComponentID);
                var warehouse = context.Warehouses.FirstOrDefault(rec => rec.ID == model.WarehouseID);
                int countFree = context.WarehouseComponents.Where(rec =>
                rec.WarehouseID == model.WarehouseID).Sum(rec => rec.Free);
                int countReserved = context.WarehouseComponents.Where(rec =>
                rec.WarehouseID == model.WarehouseID).Sum(rec => rec.Reserved);
                if ((countFree + countReserved + model.Count) > warehouse.Capacity)
                {
                    throw new Exception("Недостаточно места на складе");
                }   
                if (warehouseComponents == null)
                {
                    context.WarehouseComponents.Add(new WarehouseComponent
                    {
                        WarehouseID = model.WarehouseID,
                        ComponentID = model.ComponentID,
                        Free = model.Count,
                        Reserved = 0
                    });
                } 
                else
                {
                    warehouseComponents.Free += model.Count;
                }
                context.SaveChanges();
            }
        }

        public void Reserve(ResupplyWarehouseBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                var warehouseComponents = context.WarehouseComponents.FirstOrDefault(rec =>
                rec.WarehouseID == model.WarehouseID && rec.ComponentID == model.ComponentID);
                if (warehouseComponents != null)
                {
                    if (warehouseComponents.Free >= model.Count)
                    {
                        warehouseComponents.Free -= model.Count;
                        warehouseComponents.Reserved += model.Count;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Недостаточно комплектующих для резервирования");
                    }
                }
                else
                {
                    throw new Exception("На складе нет таких комплектующих");
                }
            }
        }

        public List<AvailableViewModel> GetAvailable(ResupplyWarehouseBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                return context.WarehouseComponents
                .Include(rec => rec.Warehouse)
                .Where(rec => rec.ComponentID == model.ComponentID
                && rec.Free >= model.Count)
                .Select(rec => new AvailableViewModel
                {
                    WarehouseID = rec.WarehouseID,
                    WarehouseName = rec.Warehouse.Name,
                    Count = rec.Free
                })
                .ToList();
            }
        }
    }
}