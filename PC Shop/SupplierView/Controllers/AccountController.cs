using Microsoft.AspNetCore.Mvc;
using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.Business_Logic;
using PC_Shop_Business_Logic.Enums;
using PC_Shop_Business_Logic.Helpers;
using PC_Shop_Business_Logic.Interfaces;
using System;
using System.Diagnostics;

namespace SupplierView.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRequestLogic requestLogic;
        private readonly IWarehouseLogic warehouseLogic;
        private readonly SupplierBusinessLogic supplierLogic;
        private readonly IComponentMovementLogic movementLogic;

        public AccountController(SupplierBusinessLogic supplierLogic,
            IRequestLogic requestLogic, IWarehouseLogic warehouseLogic,
            IComponentMovementLogic movementLogic)
        {
            this.requestLogic = requestLogic;
            this.warehouseLogic = warehouseLogic;
            this.supplierLogic = supplierLogic;
            this.movementLogic = movementLogic;
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
                ID = id
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
            var warehouses = warehouseLogic.GetAvailable(new ResupplyWarehouseBindingModel
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

        public IActionResult SendWordReport(int id)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            try
            {
                supplierLogic.SendReport(new RequestReportInfo
                {
                    ReportType = ReportType.docx,
                    RequestID = id,
                    SupplierName = Program.Supplier.FullName
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
            return RedirectToAction("Main");
        }

        public IActionResult SendExcelReport(int id)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            try
            {
                supplierLogic.SendReport(new RequestReportInfo
                {
                    ReportType = ReportType.xlsx,
                    RequestID = id,
                    SupplierName = Program.Supplier.FullName
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
            return RedirectToAction("Main");
        }

        public IActionResult DateChoice()
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            return View("DateChoice");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MovementReport([Bind("StartDate, EndDate")] ComponentMovementBindingModel model)
        {
            if (Program.Supplier == null)
            {
                return new UnauthorizedResult();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    model.SupplierID = Program.Supplier.ID;
                    var movements = movementLogic.Read(model);
                    ViewBag.StartDate = model.StartDate;
                    ViewBag.EndDate = model.EndDate;
                    return View(movements);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View("DateChoice");
                }
            }
            else
            {
                return View("DateChoice");
            }
        }
    }
}