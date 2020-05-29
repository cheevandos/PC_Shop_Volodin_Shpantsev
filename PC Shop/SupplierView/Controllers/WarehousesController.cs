using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Database_Implementation;
using PC_Shop_Database_Implementation.Models;
using PC_Shop_Business_Logic.Binding_Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SupplierView.Controllers
{
    public class WarehousesController : Controller
    {
        private readonly IWarehouseLogic warehouseLogic;

        public WarehousesController(IWarehouseLogic warehouseLogic)
        {
            this.warehouseLogic = warehouseLogic;
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
            ViewBag.Warehouse = id;
            var components = warehouseLogic.Read(new WarehouseBindingModel
            {
                ID = id
            });
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
                catch (Exception)
                {
                    if (!WarehouseExists(warehouse.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
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
    }
}
