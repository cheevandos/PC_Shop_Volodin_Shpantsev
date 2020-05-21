using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.View_Models;
using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Interfaces
{
    public interface ISupplierLogic
    {
        void CreateOrUpdate(SupplierBindingModel model);
        void Delete(SupplierBindingModel model);
        List<SupplierViewModel> Read(SupplierBindingModel model);
    }
}
