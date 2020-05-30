using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;

namespace SupplierView.Controllers
{
    public class ComponentsController : Controller
    {
        private readonly IComponentLogic componentLogic;

        public ComponentsController(IComponentLogic componentLogic)
        {
            this.componentLogic = componentLogic;
        }

        public IActionResult List(int warehouseID)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            ViewBag.warehouseID = warehouseID;
            return View(componentLogic.Read(null));
        }

        public IActionResult Resupply(int? componentID, int? warehouseID)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            if (componentID == null && warehouseID == null)
            {
                return NotFound();
            }
            if (TempData["WarehouseSizeError"] != null)
            {
                ModelState.AddModelError("", TempData["WarehouseSizeError"].ToString());
            }
            var component = componentLogic.Read(new ComponentBindingModel
            {
                ID = componentID
            })?[0];
            if (component == null)
            {
                return NotFound();
            }
            ViewBag.componentName = component.Name;
            ViewBag.warehouseID = warehouseID;
            return View(new UpdateComponentsBindingModel
            {
                ComponentID = componentID.Value,
                WarehouseID = warehouseID.Value,
            });
        }
    }
}
