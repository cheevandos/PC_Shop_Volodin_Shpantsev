using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.View_Models;
using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Interfaces
{
    public interface IComponentMovementLogic
    {
        void Insert(ResupplyWarehouseBindingModel model);
        void Delete(RequestBindingModel model);
        List<ComponentMovementViewModel> Read(ComponentMovementBindingModel model);
    }
}
