using Microsoft.AspNetCore.Mvc;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;

namespace SupplierView.Controllers
{
    public class ComponentsController : Controller
    {
        private readonly IComponentLogic componentLogic;
        private readonly IWarehouseLogic warehouseLogic;

        public ComponentsController(IComponentLogic componentLogic, IWarehouseLogic warehouseLogic)
        {
            this.componentLogic = componentLogic;
            this.warehouseLogic = warehouseLogic;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Resupply([Bind("WarehouseID, ComponentID, Count")] UpdateComponentsBindingModel model)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    warehouseLogic.Resupply(model);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return RedirectToAction("Resupply", "Components", new
                    {
                        componentID = model.ComponentID,
                        warehouseID = model.WarehouseID
                    });
                }
            }
            return RedirectToAction("Details", new { id = model.WarehouseID });
        }
    }
}
