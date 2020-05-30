using Microsoft.AspNetCore.Mvc;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Database_Implementation.Models;
using System;

namespace SupplierView.Controllers
{
    public class WarehousesController : Controller
    {
        private readonly IWarehouseLogic warehouseLogic;
        private readonly IComponentLogic componentLogic;

        public WarehousesController(IWarehouseLogic warehouseLogic, IComponentLogic componentLogic)
        {
            this.warehouseLogic = warehouseLogic;
            this.componentLogic = componentLogic;
        }

        public IActionResult List()
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            var warehouses = warehouseLogic.Read(new WarehouseBindingModel
            {
                SupplierID = Program.Supplier.ID
            });
            return View(warehouses);
        }

        public IActionResult Details(int? id)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.WarehouseID = id;
            var components = warehouseLogic.Read(new WarehouseBindingModel
            {
                ID = id
            })?[0].Components;
            return View(components);
        }

        public IActionResult Create()
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Capacity")] Warehouse warehouse)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    warehouseLogic.CreateOrUpdate(new WarehouseBindingModel
                    {
                        Name = warehouse.Name,
                        Capacity = warehouse.Capacity,
                        SupplierID = Program.Supplier.ID
                    });
                    return RedirectToAction(nameof(List));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(warehouse);
        }

        public IActionResult Edit(int? id)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            if (id == null)
            {
                return NotFound();
            }
            var warehouse = warehouseLogic.Read(new WarehouseBindingModel
            {
                ID = id
            })?[0];
            if (warehouse == null)
            {
                return NotFound();
            }
            return View(new Warehouse
            {
                ID = id.Value,
                Name = warehouse.Name,
                Capacity = warehouse.Capacity
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ID,Name,Capacity")] Warehouse warehouse)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            if (id != warehouse.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    warehouseLogic.CreateOrUpdate(new WarehouseBindingModel
                    {
                        ID = id,
                        Name = warehouse.Name,
                        Capacity = warehouse.Capacity,
                        SupplierID = Program.Supplier.ID
                    });
                }
                catch (Exception ex)
                {
                    if (!WarehouseExists(warehouse.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        ModelState.AddModelError("", ex.Message);
                        return View(warehouse);
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return View(warehouse);
        }

        public IActionResult Delete(int? id)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            if (id == null)
            {
                return NotFound();
            }
            var warehouse = warehouseLogic.Read(new WarehouseBindingModel
            {
                ID = id
            })?[0];
            if (warehouse == null)
            {
                return NotFound();
            }
            return View(new Warehouse
            {
                ID = id.Value,
                Name = warehouse.Name,
                Capacity = warehouse.Capacity
            });
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            warehouseLogic.Delete(new WarehouseBindingModel
            {
                ID = id
            });
            return RedirectToAction(nameof(List));
        }

        private bool WarehouseExists(int id)
        {
            return warehouseLogic.Read(new WarehouseBindingModel
            {
                ID = id
            }).Count == 1;
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
