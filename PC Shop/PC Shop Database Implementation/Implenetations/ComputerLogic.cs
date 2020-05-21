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
    class ComputerLogic : IComputerLogic
    {
        public void CreateOrUpdate(ComputerBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Computer computer = context.Computers.FirstOrDefault(rec =>
                        rec.Name == model.Name && rec.ID != model.ID);
                        if (computer != null)
                        {
                            throw new Exception("Уже есть ПК с таким названием");
                        }
                        if (model.ID.HasValue)
                        {
                            computer = context.Computers.FirstOrDefault(rec => rec.ID == model.ID);
                            if (computer == null)
                            {
                                throw new Exception("ПК не найден");
                            }
                        }
                        else
                        {
                            computer = new Computer();
                            context.Computers.Add(computer);
                        }
                        computer.Name = model.Name;
                        computer.Price = model.Price;
                        context.SaveChanges();
                        if (model.ID.HasValue)
                        {
                            var computerComponents = context.ComputerComponents.Where(rec =>
                            rec.ComputerID == model.ID.Value).ToList();
                            context.ComputerComponents.RemoveRange(computerComponents.Where(rec =>
                            !model.Components.ContainsKey(rec.ComponentID)).ToList());
                            context.SaveChanges();
                            foreach (var updComponent in computerComponents)
                            {
                                updComponent.Count = model.Components[updComponent.ComponentID].Item2;
                                model.Components.Remove(updComponent.ComponentID);
                            }
                            context.SaveChanges();
                        }
                        foreach (var component in model.Components)
                        {
                            context.ComputerComponents.Add(new ComputerComponent
                            {
                                ComputerID = computer.ID,
                                ComponentID = component.Key,
                                Count = component.Value.Item2
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

        public void Delete(ComputerBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.ComputerComponents.RemoveRange(context.ComputerComponents.Where(rec =>
                        rec.ComputerID == model.ID));
                        Computer computer = context.Computers.FirstOrDefault(rec => rec.ID == model.ID);
                        if (computer != null)
                        {
                            context.Computers.Remove(computer);
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("ПК не найден");
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

        public List<ComputerViewModel> Read(ComputerBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                return context.Computers
                    .Where(rec => model == null || rec.ID == model.ID)
                    .ToList()
                    .Select(rec => new ComputerViewModel
                    {
                        ID = rec.ID,
                        Name = rec.Name,
                        Price = rec.Price,
                        Components = context.ComputerComponents
                            .Include(recCC => recCC.Component)
                            .Where(recCC => recCC.ComputerID == rec.ID)
                            .ToDictionary(recCC => recCC.ComponentID, recCC =>
                            (recCC.Component?.Name, recCC.Count))
                    })
                    .ToList();
            }
        }
    }
}
