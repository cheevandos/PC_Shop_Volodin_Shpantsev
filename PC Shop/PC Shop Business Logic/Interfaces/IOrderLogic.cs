using PC_Shop_Business_Logic.Binding_Models;
using PC_Shop_Business_Logic.View_Models;
using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Interfaces
{
    public interface IOrderLogic
    {
        void CreateOrUpdate(OrderBindingModel model);
        void Delete(OrderBindingModel model);
        List<OrderViewModel> Read(OrderBindingModel model);
        List<ReportOrderViewModel> ReadForReport(OrderBindingModel model);
    }
}
