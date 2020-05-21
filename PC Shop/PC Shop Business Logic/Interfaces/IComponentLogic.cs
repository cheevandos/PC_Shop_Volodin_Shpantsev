using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.View_Models;
using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Interfaces
{
    public interface IComponentLogic
    {
        void CreateOrUpdate(ComponentBindingModel model);
        void Delete(ComponentBindingModel model);
        List<ComponentViewModel> Read(ComponentBindingModel model);
    }
}
