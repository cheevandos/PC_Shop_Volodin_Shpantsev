using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.Binding_Models;

namespace SupplierView.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRequestLogic requestLogic;

        public AccountController(IRequestLogic requestLogic)
        {
            this.requestLogic = requestLogic;
        }

        public IActionResult Main()
        {
            if (Program.supplier == null)
            {
                return new UnauthorizedResult();
            }
            var requests = requestLogic.Read(new RequestBindingModel
            {
                SupplierID = Program.supplier.ID
            });
            return View(requests);
        }
    }
}