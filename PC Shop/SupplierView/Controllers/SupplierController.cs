using Microsoft.AspNetCore.Mvc;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Database_Implementation.Models;
using SupplierView.Models;
using System;
using System.Linq;

namespace SupplierView.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierLogic supplierLogic;

        public SupplierController(ISupplierLogic supplierLogic)
        {
            this.supplierLogic = supplierLogic;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel supplier)
        {
            if (String.IsNullOrEmpty(supplier.Login)
                || String.IsNullOrEmpty(supplier.Password))
            {
                return View(supplier);
            }
            var supplierView = supplierLogic.Read(new SupplierBindingModel
            {
                Login = supplier.Login,
                Password = supplier.Password
            }).FirstOrDefault();
            if (supplierView == null)
            {
                ModelState.AddModelError("", "Неверный логин или пароль");
                return View(supplier);
            }
            Program.Supplier = supplierView;
            return RedirectToAction("Main", "Account");
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(Supplier supplier)
        {
            if (String.IsNullOrEmpty(supplier.FullName)
            || String.IsNullOrEmpty(supplier.Login)
            || String.IsNullOrEmpty(supplier.Password)) {
                return View(supplier);
            }
            supplierLogic.CreateOrUpdate(new SupplierBindingModel
            {
                FullName = supplier.FullName,
                Login = supplier.Login,
                Password = supplier.Password
            });
            return RedirectToAction("Index", "Home");
        }
    }
}