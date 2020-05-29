using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.View_Models;
using SupplierView.Models;

namespace SupplierView.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRequestLogic requestLogic;
        private readonly IComponentLogic componentLogic;

        public AccountController(IRequestLogic requestLogic, IComponentLogic componentLogic)
        {
            this.requestLogic = requestLogic;
            this.componentLogic = componentLogic;
        }

        public IActionResult Main()
        {
            if (Program.supplier == null)
            {
                return new UnauthorizedResult();
            }
            Program.requests = requestLogic.Read(new RequestBindingModel
            {
                SupplierID = Program.supplier.ID
            });
            return View(Program.requests);
        }

        public IActionResult RequestView(int id)
        {
            if (Program.requests == null)
            {
                return View("Main");
            }
            ViewBag.RequestID = id;
            var components = Program.requests.FirstOrDefault(rec => rec.ID == id).Components;
            return View(components);
        }
    }
}