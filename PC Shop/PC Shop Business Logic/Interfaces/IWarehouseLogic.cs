using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.View_Models;
using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Interfaces
{
    public interface IWarehouseLogic
    {
        void CreateOrUpdate(WarehouseBindingModel model);
        void Delete(WarehouseBindingModel model);
        List<WarehouseViewModel> Read(WarehouseBindingModel model);
        void Resupply(WarehouseComponentsBindingModel model);
        void Reserve(WarehouseComponentsBindingModel model);
        List<AvailableViewModel> GetAvailable(WarehouseComponentsBindingModel model);
    }
}
