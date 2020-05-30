using Microsoft.AspNetCore.Mvc;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;

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
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            var requests = requestLogic.Read(new RequestBindingModel
            {
                SupplierID = Program.Supplier.ID
            });
            return View(requests);
        }

        public IActionResult RequestView(int id)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            ViewBag.RequestID = id;
            var components = requestLogic.Read(new RequestBindingModel
            {
                SupplierID = Program.Supplier.ID
            })?[0].Components;
            return View(components);
        }
    }
}