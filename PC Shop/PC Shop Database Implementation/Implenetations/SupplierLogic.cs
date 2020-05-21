using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.View_Models;
using PC_Shop_Database_Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PC_Shop_Database_Implementation.Implenetations
{
    public class SupplierLogic : ISupplierLogic
    {
        public void CreateOrUpdate(SupplierBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                Supplier supplier = context.Suppliers.FirstOrDefault(rec =>
                rec.Login == model.Login && rec.ID != model.ID);
                if (supplier != null)
                {
                    throw new Exception("Поставщик уже зарегристрирован");
                }
                if (model.ID.HasValue)
                {
                    supplier = context.Suppliers.FirstOrDefault(rec => rec.ID == model.ID);
                    if (supplier == null)
                    {
                        throw new Exception("Поставщик не найден");
                    }
                }
                else
                {
                    supplier = new Supplier();
                    context.Suppliers.Add(supplier);
                }
                supplier.WarehouseID = model.WarehouseID;
                supplier.FullName = model.FullName;
                supplier.Login = model.Login;
                supplier.Password = model.Password;
                context.SaveChanges();
            }
        }

        public void Delete(SupplierBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                Supplier supplier = context.Suppliers.FirstOrDefault(rec => rec.ID == model.ID);
                if (supplier != null)
                {
                    context.Suppliers.Remove(supplier);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Поставщик не найден");
                }
            }
        }

        public List<SupplierViewModel> Read(SupplierBindingModel model)
        {
            using (var context = new PCShopDatabase())
            {
                return context.Suppliers
                .Where(rec => model == null || rec.ID == model.ID
                || rec.Login == model.Login && rec.Password == model.Password)
                .Select(rec => new SupplierViewModel
                {
                    ID = rec.ID,
                    FullName = rec.FullName,
                    Login = rec.Login,
                    Password = rec.Password
                })
                .ToList();
            }
        }
    }
}
