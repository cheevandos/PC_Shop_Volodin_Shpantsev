using Microsoft.AspNetCore.Mvc;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Business_Logic.Business_Logic;

namespace SupplierView.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRequestLogic requestLogic;
        private readonly IWarehouseLogic warehouseLogic;
        private readonly SupplierBusinessLogic supplierLogic;

        public AccountController(SupplierBusinessLogic supplierLogic,
            IRequestLogic requestLogic, IWarehouseLogic warehouseLogic)
        {
            this.requestLogic = requestLogic;
            this.warehouseLogic = warehouseLogic;
            this.supplierLogic = supplierLogic;
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

        public IActionResult Reserve(int reqID, int compID)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            supplierLogic.ReserveComponents(new ReserveComponentsBindingModel
            {
                RequestID = reqID,
                ComponentID = compID
            });
            return RedirectToAction("RequestView", new { id = reqID });
        }

        public IActionResult AcceptRequest(int id)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            supplierLogic.AcceptRequest(new ChangeRequestStatusBindingModel
            {
                RequestID = id
            });
            return RedirectToAction("Main");
        }

        public IActionResult CompleteRequest(int id)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            supplierLogic.CompleteRequest(new ChangeRequestStatusBindingModel
            {
                RequestID = id
            });
            return RedirectToAction("Main");
        }
    }
}