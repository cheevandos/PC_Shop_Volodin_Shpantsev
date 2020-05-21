using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.View_Models;
using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Interfaces
{
    public interface IComputerLogic
    {
        void CreateOrUpdate(ComputerBindingModel model);
        void Delete(ComputerBindingModel model);
        List<ComputerViewModel> Read(ComputerBindingModel model);
    }
}
