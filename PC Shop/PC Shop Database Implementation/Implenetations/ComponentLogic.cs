using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.View_Models;
using PC_Shop_Database_Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PC_Shop_Database_Implementation.Implenetations
{
    public class ComponentLogic : IComponentLogic
    {
        public void CreateOrUpdate(ComponentBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                Component component = context.Components.FirstOrDefault(rec =>
                rec.Name == model.Name && rec.ID != model.ID);
                if (component != null)
                {
                    throw new Exception("Уже есть комплектующее с таким названием");
                }
                if (model.ID.HasValue)
                {
                    component = context.Components.FirstOrDefault(rec => rec.ID == model.ID);
                    if (component == null)
                    {
                        throw new Exception("Комплектующее не найдено");
                    }
                }
                else
                {
                    component = new Component();
                    context.Components.Add(component);
                }
                component.Name = model.Name;
                context.SaveChanges();
            }
        }

        public void Delete(ComponentBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                Component component = context.Components.FirstOrDefault(rec => rec.ID == model.ID);
                if (component != null)
                {
                    context.Components.Remove(component);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Комплектующее не найдено");
                }
            }
        }

        public List<ComponentViewModel> Read(ComponentBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                return context.Components
                    .Where(rec => model == null || rec.ID == model.ID)
                    .Select(rec => new ComponentViewModel
                    {
                        ID = rec.ID,
                        Name = rec.Name
                    })
                    .ToList();
            }
        }
    }
}
