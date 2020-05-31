using Microsoft.AspNetCore.Mvc;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;

namespace SupplierView.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRequestLogic requestLogic;
        private readonly IWarehouseLogic warehouseLogic;

        public AccountController(IRequestLogic requestLogic, IWarehouseLogic warehouseLogic)
        {
            this.requestLogic = requestLogic;
            this.warehouseLogic = warehouseLogic;
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
            if (TempData["ReserveError"] != null)
            {
                ModelState.AddModelError("", TempData["ReserveError"].ToString());
            }
            ViewBag.RequestID = id;
            var components = requestLogic.Read(new RequestBindingModel
            {
                SupplierID = Program.Supplier.ID
            })?[0].Components;
            return View(components);
        }

        public IActionResult ListAvailable(int id, int count, string name, int requestID)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            ViewBag.ComponentName = name;
            ViewBag.Count = count;
            ViewBag.ComponentID = id;
            ViewBag.RequestID = requestID;
            var warehouses = warehouseLogic.GetAvailable(new WarehouseComponentsBindingModel
            {
                ComponentID = id,
                Count = count
            });
            return View(warehouses);
        }
    }
}